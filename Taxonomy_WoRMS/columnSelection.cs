﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxonomy_WoRMS
{
    public partial class columnSelection : Form
    {
        private List<string> firstLines = null;
        private int counter = 0;
        private char first;
        private bool firstSet = false;
        private char second;
        private bool secondSet = false;
        private int firstFirstIndex = 1;
        private int firstSecondIndex = 1;
        private int secondFirstIndex = 1;
        private int secondSecondIndex = 1;
        private int itemsCount = -1;

        public columnSelection(string fileName)
        {
            InitializeComponent();
            System.IO.StreamReader fr = null;
            try
            {
                fr = new System.IO.StreamReader(fileName);
                int count = 1;

                firstLines = new List<string>();

                while (fr.Peek() > 0 && count < 51)
                {
                    string line = fr.ReadLine();
                    if (string.IsNullOrEmpty(line.Trim()) == false)
                    {
                        firstLines.Add(line);
                        count++;
                    }
                }

                if (firstLines.Count > 0)
                { txtLine.Text = firstLines[counter]; }
            }
            catch { MessageBox.Show("Error reading file"); }
            finally { if (fr != null) { fr.Close(); } }
        }

        private void columnSelection_Load(object sender, EventArgs e)
        {

        }

        private void txtFirstSplit_TextChanged(object sender, EventArgs e)
        {
            string value = txtFirstSplit.Text;
            if (value==" ")
            { value = "\\s"; }
            if (value.Length > 0)
            {
                if (txtFirstSplit.Text == "\\t")
                { first = '\t'; }
                else if (txtFirstSplit.Text == "\\s")
                { first = ' '; }
                else
                { first = value[0]; }
                firstSet = true;
            }
            else
            { firstSet = false; }
            SplitCurrentLine();
        }

        private void txtSecondSplit_TextChanged(object sender, EventArgs e)
        {
            string value = txtSecondSplit.Text;
            if (value == " ")
            { value = "\\s"; }
            if (value.Length > 0)
            {

                if (txtSecondSplit.Text == "\\t")
                { second = '\t'; }
                else if (txtSecondSplit.Text == "\\s")
                { second = ' '; }
                else
                { second = value[0]; }

                secondSet = true;
            }
            else
            { secondSet = false; }
            SplitCurrentLine();
        }

        private void nudFirstFirstColumn_ValueChanged(object sender, EventArgs e)
        {
            firstFirstIndex = (int)nudFirstFirstColumn.Value;
            if (nudFirstSecondColumn.Value < firstFirstIndex)
            { nudFirstSecondColumn.Value = firstFirstIndex; }
            SplitCurrentLine();
        }

        private void nudFirstSecondColumn_ValueChanged(object sender, EventArgs e)
        {
            firstSecondIndex = (int)nudFirstSecondColumn.Value;
            if (nudFirstFirstColumn.Value > firstSecondIndex)
            { nudFirstFirstColumn.Value = firstSecondIndex; }
            SplitCurrentLine();
        }

        private void nudSecondFirstColumn_ValueChanged(object sender, EventArgs e)
        {
            secondFirstIndex = (int)nudSecondFirstColumn.Value;
            if (nudSecondSecondColumn.Value < secondFirstIndex)
            { nudSecondSecondColumn.Value = secondFirstIndex; }
            SplitCurrentLine();
        }

        private void nudSecondSecondColumn_ValueChanged(object sender, EventArgs e)
        {
            secondSecondIndex = (int)nudSecondSecondColumn.Value;
            if (nudSecondFirstColumn.Value > secondSecondIndex)
            { nudSecondFirstColumn.Value = secondSecondIndex; }
            SplitCurrentLine();
        }

        private void SplitCurrentLine()
        {
            try
            {
                fieldsToSearch list = getFieldsToSearch();
                List<string> terms = list.words(firstLines[counter]);

                string response = "";

                foreach (string term in terms)
                { response += term + "  OR  "; }

                if (response.Length > 6)
                { txtSelected.Text = response.Substring(0, response.Length - 6); }
                else { Reason(); }
            }
            catch { }
        }

        private void Reason()
        {
            if (firstSet == false)
            {
                txtSelected.Text = "First delimiting charater not split";
                return;
            }

            int localFF = firstFirstIndex - 1;
            int localFS = firstSecondIndex - 1;
            int localSF = secondFirstIndex - 1;
            int localSS = secondSecondIndex - 1;

            bool answer = false;

            string[] items = firstLines[firstFirstIndex].Split(first);
            itemsCount = items.Length;

            if (localFF > items.Length - 1)
            {
                txtSelected.Text = "Index(es) for first character out of range: line split in to " + items.Length + " columns";
                return;
            }

            if (chkFirstFromEnd.Checked)
            {
                localFS = items.Length - 1 - (firstFirstIndex - 1);
                localFF = items.Length - 1 - (firstSecondIndex - 1);
            }

            if (secondSet == true)
            {
                items = items[localFF].Split(second);
                itemsCount--;

                if (chkSecondFromEnd.Checked)
                {
                    localSS = items.Length - 1 - (secondFirstIndex - 1);
                    localSF = items.Length - 1 - (secondSecondIndex - 1);
                }

                if (localSF < items.Length && localSS < items.Length)
                {
                    if (chkCombinefields.Checked == true)
                    {
                        for (int index = localSF; index < localSS; index++)
                        {
                            if (index > -1 && index + 1 < items.Length)
                            { answer = true; }
                        }
                    }
                    else
                    {
                        for (int index = localSF; index < localSS + 1; index++)
                        {
                            if (index > -1 && index < items.Length)
                            { answer = true; }
                        }
                    }
                    if (answer == false)
                    { txtSelected.Text = "Index(es) for second character out of range: line split in to " + items.Length + " columns"; }
                }
                else { txtSelected.Text = "Index(es) for second character out of range: line split in to " + items.Length + " columns"; }
            }
            else
            {
                itemsCount -= (localFS - localFF);
                if (localFF < items.Length && localFS < items.Length)
                {
                    if (chkCombinefields.Checked == true)
                    {
                        for (int index = localSF; index < localSS; index++)
                        {
                            if (index > -1 && index + 1 < items.Length)
                            { answer = true; }
                        }
                    }
                    else
                    {
                        for (int index = localFF; index < localFS + 1; index++)
                        {
                            if (index > -1 && index < items.Length)
                            { answer = true; }
                        }
                    }
                    if (answer == false)
                    { txtSelected.Text = "Index(ex) for first character out of range: line split in to " + items.Length + " columns"; }
                }
                else { txtSelected.Text = "Index(ex) for first character out of range: line split in to " + items.Length + " columns"; }
            }
        }

        private void SplitCurrentLineOld()
        {
            int localFF = firstFirstIndex - 1;
            int localFS = firstSecondIndex - 1;
            int localSF = secondFirstIndex - 1;
            int localSS = secondSecondIndex - 1;

            string answer = "";

            txtSelected.Text = "";
            string line = firstLines[counter];
            if (firstSet == false)
            {
                txtSelected.Text = "First delimiting charater not split";
                return;
            }

            string[] items = line.Split(first);
            itemsCount = items.Length;

            if (localFF > items.Length - 1)
            {
                txtSelected.Text = "Index(es) for first character out of range: line split in to " + items.Length + " columns";
                return;
            }

            if (chkFirstFromEnd.Checked)
            {
                localFS = items.Length - 1 - (firstFirstIndex - 1);
                localFF = items.Length - 1 - (firstSecondIndex - 1);
            }

            if (secondSet == true)
            {
                items = items[localFF].Split(second);
                itemsCount--;

                if (chkSecondFromEnd.Checked)
                {
                    localSS = items.Length - 1 - (secondFirstIndex - 1);
                    localSF = items.Length - 1 - (secondSecondIndex - 1);
                }

                if (localSF < items.Length && localSS < items.Length)
                {
                    if (chkCombinefields.Checked == true)
                    {
                        for (int index = localSF; index < localSS; index++)
                        {
                            if (index > -1 && index + 1 < items.Length)
                            { answer += items[index] + " " + items[index + 1] + "  OR  "; }
                        }
                    }
                    else
                    {
                        for (int index = localSF; index < localSS + 1; index++)
                        {
                            if (index > -1 && index < items.Length)
                            { answer += items[index] + "  OR  "; }
                        }
                    }
                    if (answer.Length > 6)
                    { txtSelected.Text = answer.Substring(0, answer.Length - 6); }
                    else { txtSelected.Text = "Index(es) for second character out of range: line split in to " + items.Length + " columns"; }

                }
                else { txtSelected.Text = "Index(es) for second character out of range: line split in to " + items.Length + " columns"; }
            }
            else
            {
                itemsCount -= (localFS - localFF);
                if (localFF < items.Length && localFS < items.Length)
                {
                    if (chkCombinefields.Checked == true)
                    {
                        for (int index = localSF; index < localSS; index++)
                        {
                            if (index > -1 && index + 1 < items.Length)
                            { answer += items[index] + " " + items[index + 1] + "  OR  "; }
                        }
                    }
                    else
                    {
                        for (int index = localFF; index < localFS + 1; index++)
                        {
                            if (index > -1 && index < items.Length)
                            { answer += items[index] + "  OR  "; }
                        }
                    }
                    if (answer.Length > 6)
                    { txtSelected.Text = answer.Substring(0, answer.Length - 6); }
                    else
                    { txtSelected.Text = "Index(ex) for first character out of range: line split in to " + items.Length + " columns"; }
                }
                else { txtSelected.Text = "Index(ex) for first character out of range: line split in to " + items.Length + " columns"; }
            }

        }

        private void btnPervious_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                txtLine.Text = firstLines[counter];
                SplitCurrentLine();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (counter < 20 && counter < firstLines.Count - 2)
            {
                counter++;
                txtLine.Text = firstLines[counter];
                SplitCurrentLine();
            }
        }

        private void chkFirstFromEnd_CheckedChanged(object sender, EventArgs e)
        {
            SplitCurrentLine();
        }

        private void chkSecondFromEnd_CheckedChanged(object sender, EventArgs e)
        {
            SplitCurrentLine();
        }

        private void chkCombinefields_CheckedChanged(object sender, EventArgs e)
        {
            SplitCurrentLine();
        }

        private void chkReverseOrder_CheckedChanged(object sender, EventArgs e)
        {
            SplitCurrentLine();
        }
        private void chkIgnoreNones_CheckedChanged(object sender, EventArgs e)
        {
            SplitCurrentLine();
        }

        public fieldsToSearch getFieldsToSearch()
        {
            if (firstSet == true)
            {
                fieldsToSearch fts = new fieldsToSearch(first, secondSet, second, chkFirstFromEnd.Checked, firstFirstIndex, firstSecondIndex, chkSecondFromEnd.Checked, secondFirstIndex, secondSecondIndex, itemsCount, chkCombinefields.Checked, chkReverseOrder.Checked, chkIgnoreNones.Checked);
                return fts;
            }
            else
            { return null; }
        }

    }
}
