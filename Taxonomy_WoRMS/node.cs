using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxonomy_WoRMS
{
    class node
    {
        private int tax_id = -1;
        private int parent_tax_id = -1;
        private string rank = "";
        private string embl_code = "";
        private byte division_id = 255;
        private byte inherited_div_flag = 255;
        private byte genetic_code_id = 255;
        private byte inherited_GC_flag = 255;
        private byte mitochondrial_code_id = 255;
        private byte inherited_MGC_flag = 255;
        private byte genBank_hidden_flag = 255;
        private byte hidden_subtree_root_flag = 255;
        private bool isGood = false;
        private bool hasBeenAdded = false;
        private string scienceName = "";
        private node parent = null;
        
        private string ScientificName="";
        private string Synonym = "";
        private string Acronym = "";
        private string anamorph = "";
        private string teleomorph = "";
        private string equivalent_name	="";
        private string genbank_common_name = "";
        private string Genbank_synonym = "";
        private string Genbank_acronym = "";
        private string Genbank_anamorph = "";

        

        public node(string line)
        {
            string[] items = line.Split('|');
            if (items.Length > 12)
            {
                try
                {
                    tax_id = Convert.ToInt32(items[0].Trim());
                    parent_tax_id = Convert.ToInt32(items[1].Trim());
                    rank = items[2].Trim();
                    embl_code = items[3].Trim();
                    division_id = Convert.ToByte(items[4].Trim());
                    inherited_div_flag = Convert.ToByte(items[5].Trim());
                    genetic_code_id = Convert.ToByte(items[6].Trim());
                    inherited_GC_flag = Convert.ToByte(items[7].Trim());
                    mitochondrial_code_id = Convert.ToByte(items[8].Trim());
                    inherited_MGC_flag = Convert.ToByte(items[9].Trim());
                    genBank_hidden_flag = Convert.ToByte(items[10].Trim());
                    hidden_subtree_root_flag = Convert.ToByte(items[11].Trim());
                    isGood = true;                    
                }
                catch { isGood = false; }
            }
        }

        public string getString()
        {
            string answer = "";
            if (parent != null)
            { answer = parent.getString() ; }
            
            if (rank.Equals("no rank") == false)
            {
                answer += "\t" + getName();            
            }
            return answer;
        }

        public void setParentNode(node Parent)
        {
            if (Parent.getTax_ID == parent_tax_id)
            { parent = Parent; }
            else
            { throw new Exception("hum"); }
        }

        public void setNames(leaf data)
        {
            
            if (data.getTax_ID == tax_id)
            {
                setNameDegenerate(data);
            }
            else
            { throw new Exception("hum"); }
        }

        private string getName()
        {
            if (string.IsNullOrEmpty(scienceName) == false)
            { return scienceName; }
            else if (string.IsNullOrEmpty(equivalent_name) == false)
            { return equivalent_name; }
            else if (string.IsNullOrEmpty(genbank_common_name) == false)
            { return genbank_common_name; }
            else if (string.IsNullOrEmpty(Synonym) == false)
            { return Synonym; }
            else if (string.IsNullOrEmpty(Genbank_synonym) == false)
            { return Genbank_synonym; }
            else if (string.IsNullOrEmpty(Acronym) == false)
            { return Acronym; }
            else if (string.IsNullOrEmpty(Genbank_acronym) == false)
            { return Genbank_acronym; }
            else if (string.IsNullOrEmpty(anamorph) == false || string.IsNullOrEmpty(teleomorph) == false)
            { return anamorph + ":" + teleomorph; }
            else if (string.IsNullOrEmpty(Genbank_anamorph) == false)
            { return Genbank_anamorph; }
            else { return "_"; }
        }

        private void setNameDegenerate(leaf l)
        {
            switch (l.getOtherNames)
            {
                case "scientific name":
                    scienceName = l.getName + " (" + rank +")";//
                    break;
                case "synonym":
                    Synonym = l.getName + " (" + rank + ")";//
                    break;
                case "acronym":
                    Acronym = l.getName + " (" + rank + ")";//
                    break;
                case "anamorph":
                    anamorph = l.getName + " (" + rank + ")";//
                    break;
                case "teleomorph":
                    teleomorph = l.getName + " (" + rank + ")";//
                    break;
                case "misspelling":
                    //misspelling = l.getName;
                    break;
                case "misnomer":
                    //misnomer = l.getName;
                    break;
                case "equivalent name":
                    equivalent_name = l.getName + " (" + rank + ")";//
                    break;
                case "includes":
                    //Includes = l.getName;
                    break;
                case "in-part":
                    //in_part = l.getName;
                    break;
                case "blast name":
                    //blast_name = l.getName;
                    break;
                case "common name":
                    //Common_name = l.getName;
                    break;
                case "genbank common name":
                    genbank_common_name = l.getName + " (" + rank + ")";//
                    break;
                case "genbank synonym":
                    Genbank_synonym = l.getName + " (" + rank + ")";//
                    break;
                case "genbank acronym":
                    Genbank_acronym = l.getName + " (" + rank + ")";//
                    break;
                case "genbank_anamorph":
                    Genbank_anamorph = l.getName + " (" + rank + ")";//
                    break;
                case "unpublished name":
                    //unpublished_name = l.getName;
                    break;
                case "authority":
                    //Authority = l.getName;
                    break;
                case "type material":
                    break;
                default:
                    genbank_common_name = "";
                    break;
            }
        }

        public bool HasBeenAdd 
        { set { hasBeenAdded = value; } 
        get{ return hasBeenAdded;} }

        public bool getIsGood { get { return isGood; } }
        public int getTax_ID { get { return tax_id; } }
        public int getParent_Tax_ID { get { return parent_tax_id; } }
        public string getRank { get { return rank; } }
        public string getEMBL_Code { get { return embl_code; } }
        public byte getDivision { get { return division_id; } }
        public byte getInherited_div_ID { get { return inherited_div_flag; } }
        public byte getGenetic_Code_ID { get { return genetic_code_id; } }
        public byte getInherited_GC_flag { get { return inherited_GC_flag; } }
        public byte getMitochondrial_Code_ID { get { return mitochondrial_code_id; } }
        public byte getInherited_MGC_flag { get { return inherited_MGC_flag; } }
        public byte getGenBank_hidden_flag { get { return genBank_hidden_flag; } }
        public byte getHidden_Subtree_Root_Flag { get { return hidden_subtree_root_flag; } }

        public string Serialise()
        {
            string answer = tax_id.ToString() + "\t" + parent_tax_id.ToString() + "\t" + rank + "\t" + embl_code + "\t" +
        division_id.ToString() + "\t" + inherited_div_flag.ToString() + "\t" + genetic_code_id.ToString() + "\t" +
         mitochondrial_code_id.ToString() + "\t" + inherited_MGC_flag.ToString() + "\t" + genBank_hidden_flag.ToString() + "\t" +
         hidden_subtree_root_flag.ToString() + "\t" + isGood.ToString() + "\t" +hasBeenAdded.ToString() + "\t" +
          scienceName + "\t" + ScientificName + "\t" + Synonym + "\t" + Acronym + "\t" + anamorph + "\t" + teleomorph + "\t" +
          equivalent_name + "\t" + genbank_common_name + "\t" + Genbank_synonym + "\t" + Genbank_acronym + "\t" +
          Genbank_anamorph;

            return answer;
        }

        public node(string serialisedData, bool isSerialisedData)
        {
            string[] items = serialisedData.Split('\t');
            tax_id = Convert.ToInt32(items[0]);
            parent_tax_id = Convert.ToInt32(items[1]);
            rank = items[2];
            embl_code = items[3];
            division_id = Convert.ToByte(items[4]);
            inherited_div_flag = Convert.ToByte(items[5]);
            genetic_code_id = Convert.ToByte(items[6]);
            mitochondrial_code_id = Convert.ToByte(items[7]);
            inherited_MGC_flag = Convert.ToByte(items[8]);
            genBank_hidden_flag = Convert.ToByte(items[9]);
            hidden_subtree_root_flag = Convert.ToByte(items[10]);
            isGood = Convert.ToBoolean(items[11]);
            hasBeenAdded = Convert.ToBoolean(items[12]);
            scienceName = items[13];
            ScientificName = items[14];
            Synonym = items[15];
            Acronym = items[16];
            anamorph = items[17];
            teleomorph = items[18];
            equivalent_name = items[19];
            genbank_common_name = items[20];
            Genbank_synonym = items[21];
            Genbank_acronym = items[22];
            Genbank_anamorph = items[23];
        }
    }
}
