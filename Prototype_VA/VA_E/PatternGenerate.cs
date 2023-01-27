using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype_VA.DataSystem;
using Prototype_VA.Data_Storage.Pattern_E;
using Prototype_VA.SystemAlgorithm;

namespace Prototype_VA.VA_E
{
    internal class PatternGenerate : LineTrialGenerator
    {
        public static LinePattern[] linePatterns = new LinePattern[8];
        private static int currentline = 0;
 


        public PatternGenerate()
        {
           // generatePatternID();
        }

        protected int getRandNum()
        {
            int randnum = getRndID();

            System.Diagnostics.Debug.WriteLine("random number = {0}", randnum);

            return randnum;
        }

        protected int binarizeDigit(int digit)
        {
            System.Diagnostics.Debug.WriteLine("digit number = {0}", digit);

            if (digit % 2 == 0)
                return 0;
            else return 1;
        }

        protected int[] digitSeperation()
        {
            int temp = getRandNum();
            int fst = binarizeDigit((int)temp/10);
            int snd = binarizeDigit((int)temp%10);
            int[] digits = {fst, snd};
          
            System.Diagnostics.Debug.WriteLine("1st digit = {0}", fst);
            System.Diagnostics.Debug.WriteLine("2nd digit = {0}", snd);
        
            return digits;
        }

        int[] fst;
        int[] snd;


        private void storeArray(int[] array,int index,int n)
        {
            array[index] = n;
        }

        private int[] checkPattern(int[] patt, int currentIndex)
        {
            int[] temp = patt;
            int FirstparrentIndex;
            int SecondparentIndex;

            if(currentIndex == 0)
                return temp;

            SecondparentIndex = currentIndex-1;

            if(currentIndex == 1)
            {
                if(temp[0] == fst[SecondparentIndex])
                {
                    if (snd[SecondparentIndex] == 1)
                        temp[1] = 0;
                    else temp[1] = 1;
                }
            }

            else if(currentIndex > 1)
            {
                FirstparrentIndex = currentIndex - 2;
                if(fst[FirstparrentIndex] != fst[SecondparentIndex])
                {
                    //check opposite
                    if (temp[0] == fst[SecondparentIndex])
                        temp[0] = fst[FirstparrentIndex];

                    //check facing direction
                    if (temp[1] == snd[FirstparrentIndex])
                    {
                        if (snd[FirstparrentIndex] == 1)
                            temp[1] = 0;
                        else temp[1] = 1;
                    }
                }
                else
                {
                    if(temp[0] == fst[SecondparentIndex])
                    {
                        if (fst[SecondparentIndex] == 1)
                            temp[0] = 0;
                        else temp[0] = 1;
                    }
                }
            }

            return temp;
        }


        public void generatePatternID()
        {
            int line = GetTrial()+1;

            System.Diagnostics.Debug.WriteLine("At line = {0}",line);

            generateLineArray(line);
            for(int i =0 ; i < line; i++)
            {
                int[] newPatt = digitSeperation();
                checkPattern(newPatt, i);                 // check duplicate
                storeArray(fst, i, newPatt[0]);
                storeArray(snd, i, newPatt[1]);

                System.Diagnostics.Debug.WriteLine("At index {0} , 1st = {1}, 2nd = {2} ", i, newPatt[0], newPatt[1]);
            }
            ChangeLine();
        }


        //Storage
        protected void generateLineArray(int size)
        {
            fst = new int[size];
            snd = new int[size];  
        }

        protected void insertLinePattern(int size, int[] fst, int[] snd)
        {
            if(currentline < 8)
                linePatterns[currentline] = new LinePattern(size, fst, snd);
        }

        private void ChangeLine()
        {
            currentline = GetTrial();
            insertLinePattern(currentline + 1, fst, snd);
        }

        //ID of Pattern
        public enum Direction : int
        {
            Up = 1, Down = 2, Right = 3, Left = 4
        }

        //1 st and 2 nd digits tranform into direction
        public static int GetIDpattern(int fst, int snd)
        {
            if (fst == 0 && snd == 0)
                return (int)Direction.Up;

            if (fst == 0 && snd == 1)
                return (int)Direction.Down;

            if (fst == 1 && snd == 0)
                return (int)Direction.Left;

            if (fst == 1 && snd == 1)
                return (int)Direction.Right;

            return 0;
        }


        private void Reset()
        {
            linePatterns = null;
            currentline = 0;
        }
       

    }
}
