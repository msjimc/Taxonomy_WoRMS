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
        private string commonName;
        private string rank = "";
        private bool isGood = false;

        public node(int ID, string Taxonomy, string latinName, string Rank)
        {
            taxonomyLine = Taxonomy;
            tax_id = ID;
            name = latinName;
            rank = Rank;           

            isGood = true;  
        }

        public string getString()
        {            
            return taxonomyLine;
        }        

        public void setNames(leaf data)
        {
            
            if (data.getTax_ID == tax_id)
            {
                commonName = data.getName;
            }
            else
            { throw new Exception("hum"); }
        }

        public string getName()
        {
            return name;
        }               
       
        public leaf getLeaf()
        {
            leaf l = new leaf(tax_id, name);
            return l;
        }

        public bool getIsGood { get { return isGood; } }
        public int getTax_ID { get { return tax_id; } }
        public string getRank { get { return rank; } }
               
    }
}
