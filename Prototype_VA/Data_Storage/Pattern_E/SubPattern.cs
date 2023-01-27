using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_VA.Data_Storage.Pattern_E
{
    public class SubPattern
    {
        public int FirstDigit { get; set; }
        public int SecondDigit { get; set; }
        public int ID { get; set; } 

        public SubPattern()
        {

        }

        public SubPattern(int firstDigit, int secondDigit)
        {
            FirstDigit = firstDigit;
            SecondDigit = secondDigit;
            // call Set ID
            ID = SetID();
        }
        public enum Direction : int
        {
            Up = 1, Down = 2, Right = 3, Left = 4
        }
       
        private int SetID()
        {
            //Implement
            if (FirstDigit == 0 && SecondDigit == 0)
                return (int)Direction.Up;

            if (FirstDigit == 0 && SecondDigit == 1)
                return (int)Direction.Down;

            if (FirstDigit == 1 && SecondDigit == 0)
                return (int)Direction.Left;

            if (FirstDigit == 1 && SecondDigit == 1)
                return (int)Direction.Right;
            return ID;
        }
    }

    public class SubPatts : IEnumerable
    {
        private SubPattern[] _SubPatts;

        public SubPatts(SubPattern[] sArray)
        {
            _SubPatts = new SubPattern[sArray.Length];
            for (int i = 0; i < sArray.Length; i++)
            {
                _SubPatts[i] = sArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public SubPattEnum GetEnumerator()
        {
            return new SubPattEnum(_SubPatts);
        }
    }

    public class SubPattEnum : IEnumerator
    {
        public SubPattern[] _SubPatts;
        int position = -1;

        public SubPattEnum(SubPattern[] list)
        {
            _SubPatts = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _SubPatts.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public SubPattern Current
        {
            get
            {
                try
                {
                    return _SubPatts[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
