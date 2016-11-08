namespace DeviceApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.driveCtrlView = new RobotView.DriveCtrlView();
            this.motorCtrlView1 = new RobotView.MotorCtrlView();
            this.motorCtrlView2 = new RobotView.MotorCtrlView();
            this.SuspendLayout();
            // 
            // driveCtrlView
            // 
            this.driveCtrlView.DriveCtrl = null;
            this.driveCtrlView.Location = new System.Drawing.Point(0, 0);
            this.driveCtrlView.Name = "driveCtrlView";
            this.driveCtrlView.Size = new System.Drawing.Size(274, 57);
            this.driveCtrlView.TabIndex = 1;
            this.driveCtrlView.Click += new System.EventHandler(this.driveCtrlView_Click);
            // 
            // motorCtrlView1
            // 
            this.motorCtrlView1.Location = new System.Drawing.Point(3, 63);
            this.motorCtrlView1.MotorCtrl = null;
            this.motorCtrlView1.Name = "motorCtrlView1";
            this.motorCtrlView1.Size = new System.Drawing.Size(431, 258);
            this.motorCtrlView1.TabIndex = 2;
            // 
            // motorCtrlView2
            // 
            this.motorCtrlView2.Location = new System.Drawing.Point(461, 63);
            this.motorCtrlView2.MotorCtrl = null;
            this.motorCtrlView2.Name = "motorCtrlView2";
            this.motorCtrlView2.Size = new System.Drawing.Size(431, 258);
            this.motorCtrlView2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(959, 571);
            this.Controls.Add(this.driveCtrlView);
            this.Controls.Add(this.motorCtrlView1);
            this.Controls.Add(this.motorCtrlView2);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private RobotView.DriveCtrlView driveCtrlView;
        private RobotView.MotorCtrlView motorCtrlView1;
        private RobotView.MotorCtrlView motorCtrlView2;
    }
}

