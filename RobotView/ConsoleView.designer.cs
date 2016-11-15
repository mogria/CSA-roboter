namespace RobotView
{
    partial class ConsoleView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ledView1 = new RobotView.LEDView();
            this.ledView2 = new RobotView.LEDView();
            this.ledView3 = new RobotView.LEDView();
            this.ledView4 = new RobotView.LEDView();
            this.switchView1 = new RobotView.SwitchView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.switchView4 = new RobotView.SwitchView();
            this.switchView3 = new RobotView.SwitchView();
            this.switchView2 = new RobotView.SwitchView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ledView1
            // 
            this.ledView1.Location = new System.Drawing.Point(0, 0);
            this.ledView1.Name = "ledView1";
            this.ledView1.Size = new System.Drawing.Size(20, 40);
            this.ledView1.State = false;
            this.ledView1.TabIndex = 1;
            // 
            // ledView2
            // 
            this.ledView2.Location = new System.Drawing.Point(20, 0);
            this.ledView2.Name = "ledView2";
            this.ledView2.Size = new System.Drawing.Size(20, 40);
            this.ledView2.State = false;
            this.ledView2.TabIndex = 2;
            // 
            // ledView3
            // 
            this.ledView3.Location = new System.Drawing.Point(40, 0);
            this.ledView3.Name = "ledView3";
            this.ledView3.Size = new System.Drawing.Size(20, 40);
            this.ledView3.State = false;
            this.ledView3.TabIndex = 3;
            // 
            // ledView4
            // 
            this.ledView4.Location = new System.Drawing.Point(60, 0);
            this.ledView4.Name = "ledView4";
            this.ledView4.Size = new System.Drawing.Size(20, 40);
            this.ledView4.State = false;
            this.ledView4.TabIndex = 4;
            // 
            // switchView1
            // 
            this.switchView1.Location = new System.Drawing.Point(80, 0);
            this.switchView1.Name = "switchView1";
            this.switchView1.Size = new System.Drawing.Size(20, 40);
            this.switchView1.State = false;
            this.switchView1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.switchView4);
            this.panel1.Controls.Add(this.switchView3);
            this.panel1.Controls.Add(this.switchView2);
            this.panel1.Controls.Add(this.ledView1);
            this.panel1.Controls.Add(this.ledView4);
            this.panel1.Controls.Add(this.ledView2);
            this.panel1.Controls.Add(this.ledView3);
            this.panel1.Controls.Add(this.switchView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 40);
            // 
            // switchView4
            // 
            this.switchView4.Location = new System.Drawing.Point(140, 0);
            this.switchView4.Name = "switchView4";
            this.switchView4.Size = new System.Drawing.Size(20, 40);
            this.switchView4.State = false;
            this.switchView4.TabIndex = 8;
            // 
            // switchView3
            // 
            this.switchView3.Location = new System.Drawing.Point(120, 0);
            this.switchView3.Name = "switchView3";
            this.switchView3.Size = new System.Drawing.Size(20, 40);
            this.switchView3.State = false;
            this.switchView3.TabIndex = 7;
            // 
            // switchView2
            // 
            this.switchView2.Location = new System.Drawing.Point(100, 0);
            this.switchView2.Name = "switchView2";
            this.switchView2.Size = new System.Drawing.Size(20, 40);
            this.switchView2.State = false;
            this.switchView2.TabIndex = 6;
            // 
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel1);
            this.Name = "ConsoleView";
            this.Size = new System.Drawing.Size(160, 40);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private LEDView ledView1;
        private LEDView ledView2;
        private LEDView ledView3;
        private LEDView ledView4;
        private SwitchView switchView1;
        private System.Windows.Forms.Panel panel1;
        private SwitchView switchView4;
        private SwitchView switchView3;
        private SwitchView switchView2;
    }
}
