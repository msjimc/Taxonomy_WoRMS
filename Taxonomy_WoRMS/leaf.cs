using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxonomy_WoRMS
{
    class leaf
    {
        private int tax_ID = -1;
        private string name = "";
        private string nameLower = "";
        private bool isGood = false;

        public leaf(string[] items)
        {
            try
            {
                int index = items[0].LastIndexOf(':') + 1;
                if (index > 0)
                {
                    string id = items[0].Substring(index);
                    try
                    {
                        tax_ID = Convert.ToInt32(id);
                        name = items[1];
                        nameLower = name.ToLower();
                        isGood = true;
                    }
                    catch { isGood = false; }
                }              
            }
            catch{ isGood = false; }
        }

        public leaf(int tax_ID, string name)
        {
            this.tax_ID = tax_ID;
            this.name = name;
            this.nameLower = name.ToLower();
            this.isGood = true;
        }

        public int getTax_ID { get { return tax_ID; } }
        public string getName { get { return name; } }
        public string getNameLowerCase { get { return nameLower; } }       
        public bool getIsGood { get { return isGood; } }
                
    }
}
