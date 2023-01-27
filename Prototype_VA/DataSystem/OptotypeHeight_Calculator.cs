using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_VA.DataSystem
{
    internal class OptotypeHeight_Calculator : TestData
    {
        private double distance;
        private double Hopt;

        private PointF Origin;

        double unit;


        double initialX;
        double initialY;

        public static int trial = 0;

        public static PointF[,] points = new PointF[5, 5];

        public static SizeF sizeF = new SizeF();

        double[] XPosition = new double[5];
        double[] YPosition = new double[5];


        double HoptotypeCalculate(int i)
        {
            distance = GetOptD(i) * 100;
            //System.Diagnostics.Debug.WriteLine("OptD = {0}", GetOptD(i));
            Hopt = CentimeterToPixel(distance * ArcTan());
            return Hopt;
        }

        void SetInitial()
        {
            Origin = SetOrigin();
            //System.Diagnostics.Debug.WriteLine("Origin = ({0},{1})", Origin.X, Origin.Y);
            initialX = Origin.X - ((unit * 5) / 2);
            //System.Diagnostics.Debug.WriteLine("initX = {0}", initialX);
            initialY = Origin.Y - ((unit * 5) / 2);
            //System.Diagnostics.Debug.WriteLine("initY = {0}", initialY);
        }

        public void OneUnit()
        {
            unit = HoptotypeCalculate(trial) / 5;
            //System.Diagnostics.Debug.WriteLine("unit = {0}", unit);

            sizeF.Width = (float)unit;
            sizeF.Height = (float)unit;

        }

        private void PerOneUnit()
        {
            SetInitial();

            XPosition[0] = initialX;
            YPosition[0] = initialY;

            for (int i = 1; i < 5; i++)
            {
                XPosition[i] = XPosition[i - 1] + unit;
                //System.Diagnostics.Debug.WriteLine("x{1}= {0}", XPosition[i],i);
                YPosition[i] = YPosition[i - 1] + unit;
                //System.Diagnostics.Debug.WriteLine("Y{1} = {0}", YPosition[i],i);
            }

        }

        public void GeneratePoint()
        {
            points = new PointF[5, 5];
            PerOneUnit();
            double X, Y;
            for (int i = 0; i < 5; i++)
            {
                Y = YPosition[i];

                for (int j = 0; j < 5; j++)
                {
                    X = XPosition[j];

                    points[j, i].X = (float)X;
                    points[j, i].Y = (float)Y;

                    /*
                    System.Diagnostics.Debug.WriteLine("--------------------------------------------------------------------------------");
                    System.Diagnostics.Debug.WriteLine("pointsY[{0}][{1}] = {2}", j, i, points[j, i].Y);
                    System.Diagnostics.Debug.WriteLine("pointsX[{0}][{1}] = {2}", j, i, points[j, i].X);
                    System.Diagnostics.Debug.WriteLine("--------------------------------------------------------------------------------");
                    */
                }

            }
        }


        public double GetHopt()
        {
            return Hopt;
        }

        public double GetOneUnit()
        {
            return unit;
        }

        public SizeF GetSizeF()
        {
            //sizeF = new SizeF((float)unit, (float)unit);
            return sizeF;
        }

        public PointF[,] GetPointfs()
        {
            //System.Diagnostics.Debug.WriteLine("GetPoint is Called");
            /*
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    System.Diagnostics.Debug.WriteLine("pointsY[{0}][{1}] = {2}", j, i, points[j, i].Y);
                    System.Diagnostics.Debug.WriteLine("pointsX[{0}][{1}] = {2}", j, i, points[j, i].X);
                }
            }
            System.Diagnostics.Debug.WriteLine("--------------------------------------------------------------------------------");
            */
            return points;
        }

        public int GetTrial()
        {
            return trial;
        }

        public void SetTrial(int n)
        {
            trial = n;
        }

        public void ResetTrial()
        {
            trial = 0;
        }
    }
}
