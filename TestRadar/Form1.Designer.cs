using RobotCtrl;
using RobotView;

namespace TestRadar
{
    partial class Form1
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
            this.radarView1 = new RobotView.RadarView();
            this.driveView1 = new RobotView.DriveView();
            this.runArc1 = new RobotView.RunArc();
            this.runTurn1 = new RobotView.RunTurn();
            this.runLine1 = new RobotView.RunLine();
            this.SuspendLayout();
            // 
            // radarView1
            // 
            this.radarView1.Location = new System.Drawing.Point(55, 328);
            this.radarView1.Name = "radarView1";
            this.radarView1.Radar = null;
            this.radarView1.Size = new System.Drawing.Size(635, 42);
            this.radarView1.TabIndex = 0;
            // 
            // driveView1
            // 
            this.driveView1.Drive = null;
            this.driveView1.Location = new System.Drawing.Point(3, 3);
            this.driveView1.Name = "driveView1";
            this.driveView1.Size = new System.Drawing.Size(292, 289);
            this.driveView1.TabIndex = 1;
            // 
            // runArc1
            // 
            this.runArc1.Acceleration = 0F;
            this.runArc1.Drive = null;
            this.runArc1.Location = new System.Drawing.Point(361, 121);
            this.runArc1.Name = "runArc1";
            this.runArc1.Size = new System.Drawing.Size(351, 90);
            this.runArc1.Speed = 0F;
            this.runArc1.TabIndex = 2;
            // 
            // runTurn1
            // 
            this.runTurn1.Acceleration = 0F;
            this.runTurn1.Drive = null;
            this.runTurn1.Location = new System.Drawing.Point(361, 70);
            this.runTurn1.Name = "runTurn1";
            this.runTurn1.Size = new System.Drawing.Size(353, 45);
            this.runTurn1.Speed = 0F;
            this.runTurn1.TabIndex = 4;
            // 
            // runLine1
            // 
            this.runLine1.Acceleration = 0F;
            this.runLine1.Drive = null;
            this.runLine1.Length = 1F;
            this.runLine1.Location = new System.Drawing.Point(363, 18);
            this.runLine1.Name = "runLine1";
            this.runLine1.Size = new System.Drawing.Size(351, 46);
            this.runLine1.Speed = 0F;
            this.runLine1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(754, 373);
            this.Controls.Add(this.radarView1);
            this.Controls.Add(this.driveView1);
            this.Controls.Add(this.runArc1);
            this.Controls.Add(this.runLine1);
            this.Controls.Add(this.runTurn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RadarView radarView1;
        private DriveView driveView1;
        private RunArc runArc1;
        private RunLine runLine1;
        private RunTurn runTurn1;



    }
}

