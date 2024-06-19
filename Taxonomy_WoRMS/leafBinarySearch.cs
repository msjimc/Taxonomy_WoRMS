using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxonomy_WoRMS
{
    class leafBinarySearch : IComparer
    {
        public int Compare(object x, object y)
        {
            leaf a = (leaf)x;
            string b = (string)y;
            return a.getNameLowerCase.CompareTo(b);
        }
    }
}
