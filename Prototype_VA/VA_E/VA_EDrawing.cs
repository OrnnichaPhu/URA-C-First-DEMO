using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_VA.VA_E
{
    internal class VA_EDrawing : AnswerValidate
    {
        private static int currentSubTrial = 0;
        private static int currentLine;

        RectangleF E_frame;

        private static int subTrial = 0;

        private RectangleF gen_black_part()
        {
            SizeF E_size = 5 * GetSizeF();
            RectangleF E_frame = new RectangleF(points[0, 0], E_size);
            return E_frame;
        }

        RectangleF[] White_parts = new RectangleF[2];
        private RectangleF[] gen_white_part(int id)
    
        {
            switch (id)
            {
                case 1:
                    SizeF White_parts_size1 = new SizeF(sizeF.Width, 4 * sizeF.Height);
                    White_parts[0] = new RectangleF(points[1, 0].X, points[1, 0].Y-1, White_parts_size1.Width, White_parts_size1.Height + 1);
                    White_parts[1] = new RectangleF(points[3, 0].X, points[3, 0].Y-1, White_parts_size1.Width, White_parts_size1.Height + 1);
                    return White_parts;
                case 2:
                    SizeF White_parts_size2 = new SizeF(sizeF.Width, 4 * sizeF.Height + 2);
                    White_parts[0] = new RectangleF(points[1, 1], White_parts_size2);
                    White_parts[1] = new RectangleF(points[3, 1], White_parts_size2);
                    return White_parts;
                case 3:
                    SizeF White_parts_size3 = new SizeF(4 * sizeF.Height + 2, sizeF.Width);
                    White_parts[0] = new RectangleF(points[1, 1], White_parts_size3);
                    White_parts[1] = new RectangleF(points[1, 3], White_parts_size3);
                    return White_parts;
                case 4:
                    SizeF White_parts_size4 = new SizeF(4 * sizeF.Height, sizeF.Width);
                    //fix the error point and compensate it back at width length
                    White_parts[0] = new RectangleF(points[0, 1].X - 1, points[0, 1].Y, White_parts_size4.Width + 1, White_parts_size4.Height);
                    White_parts[1] = new RectangleF(points[0, 3].X - 1, points[0, 3].Y, White_parts_size4.Width + 1, White_parts_size4.Height);
                    return White_parts;
            }
            return White_parts;
        }

        public void CreatePatternScale()
        {
            OneUnit();
            GeneratePoint();
            generatePatternID();

            NewLineReceiveAns();
            //System.Diagnostics.Debug.WriteLine("CreatePatternScale is called");

        }

        public void UpdatePattern()
        {
            /*
            System.Diagnostics.Debug.WriteLine("current Trial = {0}", GetTrial());
            System.Diagnostics.Debug.WriteLine("current subTrial = {0}", subTrial);
            */

            if (subTrial < GetTrial())
            {
                subTrial++;
                CheckStatetrial();
            }
            else
            {
                subTrial = 0;
                ChangeLineResult();
                CheckStatetrial();
                CreatePatternScale();
            }
            
            /*
            System.Diagnostics.Debug.WriteLine("Next Trial = {0}", GetTrial());
            System.Diagnostics.Debug.WriteLine("Next subTrial = {0}", subTrial);
            */
        }

        //Need to rewrite
        public void ResetPattern()
        {
            subTrial = 0;
            OneUnit();
            GeneratePoint();
            generatePatternID();
        }

        Brush whhite_brush = new SolidBrush(SystemColors.Control);
        Brush black_brush = new SolidBrush(Color.Black);

        public void fillcolor(Graphics g)
        {

            //g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            E_frame = gen_black_part();
            White_parts = gen_white_part(linePatterns[GetTrial()].LineResults[subTrial].ID);

            SetCorrectAns(linePatterns[GetTrial()].LineResults[subTrial].ID);

            g.FillRectangle(black_brush, E_frame);
            g.FillRectangles(whhite_brush, White_parts);

        }


        public void setSubTrial(int newSubtrial)
        {
            subTrial = newSubtrial;
        }

        public int getSubTrial()
        {
            return subTrial;
        }



    }
}
