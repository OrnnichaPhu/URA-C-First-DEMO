using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_VA.Data_Storage.Answer
{
    public class ResultsList
    {
        public int correctAnswer { get; set; }
        public int inputAnswer { get; set; }
        public bool IsCorrect { get; set; }

        public ResultsList()
        {

        }

        public ResultsList(int correctAnswer, int inputAnswer)
        {
            this.correctAnswer = correctAnswer;
            this.inputAnswer = inputAnswer;
            IsCorrect = AnsChecking();
        }

        private bool AnsChecking()
        {
            return correctAnswer == inputAnswer;
        }
    }

    public class LineResults : ResultsList
    {
        public int size { get; set; }
        public int[] ArraycorrectAnswer { get; set; }
        public int[] ArrayinputAnswer { get; set; }
        public ResultsList[] Results { get; set; }

        public int score { get; set; }  

        public LineResults()
        {

        }

        public LineResults(int size, int[] arraycorrectAnswer, int[] arrayinputAnswer)
        {
            this.size = size;
            ArraycorrectAnswer = arraycorrectAnswer;
            ArrayinputAnswer = arrayinputAnswer;
            CreateLineResult();
            sumScore();
        }

        public LineResults(ResultsList[] results)
        {
            Results = results;
            size = results.Length;
            CreateArrayofCorrectAns();
            CreateArrayofinputAns();

        }

        private void CreateArrayofCorrectAns()
        {
            for(int i = 0; i < size; i++)
            {
                ArraycorrectAnswer[i] = Results[i].correctAnswer;
            }
        }

        private void CreateArrayofinputAns()
        {
            for (int i = 0; i < size; i++)
            {
                ArrayinputAnswer[i] = Results[i].inputAnswer;
            }
        }

        public void CreateLineResult()
        {
            Results = new ResultsList[size];
            for (int i = 0; i < size; i++)
            {
                Results[i] = new ResultsList(ArraycorrectAnswer[i], ArrayinputAnswer[i]);
            }
        }

        private void sumScore()
        {
            for (int i = 0; i < size; i++)
            {
                if (Results[i].IsCorrect)
                    score++;
            }
        }
    }

    public class TestResult : LineResults
    {
        public int size { get; set; }
        public LineResults[] TResults_ { get; set; }
        public int testScore { get; set; }

        public TestResult()
        {

        }

        public TestResult(int size, LineResults[] tResults_)
        {
            this.size = size;
            TResults_ = tResults_;
            //SumTestResult();
        }

        public TestResult(LineResults[] tResults_)
        {
            TResults_ = tResults_;
            this.size = tResults_.Length;
            //SumTestResult();
        }

        private void SumTestResult()
        {
            for (int i = 0; i < size; i++)
            {
                testScore += TResults_[i].score;
            }
        }
    }
}
