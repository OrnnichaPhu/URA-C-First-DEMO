namespace Prototype_VA.VA_E
{
    partial class Self_testVA_E
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
            this.components = new System.ComponentModel.Container();
            this.AnswerControlPanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bt_confirm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_skip = new System.Windows.Forms.Button();
            this.Displaytimer = new System.Windows.Forms.Timer(this.components);
            this.Skiptimer = new System.Windows.Forms.Timer(this.components);
            this.WaitTimer = new System.Windows.Forms.Timer(this.components);
            this.AnswerControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnswerControlPanel
            // 
            this.AnswerControlPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AnswerControlPanel.Controls.Add(this.button5);
            this.AnswerControlPanel.Controls.Add(this.button6);
            this.AnswerControlPanel.Controls.Add(this.bt_confirm);
            this.AnswerControlPanel.Controls.Add(this.button3);
            this.AnswerControlPanel.Controls.Add(this.button2);
            this.AnswerControlPanel.Controls.Add(this.bt_skip);
            this.AnswerControlPanel.Location = new System.Drawing.Point(0, 325);
            this.AnswerControlPanel.Name = "AnswerControlPanel";
            this.AnswerControlPanel.Size = new System.Drawing.Size(800, 125);
            this.AnswerControlPanel.TabIndex = 0;
            this.AnswerControlPanel.Visible = false;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.Image = global::Prototype_VA.Properties.Resources.Picture2;
            this.button5.Location = new System.Drawing.Point(428, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 125);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button6_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.Image = global::Prototype_VA.Properties.Resources.Picture3;
            this.button6.Location = new System.Drawing.Point(552, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 125);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button5_Click);
            // 
            // bt_confirm
            // 
            this.bt_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_confirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_confirm.Image = global::Prototype_VA.Properties.Resources.Check;
            this.bt_confirm.Location = new System.Drawing.Point(676, 0);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(124, 125);
            this.bt_confirm.TabIndex = 3;
            this.bt_confirm.UseVisualStyleBackColor = false;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Image = global::Prototype_VA.Properties.Resources.Picture11;
            this.button3.Location = new System.Drawing.Point(248, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 125);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Image = global::Prototype_VA.Properties.Resources.Picture4;
            this.button2.Location = new System.Drawing.Point(124, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 125);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_skip
            // 
            this.bt_skip.BackColor = System.Drawing.Color.Red;
            this.bt_skip.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_skip.Location = new System.Drawing.Point(0, 0);
            this.bt_skip.Name = "bt_skip";
            this.bt_skip.Size = new System.Drawing.Size(124, 125);
            this.bt_skip.TabIndex = 0;
            this.bt_skip.UseVisualStyleBackColor = false;
            this.bt_skip.Click += new System.EventHandler(this.bt_skip_Click);
            // 
            // Displaytimer
            // 
            this.Displaytimer.Interval = 3000;
            this.Displaytimer.Tick += new System.EventHandler(this.Displaytimer_Tick);
            // 
            // Skiptimer
            // 
            this.Skiptimer.Interval = 30000;
            this.Skiptimer.Tick += new System.EventHandler(this.Skiptimer_Tick);
            // 
            // WaitTimer
            // 
            this.WaitTimer.Tick += new System.EventHandler(this.WaitTimer_Tick);
            // 
            // Self_testVA_E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AnswerControlPanel);
            this.Name = "Self_testVA_E";
            this.Text = "Self_test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.AnswerControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel AnswerControlPanel;
        private Button button5;
        private Button button6;
        private Button bt_confirm;
        private Button button3;
        private Button button2;
        private Button bt_skip;
        private System.Windows.Forms.Timer Displaytimer;
        private System.Windows.Forms.Timer Skiptimer;
        private System.Windows.Forms.Timer WaitTimer;
    }
}