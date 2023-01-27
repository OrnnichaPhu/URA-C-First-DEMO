using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_VA.DataSystem
{
    internal class DataSystem : Math_Calculation
    {
        readonly double[] OptDistances = { 60, 48, 38, 30, 24, 19, 15, 12, 9.5, 7.5, 6 };
       

        private static int LineTrial = 0;

        double OriginX;
        double OriginY;

        public PointF SetOrigin()
        {
            SetResolution();
            OriginX = ResolutionX / 2;
            OriginY = ResolutionY / 2;

            return new PointF((float)OriginX, (float)OriginY);
        }

        public double GetOptD(int index)
        {
            return OptDistances[index];
        }

        public double[] Get_OptDistances()
        {
            return OptDistances;
        }

        public int Get_OptDistancesLength()
        {
            return OptDistances.Length;
        }

        public new int getRndID()
        {
            return base.getRndID();
        }
    }
}
