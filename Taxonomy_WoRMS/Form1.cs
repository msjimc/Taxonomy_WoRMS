using System;
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
                int counter = 0;
                Text = "Couting nodes";

                while (fr.Peek() > 0)
                {
                    line = fr.ReadLine();
                    node n = new node(line);
                    if (n.getIsGood == true) { counter++; }
                    line = null;
                }
                fr.Close();


                nodes = new Dictionary<int, node>(counter);
                fr = new System.IO.StreamReader(nodeFile);

                Text = "Making  " + counter.ToString("N0") + " nodes";
                Application.DoEvents();

                while (fr.Peek() > 0)
                {
                    line = fr.ReadLine();
                    node n = new node(line);
                    if (n.getIsGood == true)
                    {
                        nodes.Add(n.getTax_ID, n);
                    }
                    line = null;
                    n = null;
                }
                fr.Close();

                Text = "Linking nodes to form tree";
                Application.DoEvents();

                foreach (node n in nodes.Values)
                {
                    int parent = n.getParent_Tax_ID;
                    if (parent != n.getTax_ID)
                    {
                        if (nodes.ContainsKey(parent) == true)
                        { n.setParentNode(nodes[parent]); }
                        else
                        { throw new Exception("hum"); }
                    }
                }
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
            string namesFile = FileString.OpenAs("Select the NCBI vernacular names file (vernacularname.txt)", "vernacularname.txt|*.txt");
            if (System.IO.File.Exists(namesFile) == false) { return; }
            string formText = Text;

            System.IO.StreamReader fr = null;
            string[] items = null;
            int counter = 0;

            try
            {
                Text = "Counting names";
                Application.DoEvents();

                fr = new System.IO.StreamReader(namesFile);
                while (fr.Peek() > 0)
                {
                    items = fr.ReadLine().Split('|');
                    leaf l = new leaf(items);
                    if (l.getIsGood == true) { counter++; }
                    items = null;
                }
                fr.Close();

                leafs = new leaf[counter];
                Text = "Adding " + counter.ToString("N0") + " names to nodes";
                Application.DoEvents();

                counter = 0;
                fr = new System.IO.StreamReader(namesFile);

                while (fr.Peek() > 0)
                {
                    items = fr.ReadLine().Split('|');
                    leaf l = new leaf(items);
                    if (l.getIsGood == true)
                    {
                        leafs[counter] = l;
                        if (nodes.ContainsKey(l.getTax_ID) == true)
                        { nodes[l.getTax_ID].setNames(l); }
                        counter++;
                    }
                    items = null;
                    l = null;
                }

                Text = "Sorting list of names";
                Application.DoEvents();
                Array.Sort(leafs, new leafComparer());

                btnNameSearch.Enabled = true;
                btnTaxoIDSearch.Enabled = true;
                btnAnnotate.Enabled = true;
                btnSave.Enabled = true;

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
                    if (nodes.ContainsKey(Convert.ToInt32(items[0])) == true)
                    { result = nodes[Convert.ToInt32(items[0])].getString(); }
                    results[count++] = l + "\t" + result + "\t" + l;
                }
            }

            count = 0;
            Array.Sort(results);
            foreach (string l in results)
            {
                if (string.IsNullOrEmpty(l) == false)
                { count++; }
            }
            string[] cleanResuts = new string[count];
            count = 0;
            foreach (string l in results)
            {
                if (string.IsNullOrEmpty(l) == false)
                {
                    cleanResuts[count] = l;
                    count++;
                }
            }
            txtData.Lines = cleanResuts;
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

            txtData.Clear();
            leafBinarySearch lbs = new leafBinarySearch();
            foreach (string i in cleanInput)
            {
                string name = i.Trim().ToLower();
                int index = Array.BinarySearch(leafs, name, lbs);
                if (index > -1)
                {
                    string answer = i + "\t";
                    if (nodes.ContainsKey(leafs[index].getTax_ID) == true)
                    {
                        answer += "\t" + nodes[leafs[index].getTax_ID].getString() + "\r\n";
                    }
                    else { answer += "No infomation\r\n"; }
                    txtData.Text += answer;
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
                            answer += firstName + "\t" + nodes[leafs[index1].getTax_ID].getString() + "\r\n";
                        }
                        else { answer += "No infomation\r\n"; }
                        txtData.Text += answer;
                    }
                    else
                    { txtData.Text += i + "\t\tNot found\r\n"; }
                }
            }

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
                    string reply = putInConsistentOrder(nodes[leafs[index].getTax_ID].getString());
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
                        string reply = putInConsistentOrder(nodes[leafs[index1].getTax_ID].getString());
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            string fileName = FileString.SaveAs("Enter name of file to save taxonomy too", "*.tax|*.tax");
            if (fileName.Equals("Cancel") == true) { return; }
            string title = Text;

            System.IO.StreamWriter fw = null;
            try
            {
                fw = new System.IO.StreamWriter(fileName);

                Text = "Saving nodes";
                Application.DoEvents();

                fw.WriteLine("##Nodes##" + nodes.Count.ToString());

                foreach (node n in nodes.Values)
                {
                    fw.WriteLine(n.Serialise());
                }

                Text = "Saving leafs";
                Application.DoEvents();

                fw.WriteLine("##Leaf##" + leafs.Length.ToString() + "##");
                foreach (leaf l in leafs)
                { fw.WriteLine(l.Serialise()); }

            }
            catch (Exception ex)
            { MessageBox.Show("Error saving data to file: " + ex.Message); }
            finally
            {
                if (fw != null) { fw.Close(); }
                Text = title;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string fileName = FileString.OpenAs("Select the file of serialised NCBI taxonmic data", "*.tax|*.tax");
            if (System.IO.File.Exists(fileName) == false) { return; }

            System.IO.StreamReader sf = null;

            btnNameSearch.Enabled = false;
            btnTaxoIDSearch.Enabled = false;
            btnAnnotate.Enabled = false;
            string title = Text;
            try
            {
                sf = new System.IO.StreamReader(fileName);

                string line = sf.ReadLine();
                if (line.StartsWith("##Nodes##") == true)
                {
                    Text = "Importing nodes";
                    Application.DoEvents();

                    int number = Convert.ToInt32(line.Substring(9));
                    nodes = new Dictionary<int, node>(number);
                    while (sf.Peek() > 0)
                    {
                        line = sf.ReadLine();
                        if (line.StartsWith("##Leaf##") == true)
                        { break; }
                        else
                        {
                            node n = new node(line, true);
                            nodes.Add(n.getTax_ID, n);
                        }
                    }

                    Text = "Linking nodes to form tree";
                    Application.DoEvents();

                    foreach (node n in nodes.Values)
                    {
                        int parent = n.getParent_Tax_ID;
                        if (parent != n.getTax_ID)
                        {
                            if (nodes.ContainsKey(parent) == true)
                            { n.setParentNode(nodes[parent]); }
                            else
                            { throw new Exception("hum"); }
                        }
                    }

                    Text = "Importing leafs";
                    Application.DoEvents();

                    number = Convert.ToInt32(line.Substring(8, line.Length - 10));
                    leafs = new leaf[number];
                    int counter = 0;

                    while (sf.Peek() > 0)
                    {
                        line = sf.ReadLine();
                        leaf l = new leaf(line);
                        leafs[counter++] = l;
                    }

                }
                btnNameSearch.Enabled = true;
                btnTaxoIDSearch.Enabled = true;
                btnAnnotate.Enabled = true;
            }
            catch (Exception ex)
            { MessageBox.Show("Error saving data to file: " + ex.Message); }
            finally
            {
                if (sf != null) { sf.Close(); }
                Text = title;
            }
        }
    }
}