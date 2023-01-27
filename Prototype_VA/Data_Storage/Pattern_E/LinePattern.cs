 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_VA.Data_Storage.Pattern_E
{
    internal class LinePattern
    {
        public int size { get; set; }

        public int[] ArrayFirstDigit;
        public int[] ArraySecondDigit;
        public SubPattern[] LineResults;


        public LinePattern()
        {

        }

        public LinePattern(int size, int[] arrayFirstDigit, int[] arraySecondDigit)
        {
            this.size = size;
            ArrayFirstDigit = arrayFirstDigit;
            ArraySecondDigit = arraySecondDigit;
            CreateLineResult();
            
        }


        public void CreateLineResult()
        {
            //SubPattern[] LineResults = new SubPattern[size];

            LineResults = new SubPattern[size];
            for (int i = 0; i < size; i++)
            {
                LineResults[i] = new SubPattern(ArrayFirstDigit[i], ArraySecondDigit[i]);
            }
        }
        
    }
}
