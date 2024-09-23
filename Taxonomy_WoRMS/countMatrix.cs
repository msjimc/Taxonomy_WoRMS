using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxonomy_WoRMS
{
    public partial class countMatrix : Form
    {
        private Dictionary<string, string> matrix = new Dictionary<string, string>();
        private char split;
        private bool splitSet;
        private List<string> sampleNames;
        private List<string> speciesName;
        private List<string> first50Lines;
        private int first50LinesIndex;
        private string blastFile = "";
        private string matrixFile = "";

        public countMatrix()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            string fileName = FileString.OpenAs("Select the read counts matrix file", "*.txt|*.txt");
            if (System.IO.File.Exists(fileName) == false) { return; }

            List<string> columnNames = new List<string>();
            List<string> rowNames = new List<string>();
            matrix = new Dictionary<string, string>();

            System.IO.StreamReader sf = null;

            try
            {
                string line;
                string[] items = null;
                sf = new System.IO.StreamReader(fileName);

                line = sf.ReadLine();
                int indexSplit = line.IndexOf(split);
                if (indexSplit != -1)
                { line = line.Substring(indexSplit + 1); }
                items = line.Split(split);
                columnNames.AddRange(items);

                int rowCount = 0;
                while (sf.Peek() > 0)
                {

                    line = sf.ReadLine();
                    items = line.Split(split);
                    if (items.Length > 1)
                    {
                        rowNames.Add(items[0]);
                        for (int index = 1; index < items.Length; index++)
                        {
                            if (rdoColumn.Checked == true)
                            { matrix.Add(rowCount.ToString() + ":" + (index - 1).ToString(), items[index]); }
                            else
                            { matrix.Add((index).ToString() + ":" + rowCount.ToString(), items[index]); }
                        }
                    }
                    rowCount++;
                }

                if (rdoColumn.Checked == false)
                {
                    sampleNames = rowNames;
                    speciesName = columnNames;
                }
                else
                {
                    sampleNames = columnNames;
                    speciesName = rowNames;
                }

                setUpcomboList();

                matrixFile = fileName;
            }
            catch (Exception ex) { MessageBox.Show("Couldn't process the file:" + ex.Message, "Error"); }
            finally
            { if (sf != null) { sf.Close(); } }
        }

        private void setUpcomboList()
        {
            int countSucess = 0;

            cboSamples.Items.Clear();
            cboSpecies.Items.Clear();
            for (int index = 0; index < 4; index++)
            {
                if (index < speciesName.Count) { cboSpecies.Items.Add(speciesName[index]); }
                if (index < sampleNames.Count) { cboSamples.Items.Add(sampleNames[index]); }
            }

            if (cboSamples.Items.Count > 0)
            {
                cboSamples.Enabled = true;
                cboSamples.SelectedIndex = 0;
                countSucess++;
            }
            else { cboSamples.Enabled = false; }

            if (cboSpecies.Items.Count > 0)
            {
                cboSpecies.Enabled = true;
                cboSpecies.SelectedIndex = 0;
                countSucess++;
            }
            else { cboSpecies.Enabled = false; }

            if (countSucess == 2)
            { gbCombine.Enabled = true; }
            else { gbCombine.Enabled = false; }
        }

        private void txtSplit_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSplit.Text.Trim()) == true)
            { splitSet = false; }
            else
            {
                if (txtSplit.Text == "\\t")
                { split = '\t'; }
                else if (txtSplit.Text == "\\s")
                { split = ' '; }
                else
                { split = txtSplit.Text.Trim()[0]; }
                splitSet = true;
            }
            isbtnFileActive();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isbtnFileActive();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            isbtnFileActive();
        }

        private void isbtnFileActive()
        {
            if (splitSet == true && (rdoColumn.Checked == true || rdoRow.Checked == true))
            { btnFile.Enabled = true; }
            else { btnFile.Enabled = false; }
        }

        private void btnSelectBlast_Click(object sender, EventArgs e)
        {

            string fileName = FileString.OpenAs("Select the annotated blast hit file", "*.txt|*.txt");
            if (System.IO.File.Exists(fileName) == false) { return; }

            System.IO.StreamReader sf = null;

            try
            {
                sf = new System.IO.StreamReader(fileName);
                first50Lines = new List<string>();

                int lineCount = 0;
                while (sf.Peek() > 0)
                {
                    string line = sf.ReadLine();
                    first50Lines.Add(line);
                    lineCount++;
                    if (lineCount > 49) { break; }
                }

                populateList();

                blastFile = fileName;
            }
            catch (Exception ex) { MessageBox.Show("Couldn't process the file:" + ex.Message, "Error"); }
            finally
            { if (sf != null) { sf.Close(); } }
        }

        private void populateList()
        {
            string line = first50Lines[first50LinesIndex];
            string[] items = line.Split('\t');

            cboFields.Items.Clear();
            cboFields.Items.Add("Select");
            foreach (string item in items)
            { cboFields.Items.Add(item); }
            cboFields.SelectedIndex = 0;
        }

        private void IsbtnCombineActive()
        {
            int countSucess = 0;
            if (cboFields.SelectedIndex > 0) { countSucess++; }
            if (rdoIndexMatch.Checked == true || rdoNameMatch.Checked == true) { countSucess++; }

            if (countSucess == 2)
            { btnCombine.Enabled = true; }
            else { btnCombine.Enabled = false; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsbtnCombineActive();
        }

        private void rdoNameMatch_CheckedChanged(object sender, EventArgs e)
        {
            IsbtnCombineActive();
        }

        private void rdoIndexMatch_CheckedChanged(object sender, EventArgs e)
        {
            IsbtnCombineActive();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (first50LinesIndex > 0)
            {
                first50LinesIndex--;
                populateList();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (first50LinesIndex < first50Lines.Count - 1)
            {
                first50LinesIndex++;
                populateList();
            }
        }

        private void btnCombine_Click(object sender, EventArgs e)
        {
            string folder = matrixFile.Substring(0, matrixFile.LastIndexOf("\\") + 1);
            string newName = folder + matrixFile.Substring(matrixFile.LastIndexOf("\\") + 1) + "_" + blastFile.Substring(blastFile.LastIndexOf("\\") + 1);

            System.IO.StreamReader sfBlast = null;
            System.IO.StreamWriter fw = null;

            try
            {
                char delimiter = split;

                List<string> speciesNamesLowerCase = GetspeciesNamesLowerCase();

                sfBlast = new System.IO.StreamReader(blastFile);
                fw = new System.IO.StreamWriter(newName);

                string line = "";
                string[] items = null;
                int speciesIndex = -1;

                foreach (string name in sampleNames)
                { fw.Write("\t" + name); }
                fw.Write("\n");
 
                while (sfBlast.Peek() > 0)
                {
                    line = sfBlast.ReadLine();
                    items = line.Split('\t');
                    if (rdoIndexMatch.Checked == true)
                    { speciesIndex = int.Parse(items[cboFields.SelectedIndex - 1].Trim()); }
                    else
                    { speciesIndex = 1 + speciesNamesLowerCase.IndexOf(items[cboFields.SelectedIndex - 1].Trim().ToLower()); }


                    fw.Write(items[cboFields.SelectedIndex - 1].Trim() + "_" + speciesName[speciesIndex - 1] + delimiter);
                    for (int sample = 0; sample < sampleNames.Count; sample++)
                    {
                        if (matrix.ContainsKey(speciesIndex.ToString() + ":" + sample.ToString()) == true)
                        { fw.Write(matrix[speciesIndex.ToString() + ":" + sample.ToString()] + delimiter); }
                        else
                        { fw.Write("NA" + delimiter); }
                    }
                    fw.Write(line + "\n");
                }

                MessageBox.Show("Task completed", "Success");

            }
            catch (Exception ex) { MessageBox.Show("Couldn't read the annotated blast file", "Error"); }
            finally
            {
                if (sfBlast != null) { sfBlast.Close(); }
                if (fw != null) { fw.Close(); }
            }

        }

        private List<string> GetspeciesNamesLowerCase()
        {
            List<string> speciesNamesLowerCase = new List<string>();
            foreach (string name in speciesName)
            {
                speciesNamesLowerCase.Add(name.Trim().ToLower());
            }
            return speciesNamesLowerCase;
        }
    }
}

