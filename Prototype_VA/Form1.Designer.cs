namespace Prototype_VA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_VEtest = new System.Windows.Forms.Button();
            this.Windowpanel = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnInstruction = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Windowpanel.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_VEtest
            // 
            this.bt_VEtest.Location = new System.Drawing.Point(341, 202);
            this.bt_VEtest.Name = "bt_VEtest";
            this.bt_VEtest.Size = new System.Drawing.Size(94, 29);
            this.bt_VEtest.TabIndex = 0;
            this.bt_VEtest.Text = "test";
            this.bt_VEtest.UseVisualStyleBackColor = true;
            // 
            // Windowpanel
            // 
            this.Windowpanel.Controls.Add(this.btnTest);
            this.Windowpanel.Controls.Add(this.PanelMenu);
            this.Windowpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Windowpanel.Location = new System.Drawing.Point(0, 0);
            this.Windowpanel.Name = "Windowpanel";
            this.Windowpanel.Size = new System.Drawing.Size(639, 488);
            this.Windowpanel.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(352, 200);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(94, 29);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelMenu.Controls.Add(this.btnSetting);
            this.PanelMenu.Controls.Add(this.btnInstruction);
            this.PanelMenu.Controls.Add(this.btnHome);
            this.PanelMenu.Controls.Add(this.panelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(146, 488);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.Location = new System.Drawing.Point(0, 200);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(146, 48);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnInstruction
            // 
            this.btnInstruction.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInstruction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInstruction.Location = new System.Drawing.Point(0, 152);
            this.btnInstruction.Name = "btnInstruction";
            this.btnInstruction.Size = new System.Drawing.Size(146, 48);
            this.btnInstruction.TabIndex = 2;
            this.btnInstruction.Text = "Instruction";
            this.btnInstruction.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Location = new System.Drawing.Point(0, 104);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(146, 48);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(146, 104);
            this.panelLogo.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(639, 488);
            this.Controls.Add(this.Windowpanel);
            this.Name = "Form1";
            this.Windowpanel.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt_VEtest;
        private Panel Windowpanel;
        private Panel PanelMenu;
        private Panel panelLogo;
        private Button btnSetting;
        private Button btnInstruction;
        private Button btnHome;
        private Button btnTest;
    }
}