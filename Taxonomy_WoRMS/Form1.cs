using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Taxonomy_WoRMS
{
    public partial class Form1 : Form
    {
        leaf[] leafs = null;
        Dictionary<int, node> nodes = null;
        List<string> filesToProcesss = null;
        string[] order = { "(superkingdom)", "(kingdom)", "(phylum)", "(subphylum)", "(superclass)", "(class)", "(subclass)", "(superorder)", "(order)", "(suborder)", "(infraorder)", "(parvorder)", "(superfamily)", "(family)", "(subfamily)", "(supertride)", "(tribe)", "(subtribe)", "(genus)", "(species)" };
        Dictionary<string, string> data = null;
        string title = "";
        fieldsToSearch fts = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nodeFile = FileString.OpenAs("Select the Worms taxonomy file (taxon.txt)", "taxon.txt|*.txt");
            if (System.IO.File.Exists(nodeFile) == false) { return; }

            System.IO.StreamReader fr = null;
            string formText = Text;
            try
            {
                fr = new System.IO.StreamReader(nodeFile);
                string line = "";
                string[] items = null;
                int counter = 0;

                nodes = new Dictionary<int, node>(counter);

                Text = "Getting taxonomy data";
                Application.DoEvents();

                fr.ReadLine();

                while (fr.Peek() > 0)
                {
                    line = fr.ReadLine();
                    items = line.Split('\t');
                    string lastName = "";
                    int index = items[0].LastIndexOf(":") + 1;
                    if (index > 0)
                    {
                        string sID = items[0].Substring(index).Trim();
                        int ID = -1;
                        try
                        {                           
                            ID = Convert.ToInt32(sID);
                            string taxonomy = "";
                            lastName = items[7];
                            for (int place = 10; place < 17; place++)
                            {

                                if (string.IsNullOrEmpty(items[place]) == false)
                                {
                                    taxonomy += items[place] + "\t";
                                    lastName = items[place] + ".";
                                }
                                else
                                {
                                    taxonomy += lastName + "\t";
                                    lastName += ".";
                                }
                            }
                            taxonomy += items[6] + "\t[" + items[22] + "]";
                            if (items[15]=="")
                            { }
                            node n = new node(ID, taxonomy, items[15] + " " + items[17], items[5], items[6], items[19]);
                            if (n.getIsGood == true)
                            { nodes.Add(n.getTax_ID, n); }
                        }
                        catch { }
                    }

                }


                fr.Close();

                btnGetNames.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error reading data file", "Error");
            }
            finally
            {
                if (fr != null) { fr.Close(); }
                Text = formText;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string namesFile = FileString.OpenAs("Select the WoRMS vernacular names file (vernacularname.txt)", "vernacularname.txt|*.txt");
            if (System.IO.File.Exists(namesFile) == false) { return; }
            string formText = Text;

            System.IO.StreamReader fr = null;
            string[] items = null;
            
            try
            {               
                Text = "Adding names to nodes";
                Application.DoEvents();

               List<leaf> allLeafs=new List<leaf>();

                 fr = new System.IO.StreamReader(namesFile);

                while (fr.Peek() > 0)
                {
                    items = fr.ReadLine().Split('\t');
                    if (items[3].ToUpper().Equals("ENG") == true)
                    {
                        leaf l = new leaf(items);
                        if (l.getIsGood == true)
                        {
                            allLeafs.Add( l);
                        }
                        l = null;
                    }
                    items = null;
                   
                }

                foreach (node n in nodes.Values)
                {
                    allLeafs.AddRange(n.getLeafs());
                }
                leafs=allLeafs.ToArray();

                Text = "Sorting list of " + allLeafs.Count.ToString("N0") + " common English and latin names";
                Application.DoEvents();
                Array.Sort(leafs, new leafComparer());

                btnNameSearch.Enabled = true;
                btnTaxoIDSearch.Enabled = true;
                btnAnnotate.Enabled = true;                
            }
            catch { MessageBox.Show("Error reading data file", "Error"); }
            finally
            {
                if (fr != null) { fr.Close(); }
                Text = formText;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = textBox1.Lines.Count();
            string[] input = textBox1.Lines;
            string[] results = new string[count];
            txtData.Clear();
            count = 0;
            foreach (string l in input)
            {
                string result = "";
                string[] items = l.Split('\t');
                if (string.IsNullOrEmpty(items[0]) == false)
                {
                    try
                    {
                        if (nodes.ContainsKey(Convert.ToInt32(items[0])) == true)
                        { result = nodes[Convert.ToInt32(items[0])].getString(); }
                        else { result = "Not found"; }
                        results[count++] = l + "\t" + result + "\t" + l;
                    }
                    catch { results[count++] = l + "\tError\t" + l; }
                }
                else { results[count++] = l + "\tBlank\t" + l; }
            }
            
            txtData.Lines = results;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (string l in textBox1.Lines)
            {
                if (string.IsNullOrEmpty(l) == false)
                { count++; }
            }
            string[] cleanInput = new string[count];
            count = 0;
            foreach (string l in textBox1.Lines)
            {
                if (string.IsNullOrEmpty(l) == false)
                {
                    cleanInput[count] = l;
                    count++;
                }
            }

            if (cleanInput.Length != textBox1.Lines.Length)
            {
                if (MessageBox.Show("Do you want to ignore empty lines?", "Ignore spaces", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                { cleanInput = textBox1.Lines; }
            }

            List<string> results = new List<string>();

            txtData.Clear();
            leafBinarySearch lbs = new leafBinarySearch();
            foreach (string i in cleanInput)
            {
                string name = i.Trim().ToLower();
                if (string.IsNullOrEmpty(name) == true)
                { results.Add("Blank"); }
                else
                {
                    int index = Array.BinarySearch(leafs, name, lbs);
                    if (index > -1)
                    {
                        string answer = i + "\t";
                        if (nodes.ContainsKey(leafs[index].getTax_ID) == true)
                        {
                            answer += "\t" + nodes[leafs[index].getTax_ID].getString();
                        }
                        else { answer += "No infomation"; }
                        results.Add(answer);
                    }
                    else
                    {
                        string firstName = name.Split(' ')[0];
                        int index1 = Array.BinarySearch(leafs, firstName, lbs);
                        if (index1 > -1)
                        {
                            string answer = i + "\t";
                            if (nodes.ContainsKey(leafs[index1].getTax_ID) == true)
                            {
                                answer += firstName + "\t" + nodes[leafs[index1].getTax_ID].getString();
                            }
                            else { answer += "No infomation"; }
                            results.Add(answer);
                        }
                        else
                        {
                            results.Add(i + "\t\tNot found"); 
                        }
                    }
                }
            }
            txtData.Lines = results.ToArray();

        }

        private void btnNamesFile_Click(object sender, EventArgs e)
        {
            string fileName = FileString.OpenAs("Select the file containing the Blast hit descriptions", "Tab-delimited text file (*.txt; *.xls)|*.txt;*.xls");
            if (System.IO.File.Exists(fileName) == false) { return; }

            System.IO.StreamReader fs = null;

            errorFree = true;
            try
            {
                columnSelection cs = new columnSelection(fileName);
                if (cs.ShowDialog() != DialogResult.OK)
                { return; }

                fts = cs.getFieldsToSearch();

                filesToProcesss = new List<string>();
                if (chkFolder.Checked == true)
                {
                    string folder = fileName.Substring(0, fileName.LastIndexOf("\\"));
                    string[] files = System.IO.Directory.GetFiles(folder, "*.txt");
                    filesToProcesss.AddRange(files);
                }
                else { filesToProcesss.Add(fileName); }
                ProcessFile();

                if (errorFree == true) { MessageBox.Show("Task completed", "Success"); }
            }
            catch
            { }
            finally
            {
                if (fs != null) { fs.Close(); }
            }

        }

        private bool errorFree = true;
        private void ProcessFile()
        {
            if (fts == null) { return; }

            data = new Dictionary<string, string>();

            System.IO.StreamReader fs = null;
            System.IO.StreamWriter fw = null;
            try
            {
                string line = null;
                txtData.Clear();
                string description = "";


                fw = new System.IO.StreamWriter(filesToProcesss[0].Substring(0, filesToProcesss[0].LastIndexOf(".")) + "_annotated.txt");
                foreach (string fileToProcesss in filesToProcesss)
                {
                    fs = new System.IO.StreamReader(fileToProcesss);
                    string taxonomy = string.Join("\t", order);
                    taxonomy = taxonomy.Replace("(", "").Replace(")", "");
                    char delimitor = fts.FirstDelimitor;

                    while (fs.Peek() > 0)
                    {
                        line = fs.ReadLine().Trim();
                        List<string> words = fts.words(line);

                        foreach (string word in words)
                        {
                            description = word;
                            string name = getNameFromDescription(description);
                            if (string.IsNullOrEmpty(name) == false)
                            {
                                string returned = GetTaxonomicData(name);
                                if (returned.Equals("No infomation") == false)
                                {
                                    fw.WriteLine(fts.BaseLine(line) + delimitor + returned);
                                    break;
                                }
                            }
                            else
                            {

                            }
                        }
                    }
                }
                btnCombine.Enabled = true;
            }
            catch
            {
                errorFree = false;
                btnCombine.Enabled = false;
            }
            finally
            {
                if (fs != null) { fs.Close(); }
                if (fw != null) { fw.Close(); }
            }
        }

        private string getNameFromDescription(string description)
        {
            if (description.StartsWith("uncultured") == true)
            { return ""; }
            else if (description.StartsWith("predicted:") == true)
            { return ""; }
            else if (description.StartsWith("bacterium") == true)
            { return ""; }

            string[] items = description.Trim().Split(' ');
            string answer = "";
            if (items.Length > 1)
            { answer = items[0] + " " + items[1]; }
            else if (items.Length == 1)
            { answer = items[0] + " "; }
            return answer;
        }

        private string GetTaxonomicData(string theName)
        {
            string answer = "";

            leafBinarySearch lbs = new leafBinarySearch();

            string name = theName.Trim().ToLower();
            int index = Array.BinarySearch(leafs, name, lbs);
            if (index > -1)
            {
                answer = theName + "\t";
                if (nodes.ContainsKey(leafs[index].getTax_ID) == true)
                {
                    string reply = nodes[leafs[index].getTax_ID].getString();
                    if (reply.Equals("No infomation") == true)
                    { answer = reply; }
                    else
                    { answer += reply; }
                }
                else { answer += "No infomation"; }
            }
            else
            {
                string firstName = name.Split(' ')[0];
                int index1 = Array.BinarySearch(leafs, firstName, lbs);
                if (index1 > -1)
                {
                    answer = theName + "\t";
                    if (nodes.ContainsKey(leafs[index1].getTax_ID) == true)
                    {
                        string reply =nodes[leafs[index1].getTax_ID].getString();
                        if (reply.Equals("No infomation") == true)
                        { answer = reply; }
                        else
                        { answer = firstName + "\t" + reply; }
                    }
                    else { answer += "No infomation"; }
                }
                else
                {
                    answer = "No infomation";
                }
            }

            return answer;
        }

        private string putInConsistentOrder(string currentTaxonomy)
        {
            if (string.IsNullOrEmpty(currentTaxonomy) == true)
            { return "No infomation"; }

            try
            {
                string[] items = currentTaxonomy.Trim().Split('\t');
                string[] final = new string[order.Length];

                for (int index = 0; index < items.Length; index++)
                {
                    int bracket = items[index].IndexOf("(");
                    string thisclass = items[index].Substring(bracket, items[index].Length - bracket);
                    int finalIndex = Array.IndexOf(order, thisclass);
                    if (finalIndex > -1) { final[finalIndex] = items[index].Substring(0, bracket - 1); }
                }

                if (string.IsNullOrEmpty(final[0]) == true)
                { final[0] = "."; }

                for (int index = 1; index < final.Length; index++)
                {
                    if (string.IsNullOrEmpty(final[index]) == true)
                    { final[index] = "." + final[index - 1]; }
                }

                return string.Join("\t", final);
            }
            catch
            { return "No infomation"; }
        }

        private void btnCombine_Click(object sender, EventArgs e)
        {
            countMatrix cM = new countMatrix();
            cM.ShowDialog();

            return;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}