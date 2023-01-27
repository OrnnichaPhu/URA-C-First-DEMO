using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype_VA.FormWindow
{
    public partial class FormGuildeline : Form
    {
        public FormGuildeline()
        {
            InitializeComponent();
        }

       


        private void btnStart_Click(object sender, EventArgs e)
        {
            VA_E.Self_testVA_E self_ = new VA_E.Self_testVA_E();
            if (!self_.IsDisposed)
                self_.ShowDialog();
        }
    }
}
