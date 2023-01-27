using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype_VA.SystemAlgorithm;
using Prototype_VA.Data_Storage.Pattern_E;
using Prototype_VA.Data_Storage.Answer;

namespace Prototype_VA.VA_E
{
    internal class AnswerValidate : PatternGenerate
    {
        int NumberFalseAns = 0;
        private int NumberAns = 0;
        static int CorrectAns = 0;

        private byte[] Recieveresults = new byte[1];
        public static int[] Results = new int[8];



        static int ResponseAnswer = 0;


        public void ansValidate()
        {
            int Currentstate = this.GetTrial();

            if (Currentstate == 0)
            {
                AnswerCheck(Currentstate);

                if (NumberFalseAns == 1)
                {
                    //displayResult();
                    //MessageBox.Show("Score out of 36 =" + GetSum());
                    EndTrial = true;
                    System.Diagnostics.Debug.WriteLine("EndTrial");
                    return;
                }
                return;
            }

            else if (Currentstate == 1)
            {
                AnswerCheck(Currentstate);

                if (NumberFalseAns == 2)
                {
                    //displayResult();
                    //MessageBox.Show("Score out of 36 =" + GetSum());
                    EndTrial = true;
                    System.Diagnostics.Debug.WriteLine("EndTrial");
                    return;
                }
                return;
            }

            else if (Currentstate <= 7)
            {
                AnswerCheck(Currentstate);

                if (NumberFalseAns == 3)
                {
                    //displayResult();
                    //MessageBox.Show("Score out of 36 =" + GetSum());
                    EndTrial = true;
                    System.Diagnostics.Debug.WriteLine("EndTrial");
                    return;
                }
                return;
            }
        }

        private void AnswerCheck(int Currentstate)
        {
            ResponseAnswer = DecodeSignal();
            addArray(ResponseAnswer);
            if (ResponseAnswer == CorrectAns)
            {
                Results[Currentstate] += 1;
                return;
            }
            NumberFalseAns++;
        }

        private int DecodeSignal()
        {

            if (Recieveresults[0] == 1)
            {
                int i = 1;
                System.Diagnostics.Debug.WriteLine("RespondAns = {0}", (Direction)i);
                return i;
            }

            if (Recieveresults[0] == 2)
            {
                int i = 2;
                System.Diagnostics.Debug.WriteLine("RespondAns = {0}", (Direction)i);
                return i;
            }
            if (Recieveresults[0] == 3)
            {
                int i = 3;
                System.Diagnostics.Debug.WriteLine("RespondAns = {0}", (Direction)i);
                return i;
            }
            if (Recieveresults[0] == 4)
            {
                int i = 4;
                System.Diagnostics.Debug.WriteLine("RespondAns = {0}", (Direction)i);
                return i;
            }
            return 0;
        }

        public void ResetFalseAnsNumber()
        {
            NumberFalseAns = 0;
        }
        public void SetCorrectAns(int i)
        {
            CorrectAns = i;
        }

        public void SetAnser(byte[] ans)
        {
            Recieveresults[0] = ans[0];
        }

        private void ResetVar()
        {
            ResponseAnswer = 0;
        }

        public void ResetResult()
        {
            int[] temp = new int[8];
            Results = temp;
        }


        // stored part

        private static int[] CorrectAns_;
        public void GetLineAnswer()
        {
            int currentline = GetTrial();
            CorrectAns_ = new int[currentline + 1];
            for (int i = 0; i < currentline + 1; i++)
            {
                CorrectAns_[i] = linePatterns[currentline].LineResults[i].ID;

                System.Diagnostics.Debug.WriteLine("line {0} subtrial {1} the correct answer is {2} at ID = {3}", currentline+1, i, (SubPattern.Direction)CorrectAns_[i], CorrectAns_[i]);
            }
        }

        private int[] ReceiveAns_;

        public void NewLineReceiveAns()
        {
            ReceiveAns_ = new int[GetTrial() + 1];
        }

        int current = 0;
        private void addArray(int R_ans)
        {
            if (current < ReceiveAns_.Length)
            {
                ReceiveAns_[current] = R_ans;
                current++;
            }
        }

        private void addEmptyCurrentArray()
        {
            if (current < ReceiveAns_.Length)
            {
                for(int i = current; i < ReceiveAns_.Length; i++)
                ReceiveAns_[current] = 0;
            }
            ChangeLineResult();
        }


        private int currentline;

        LineResults[] results = new LineResults[8];

        protected void insertLineResult(int size, int[] CAns, int[] Rans)
        {
            if (currentline < 8)
                results[currentline] = new LineResults(size, CAns, Rans);
        }

        public void ChangeLineResult()
        {
            currentline = GetTrial();
            GetLineAnswer();
            insertLineResult(currentline + 1, CorrectAns_, ReceiveAns_);
            current = 0;
        }

        public static int sum;
        public void displayResult()
        {
            addEmptyCurrentArray();
            
            for (int i = 0; i < 8; i++)
            {
                if (results[i] != null)
                {
                    System.Diagnostics.Debug.WriteLine("Score at line {0} = {1}.", i+1, results[i].score);
                    sum += results[i].score;
                }
            }
        }
        
        public int GetSum() { return sum; }

        TestResult[] TestResult = new TestResult[2];
        private int currentTest;

        protected void insertTestResult(LineResults[] results)
        {
            if (IsLeftTest && IsRightTest)
                currentTest = 1;
            else
                currentTest = 0;
            if (currentTest < 2)
                TestResult[currentTest] = new TestResult(results);
        }

        public void ChangeTestline()
        {            
            insertTestResult(results);
        }
    }
}
