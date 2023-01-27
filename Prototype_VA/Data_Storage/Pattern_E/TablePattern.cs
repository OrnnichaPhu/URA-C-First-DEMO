using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_VA.Data_Storage.Pattern_E
{
    internal class TablePattern
    {
        public int size { get; set; }

        public LinePattern[] LinePattern;

        public TablePattern(int size, LinePattern[] linePattern)
        {
            this.size = size;
            LinePattern = linePattern;
        }

        public void CreateTableResult()
        {
            LinePattern[] tablePatterns = new LinePattern[size];
            for (int i = 0; i < size; i++)
            {
                tablePatterns[i] = new LinePattern(LinePattern[i].size, LinePattern[i].ArrayFirstDigit, LinePattern[i].ArraySecondDigit);
            }
        }
    }
}
