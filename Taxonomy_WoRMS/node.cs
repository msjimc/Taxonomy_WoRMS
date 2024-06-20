using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Taxonomy_WoRMS
{
    class node
    {
        private int tax_id = -1;
        private string taxonomyLine;
        private string name;
        private string usedName;
        private string extendedName;
        private string rank = "";
        private bool isGood = false;

        public node(int ID, string Taxonomy, string latinName, string ExtendedLatinName,string UsedName, string Rank)
        {
            taxonomyLine = Taxonomy;
            tax_id = ID;
            name = latinName;
            extendedName = ExtendedLatinName;
            usedName= UsedName;
            rank = Rank;           

            isGood = true;  
        }

        public string getString()
        {            
            return taxonomyLine;
        }              

        public string getName()
        {
            return name;
        }               
       
        public leaf[] getLeafs()
        {          
            List<leaf> result = new List<leaf>();
            if (string.IsNullOrEmpty(name.Trim()) == false)
            { result.Add(new leaf(tax_id, name)); }
            if (usedName.Equals(name) == false)
            { result.Add(new leaf(tax_id, usedName)); }
            if (string.IsNullOrEmpty(extendedName) == false && extendedName.Equals(usedName) ==false)
            { result.Add(new leaf(tax_id, extendedName)); }
                        
            return result.ToArray();
        }

        public bool getIsGood { get { return isGood; } }
        public int getTax_ID { get { return tax_id; } }
        public string getRank { get { return rank; } }
               
    }
}
