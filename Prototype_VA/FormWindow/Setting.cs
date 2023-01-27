using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototype_VA.DataSystem;

namespace Prototype_VA.FormWindow
{
    public partial class Setting : Form
    {

        public Setting()
        {
            InitializeComponent();
            SetToDefault();
        }

        TestData TestData = new TestData();
        private static double distance = 0.5;

        private RadioButton currentButton;


        private void SetToDefault()
        {
            distance = 0.5;
            TestData.SetTestDistance(distance);
        }

        private void sample_size_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radio_btn_6m_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_btn_6m.Checked)
            {
                distance = 6.0;
                ActivateButton(sender);
                /*
                TestData.SetTestDistance(distance);
                MessageBox.Show("Set distance to " + distance +" Meters");
                */
            }
        }

        private void radio_btn_5m_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_btn_5m.Checked)
            {
                distance = 5.0;
                ActivateButton(sender);
                /*
                TestData.SetTestDistance(distance);
                MessageBox.Show("Set distance to " + distance + " Meters");
                */
            }
        }

        private void radio_btn_4m_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_btn_4m.Checked)
            {
                distance = 4.0;
                ActivateButton(sender);
                /*
                TestData.SetTestDistance(distance);
                MessageBox.Show("Set distance to " + distance + " Meters");
                */
            }
        }

        private void radio_btn_3m_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_btn_3m.Checked)
            {
                distance = 3.0;
                ActivateButton(sender);
                /*
                TestData.SetTestDistance(distance);
                MessageBox.Show("Set distance to " + distance + " Meters");
                */
            }
        }

        private void radio_btn_2m_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_btn_2m.Checked)
            {
                distance = 2.0;
                ActivateButton(sender);
                /*
                TestData.SetTestDistance(distance);
                MessageBox.Show("Set distance to " + distance + " Meters");
                */
            }
        }

        private void radio_btn_1m_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_btn_1m.Checked)
            {
                distance = 1;
                ActivateButton(sender);
                /*
                TestData.SetTestDistance(distance);
                MessageBox.Show("Set distance to " + distance + " Meters");
                */
            }
        }

        private void radio_btn_50cm_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_btn_50cm.Checked)
            {
                distance = 0.5;
                ActivateButton(sender);
                /*
                TestData.SetTestDistance(distance);
                MessageBox.Show("Set distance to " + distance + " Meters");
                */
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            SetToDefault();
            if(currentButton != null)
                currentButton.Checked = false;
            MessageBox.Show("Set distance to " + distance + " Meters");
        }


        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (RadioButton)btnSender)
                {
                    currentButton = (RadioButton)btnSender;
                    TestData.SetTestDistance(distance);
                    MessageBox.Show("Set distance to " + distance + " Meters");
                }
            }
        }


    }
}
