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
        private string unique_Name = "";
        private string otherNames = "";
        private bool isGood = false;

        public leaf(string[] items)
        {
            try
            {
                tax_ID = Convert.ToInt32(items[0].Trim());
                name = items[1].Trim();
                nameLower = name.ToLower();
                unique_Name = items[2].Trim();
                otherNames = items[3].Trim();
                isGood = true;
            }
            catch{ isGood = false; }

        }

        public int getTax_ID { get { return tax_ID; } }
        public string getName { get { return name; } }
        public string getNameLowerCase { get { return nameLower; } }
        public string getUnique_Name { get { return unique_Name; } }
        public string getOtherNames { get { return otherNames; } }
        public bool getIsGood { get { return isGood; } }

        public string Serialise()
        {
            string answer = tax_ID.ToString() + "\t" + name + "\t" + nameLower + "\t" + unique_Name + "\t" + otherNames + "\t" + isGood.ToString();
            return answer;
        }

        public leaf(string serialData)
        {
            string[] items = serialData.Split('\t');
            tax_ID = Convert.ToInt32(items[0]);
            name = items[1];
            nameLower = items[2];
            unique_Name = items[3];
            otherNames = items[4];
            isGood = Convert.ToBoolean(items[5]);
        }
    }
}
