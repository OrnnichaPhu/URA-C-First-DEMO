namespace Prototype_VA.FormWindow
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.head_panel = new System.Windows.Forms.Panel();
            this.head = new System.Windows.Forms.Label();
            this.choice_panel = new System.Windows.Forms.Panel();
            this.Distance = new System.Windows.Forms.Label();
            this.btnDefault = new System.Windows.Forms.Button();
            this.radio_btn_50cm = new System.Windows.Forms.RadioButton();
            this.radio_btn_1m = new System.Windows.Forms.RadioButton();
            this.radio_btn_2m = new System.Windows.Forms.RadioButton();
            this.radio_btn_3m = new System.Windows.Forms.RadioButton();
            this.radio_btn_4m = new System.Windows.Forms.RadioButton();
            this.radio_btn_5m = new System.Windows.Forms.RadioButton();
            this.radio_btn_6m = new System.Windows.Forms.RadioButton();
            this.sample_size = new System.Windows.Forms.Panel();
            this.head_panel.SuspendLayout();
            this.choice_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // head_panel
            // 
            this.head_panel.Controls.Add(this.head);
            this.head_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.head_panel.Location = new System.Drawing.Point(0, 0);
            this.head_panel.Name = "head_panel";
            this.head_panel.Size = new System.Drawing.Size(505, 63);
            this.head_panel.TabIndex = 0;
            // 
            // head
            // 
            this.head.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.head.AutoSize = true;
            this.head.Location = new System.Drawing.Point(194, 24);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(97, 20);
            this.head.TabIndex = 0;
            this.head.Text = "Example Size";
            this.head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choice_panel
            // 
            this.choice_panel.Controls.Add(this.Distance);
            this.choice_panel.Controls.Add(this.btnDefault);
            this.choice_panel.Controls.Add(this.radio_btn_50cm);
            this.choice_panel.Controls.Add(this.radio_btn_1m);
            this.choice_panel.Controls.Add(this.radio_btn_2m);
            this.choice_panel.Controls.Add(this.radio_btn_3m);
            this.choice_panel.Controls.Add(this.radio_btn_4m);
            this.choice_panel.Controls.Add(this.radio_btn_5m);
            this.choice_panel.Controls.Add(this.radio_btn_6m);
            this.choice_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.choice_panel.Location = new System.Drawing.Point(0, 360);
            this.choice_panel.Name = "choice_panel";
            this.choice_panel.Size = new System.Drawing.Size(505, 128);
            this.choice_panel.TabIndex = 1;
            // 
            // Distance
            // 
            this.Distance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(12, 3);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(66, 20);
            this.Distance.TabIndex = 16;
            this.Distance.Text = "Distance";
            this.Distance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(387, 69);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(117, 24);
            this.btnDefault.TabIndex = 15;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // radio_btn_50cm
            // 
            this.radio_btn_50cm.AutoSize = true;
            this.radio_btn_50cm.Location = new System.Drawing.Point(254, 69);
            this.radio_btn_50cm.Name = "radio_btn_50cm";
            this.radio_btn_50cm.Size = new System.Drawing.Size(127, 24);
            this.radio_btn_50cm.TabIndex = 14;
            this.radio_btn_50cm.TabStop = true;
            this.radio_btn_50cm.Text = "50 centimeters";
            this.radio_btn_50cm.UseVisualStyleBackColor = true;
            this.radio_btn_50cm.CheckedChanged += new System.EventHandler(this.radio_btn_50cm_CheckedChanged);
            // 
            // radio_btn_1m
            // 
            this.radio_btn_1m.AutoSize = true;
            this.radio_btn_1m.Location = new System.Drawing.Point(131, 69);
            this.radio_btn_1m.Name = "radio_btn_1m";
            this.radio_btn_1m.Size = new System.Drawing.Size(87, 24);
            this.radio_btn_1m.TabIndex = 13;
            this.radio_btn_1m.TabStop = true;
            this.radio_btn_1m.Text = "1 Meters";
            this.radio_btn_1m.UseVisualStyleBackColor = true;
            this.radio_btn_1m.CheckedChanged += new System.EventHandler(this.radio_btn_1m_CheckedChanged);
            // 
            // radio_btn_2m
            // 
            this.radio_btn_2m.AutoSize = true;
            this.radio_btn_2m.Location = new System.Drawing.Point(8, 69);
            this.radio_btn_2m.Name = "radio_btn_2m";
            this.radio_btn_2m.Size = new System.Drawing.Size(87, 24);
            this.radio_btn_2m.TabIndex = 12;
            this.radio_btn_2m.TabStop = true;
            this.radio_btn_2m.Text = "2 Meters";
            this.radio_btn_2m.UseVisualStyleBackColor = true;
            this.radio_btn_2m.CheckedChanged += new System.EventHandler(this.radio_btn_2m_CheckedChanged);
            // 
            // radio_btn_3m
            // 
            this.radio_btn_3m.AutoSize = true;
            this.radio_btn_3m.Location = new System.Drawing.Point(390, 39);
            this.radio_btn_3m.Name = "radio_btn_3m";
            this.radio_btn_3m.Size = new System.Drawing.Size(87, 24);
            this.radio_btn_3m.TabIndex = 11;
            this.radio_btn_3m.TabStop = true;
            this.radio_btn_3m.Text = "3 Meters";
            this.radio_btn_3m.UseVisualStyleBackColor = true;
            this.radio_btn_3m.CheckedChanged += new System.EventHandler(this.radio_btn_3m_CheckedChanged);
            // 
            // radio_btn_4m
            // 
            this.radio_btn_4m.AutoSize = true;
            this.radio_btn_4m.Location = new System.Drawing.Point(254, 39);
            this.radio_btn_4m.Name = "radio_btn_4m";
            this.radio_btn_4m.Size = new System.Drawing.Size(87, 24);
            this.radio_btn_4m.TabIndex = 10;
            this.radio_btn_4m.TabStop = true;
            this.radio_btn_4m.Text = "4 Meters";
            this.radio_btn_4m.UseVisualStyleBackColor = true;
            this.radio_btn_4m.CheckedChanged += new System.EventHandler(this.radio_btn_4m_CheckedChanged);
            // 
            // radio_btn_5m
            // 
            this.radio_btn_5m.AutoSize = true;
            this.radio_btn_5m.Location = new System.Drawing.Point(131, 39);
            this.radio_btn_5m.Name = "radio_btn_5m";
            this.radio_btn_5m.Size = new System.Drawing.Size(87, 24);
            this.radio_btn_5m.TabIndex = 9;
            this.radio_btn_5m.TabStop = true;
            this.radio_btn_5m.Text = "5 Meters";
            this.radio_btn_5m.UseVisualStyleBackColor = true;
            this.radio_btn_5m.CheckedChanged += new System.EventHandler(this.radio_btn_5m_CheckedChanged);
            // 
            // radio_btn_6m
            // 
            this.radio_btn_6m.AutoSize = true;
            this.radio_btn_6m.Location = new System.Drawing.Point(8, 39);
            this.radio_btn_6m.Name = "radio_btn_6m";
            this.radio_btn_6m.Size = new System.Drawing.Size(87, 24);
            this.radio_btn_6m.TabIndex = 8;
            this.radio_btn_6m.TabStop = true;
            this.radio_btn_6m.Text = "6 Meters";
            this.radio_btn_6m.UseVisualStyleBackColor = true;
            this.radio_btn_6m.CheckedChanged += new System.EventHandler(this.radio_btn_6m_CheckedChanged);
            // 
            // sample_size
            // 
            this.sample_size.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sample_size.Location = new System.Drawing.Point(0, 63);
            this.sample_size.Name = "sample_size";
            this.sample_size.Size = new System.Drawing.Size(505, 297);
            this.sample_size.TabIndex = 2;
            this.sample_size.Paint += new System.Windows.Forms.PaintEventHandler(this.sample_size_Paint);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 488);
            this.Controls.Add(this.sample_size);
            this.Controls.Add(this.choice_panel);
            this.Controls.Add(this.head_panel);
            this.Name = "Setting";
            this.Text = "Setting";
            this.head_panel.ResumeLayout(false);
            this.head_panel.PerformLayout();
            this.choice_panel.ResumeLayout(false);
            this.choice_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel head_panel;
        private Panel choice_panel;
        private Panel sample_size;
        private Label head;
        private Button btnDefault;
        private RadioButton radio_btn_50cm;
        private RadioButton radio_btn_1m;
        private RadioButton radio_btn_2m;
        private RadioButton radio_btn_3m;
        private RadioButton radio_btn_4m;
        private RadioButton radio_btn_5m;
        private RadioButton radio_btn_6m;
        private Label Distance;
    }
}