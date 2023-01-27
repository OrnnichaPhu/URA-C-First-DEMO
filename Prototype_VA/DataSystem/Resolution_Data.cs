using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_VA.DataSystem
{
    internal class Resolution_Data
    {
        public static double dpi = 141;

        protected static int ResolutionX;
        protected static int ResolutionY;
        protected static double Physical_size = 15.6;

        private int GetResolutionX()
        {
            ResolutionX = Screen.PrimaryScreen.Bounds.Width;
            return ResolutionX;
        }
        private int GetResolutionY()
        {
            ResolutionY = Screen.PrimaryScreen.Bounds.Height;
            return ResolutionY;
        }

        public double GetPhysical_Size() { return Physical_size; }

        private void SetPhysical_Size(double NewDiagonal) { Physical_size = NewDiagonal; }


        public void SetResolution()
        {
            GetResolutionX();
            GetResolutionY();
        }

        //Get&Set DPI
        private void SetDpi(double newDpi)
        {
            dpi = newDpi;
        }
        public double getDpi()
        {
            return dpi;
        }
    }
}
