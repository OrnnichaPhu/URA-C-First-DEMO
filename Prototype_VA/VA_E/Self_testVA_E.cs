using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype_VA.VA_E
{
    public partial class Self_testVA_E : Form
    {
        public Self_testVA_E()
        {
            InitializeComponent();

            if(vA.IsNewDistance() == false)
                vA.SetTestDistance(0.5);

            vA.CreatePatternScale();

            this.WindowState = FormWindowState.Maximized;

            this.KeyDown += Self_test_KeyDown;

            Displaytimer.Start();
            Skiptimer.Start();

            this.Invalidate();
            this.Update();
            this.Refresh();           
        }

        VA_EDrawing vA = new VA_EDrawing();

        bool blank = false;
        // VE+Display
        protected override void OnPaint(PaintEventArgs e)
        {           
            base.OnPaint(e);
            Graphics g = e.Graphics;
            if(blank == true)
                g.Clear(SystemColors.Control);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            vA.fillcolor(g);
        }


        //Visibility
        private void Displaytimer_Tick(object sender, EventArgs e)
        {
            Displaytimer.Stop();
            AnswerControlPanel.Visible = true;
            UnfreezeAllButton();
        }

        private void FreezeAllButton() 
        {
            bt_confirm.Enabled = false;
            bt_skip.Enabled = false;

            button2.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = false;
        }

        private void UnfreezeAllButton() 
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;

            bt_skip.Enabled = true;
        }

        private void UnfrerzeConfirm()
        {
            bt_confirm.Enabled = true;
        }





        //-----**Button**--------
        private void bt_confirm_Click(object sender, EventArgs e)
        {
            Skiptimer.Stop();
            FreezeAllButton();
            SendAns(AnsConf);
            if (vA.GetEndtrial() != true)
            {
                UpdatePatt();
                Displaytimer.Start();
                Skiptimer.Start();
            }
            else
            {
                vA.displayResult();
                vA.ChangeTestline();
                Result = MessageBox.Show("Score out of 36 =" + vA.GetSum());

                if (vA.IsContinue() == true)
                {
                    ContinueTest();
                }       
                
                
            }
            AnsConf[0] = 0;
       
        }

        DialogResult Result;
        private void ContinueTest()
        {
            vA.ResetPattern(); //In VA_EDrawing -- need to rewrite                   
            blank = true;
            AnswerControlPanel.Visible = false;
            Displaytimer.Stop();
            Skiptimer.Stop();
            FreezeAllButton();
            this.Invalidate();
            this.Update();
            this.Refresh();
            WaitTimer.Start();
        }

        private void bt_skip_Click(object sender, EventArgs e)
        {
            byte[] num = { 0 }; // Skip
            AnswerCollecting(num);
            if (bt_confirm.Enabled != true)
                UnfrerzeConfirm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] num = { 1 }; //Up
            AnswerCollecting(num);
            if (bt_confirm.Enabled != true)
                UnfrerzeConfirm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] num = { 2 }; //Down
            AnswerCollecting(num);
            if (bt_confirm.Enabled != true)
                UnfrerzeConfirm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] num = { 3 }; //Left
            AnswerCollecting(num);
            if (bt_confirm.Enabled != true)
                UnfrerzeConfirm();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] num = { 4 }; // Right
            AnswerCollecting(num);
            if (bt_confirm.Enabled != true)
                UnfrerzeConfirm();
        }

        // Keybord Answer
        private void Self_test_KeyDown(object? sender, KeyEventArgs e)
        {
            if (blank == false)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    byte[] num = { 1 }; // up
                    AnswerCollecting(num);
                    if (bt_confirm.Enabled != true)
                        UnfrerzeConfirm();
                }
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    byte[] num = { 2 }; // down
                    AnswerCollecting(num);
                    if (bt_confirm.Enabled != true)
                        UnfrerzeConfirm();
                }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    byte[] num = { 4 }; //left
                    AnswerCollecting(num);
                    if (bt_confirm.Enabled != true)
                        UnfrerzeConfirm();
                }
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    byte[] num = { 3 }; //right
                    AnswerCollecting(num);
                    if (bt_confirm.Enabled != true)
                        UnfrerzeConfirm();
                }

                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
                {
                    Skiptimer.Stop();
                    FreezeAllButton();
                    SendAns(AnsConf);

                    //System.Diagnostics.Debug.WriteLine("End = {0}", vA.GetEndtrial());

                    if (vA.GetEndtrial() == false)
                    {
                        UpdatePatt();
                        Displaytimer.Start();
                        Skiptimer.Start();
                    }
                    else
                    {
                        vA.displayResult();
                        vA.ChangeTestline();
                        Result = MessageBox.Show("Score out of 36 =" + vA.GetSum());
                        if (vA.IsContinue() == true)
                        {
                            ContinueTest();

                        }
                        // need to re write for statbility

                    }
                    AnsConf[0] = 0;
                }
            }
            //throw new NotImplementedException();
         
        }

        // Anewer swap
        private byte[] AnsConf = new byte[1];
        private void AnswerCollecting(byte[] NewAns)
        {
            byte[] currentAns = new byte[1];
            UnfreezeAllButton();
            currentAns[0] = NewAns[0];
            if (currentAns[0] == 0)
                bt_skip.Enabled = false;
            if (currentAns[0] == 1)
                button2.Enabled = false;
            if (currentAns[0] == 2)
                button3.Enabled = false;
            if (currentAns[0] == 3)
                button6.Enabled = false;
            if (currentAns[0] == 4)
                button5.Enabled = false;
            AnsConf[0] = currentAns[0];
        }

        // Answer Sending
        private void SendAns(byte[] Ans)
        {
            Skiptimer.Stop();
            vA.SetAnser(Ans);
            vA.ansValidate();
            AnswerControlPanel.Visible = false;
        }

        //Pattern Update
        private void UpdatePatt()
        {
            vA.UpdatePattern();
            this.Invalidate();
            this.Update();
            this.Refresh();
        }


        private void Skiptimer_Tick(object sender, EventArgs e)
        {
            Skiptimer.Stop();
            byte[] num = { 0 }; // Skip
            AnsConf = num;
            FreezeAllButton();
            SendAns(AnsConf);
            //AnsConf = num;

        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        {
            if(Result == DialogResult.OK)
            {
                WaitTimer.Stop();
                blank = false;  
                this.Invalidate();
                this.Update();
                this.Refresh();
                Displaytimer.Start();
                Skiptimer.Start();
            }
        }
    }
}
