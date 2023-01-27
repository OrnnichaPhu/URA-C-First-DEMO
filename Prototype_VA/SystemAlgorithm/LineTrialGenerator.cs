using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype_VA.DataSystem;

namespace Prototype_VA.SystemAlgorithm
{
    internal class LineTrialGenerator : OptotypeHeight_Calculator
    {
        public static bool EndTrial = false;
        public static bool TestStart = false;

        private bool StateChange = false;

        private bool Isbonus = false;

        private bool IgnorTestEnd = false;

        public static bool IsRightTest = false; 
        public static bool IsLeftTest = true;

        public static bool AnsPopup = false;

        private static int SubTrialCount = 1;
        private int totalSubtrial = 36;
        public static int nexttrial = 0;



        public void CheckStatetrial()
        {
            int currentTrial = this.GetTrial();

            if (EndTrial == false)
            {
                if (currentTrial == 0)
                {
                    SubTrialCount++;
                    this.SetTrial(1);
                    System.Diagnostics.Debug.WriteLine("trial = {0}", currentTrial);
                    return;
                }
                if (currentTrial == 1)
                {
                    SubTrialCount++;
                    if (SubTrialCount == 4)
                        this.SetTrial(2);
                    return;
                }
                if (currentTrial == 2)
                {
                    SubTrialCount++;
                    if (SubTrialCount == 7)
                        this.SetTrial(3);
                    return;
                }
                if (currentTrial == 3)
                {
                    SubTrialCount++;
                    if (SubTrialCount == 11)
                        this.SetTrial(4);
                    return;
                }
                if (currentTrial == 4)
                {
                    SubTrialCount++;
                    if (SubTrialCount == 16)
                        this.SetTrial(5);
                    return;
                }
                if (currentTrial == 5)
                {
                    SubTrialCount++;
                    if (SubTrialCount == 22)
                        this.SetTrial(6);
                    return;
                }
                if (currentTrial == 6)
                {
                    SubTrialCount++;
                    if (SubTrialCount == 29)
                        this.SetTrial(7);
                    return;
                }
                if (currentTrial == 7)
                {
                    SubTrialCount++;
                    //System.Diagnostics.Debug.WriteLine("trial = {0}", currentTrial);
                    //System.Diagnostics.Debug.WriteLine("trial = {0}", SubTrialCount);
                    if (SubTrialCount == 36)
                        EndTrial = true;
                    return;
                }

            }
        }

        public bool IsContinue()
        {
            if (IsLeftTest && !IsRightTest)
            {
                EndTrial = false;
                SubTrialCount = 1;
                nexttrial = 0;
                this.SetTrial(0);
                IsRightTest = true;
                return true;
            }
            AnsPopup = true;
            return false;
        }

        /*
        private bool StateCheck()
        {
            if(IsLeftTest && !IsRightTest)
            {
                return true;
            }
            if (EndTrial && !IgnorTestEnd && !Isbonus)
            {
                return true;
            }
            return false;
        }
        
        private bool CheckStateChange()
        {
            return false;
        }
        */

        public bool GetEndtrial() { return EndTrial; }
        public bool GetAnsPopup() { return AnsPopup; }

    }
}
