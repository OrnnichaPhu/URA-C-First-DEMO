using Prototype_VA.DataSystem;

namespace Prototype_VA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnHome.Enabled = false;
        }

        private Form activeForm;
        private Button currentButton;



        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.Enabled = false;
                    btnHome.Enabled = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in PanelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.Enabled = true;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Windowpanel.Controls.Add(childForm);
            this.Windowpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnHome.Enabled = false;
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
       
        private void btnTest_Click(object sender, EventArgs e)
        {
            btnTest.Enabled = false;
            this.WindowState = FormWindowState.Maximized;
            OpenChildForm(new FormWindow.FormGuildeline(), sender);
        }

        private void Reset()
        {
            DisableButton();
            currentButton = null;
            btnTest.Enabled = true;
            btnHome.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
           btnSetting.Enabled = false;
           OpenChildForm(new FormWindow.Setting(), sender);
        }
    }
}