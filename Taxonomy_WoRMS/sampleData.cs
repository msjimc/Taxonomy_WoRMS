using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxonomy_WoRMS
{
    internal class sampleData
    {
        private int index;
        private List<string> data;

        public sampleData(int Index, string dataPoint)
        {
            this.index = Index;
            data = new List<string>();
            data.Add(dataPoint);
        }

        public void AddDataPoint(string item)
        { data.Add(item); }
    }
}
