using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_VA.DataSystem
{
    internal class Math_Calculation:Resolution_Data
    {
        public double ArcTan()
        {
            double arc = 5;
            arc = arc / 60;
            arc = Math.Tan(arc * (Math.PI / 180));
            return arc;
        }

        public double CentimeterToPixel(double pixel)
        {
            return ((pixel * dpi) / 2.54);
        }

        public double dpi_calculator()
        {
            double newDpi;
            double DiagonalPixels = Math.Sqrt((ResolutionX * ResolutionX) + (ResolutionY * ResolutionY));
            newDpi = DiagonalPixels / Physical_size;
            return newDpi;
        }

        private int RandomInt()// pseudo random
        {
            Random rnd = new Random();
            return rnd.Next(10, 100);
        }

        public int getRndID()
        {
            return RandomInt();
        }
    }
}
