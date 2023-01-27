using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_VA.DataSystem
{
    internal class TestData : DataSystem
    {
        private static double TestDistance = 6.0;
        private static double Cof;

        private static double[] newDistance;


        private double[] ChangeDistance()
        {
            /*
             * temp Mysteriously take data from newDistance Array while it suppose to get data from OptDistances in DataSystem class using method Get_OptDistances
            double[] temp = Get_OptDistances();
            */
            double[] temp = { 60, 48, 38, 30, 24, 19, 15, 12, 9.5, 7.5, 6 };
            if (TestDistance != 6.0)
            {
                Cof = (TestDistance / 6.0);
                for (int i = 0; i < temp.Length; i++)
                {
                    //Recheck Original distance
                    //System.Diagnostics.Debug.WriteLine("Original distance = {0} m.",temp[i]);
                    temp[i] = temp[i] * Cof;
                    //return for checking
                    System.Diagnostics.Debug.WriteLine("At line {0} = {1} m.", i, temp[i]);
                }
            }
            else
            {
                temp = null;
            }
            return temp;
        }

        //Get&Set for distance value
        public void SetTestDistance(double newDis) { 
            TestDistance = newDis;
            setnewDistance();
        }

        public double GetTestDistance() { return TestDistance; }

        private void setnewDistance()
        {
            newDistance = new double[Get_OptDistancesLength()];
            newDistance = ChangeDistance();
        }
        public new double GetOptD(int index)
        {
            if(newDistance != null)
            {
                return newDistance[index];
            }
            return base.GetOptD(index);
        }


        public bool IsNewDistance()
        {
            if (newDistance != null)
            {
                return true;
            }
            return false;
        }
    }
}
