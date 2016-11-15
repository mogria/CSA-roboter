using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestRadar
{
    public partial class Form1 : Form
    {
        Robot robot;
        public Form1()
        {
            InitializeComponent();

            robot = new Robot();
            radarView1.Radar = robot.Radar;
            driveView1.Drive = robot.Drive;
            runArc1.Drive = robot.Drive;
            runLine1.Drive = robot.Drive;
            runTurn1.Drive = robot.Drive;

            robot.Drive.Power = true;



            runArc1.Speed = commonRun1.Speed;
            runLine1.Speed = commonRun1.Speed;
            runTurn1.Speed = commonRun1.Speed;
            runArc1.Acceleration = commonRun1.Acceleration;
            runLine1.Acceleration = commonRun1.Acceleration;
            runTurn1.Acceleration = commonRun1.Acceleration;

            commonRun1.AccelerationChanged += CommonRun1_AccelerationChanged;
            commonRun1.SpeedChanged += CommonRun1_SpeedChanged;
            radarView1.Crash += RadarView1_Crash;
            
        }

        private void RadarView1_Crash(object sender, EventArgs e)
        {
            robot.Drive.Stop();
        }

        private void CommonRun1_SpeedChanged(object sender, EventArgs e)
        {
            runArc1.Speed = commonRun1.Speed;
            runLine1.Speed = commonRun1.Speed;
            runTurn1.Speed = commonRun1.Speed;
            
        }

        private void CommonRun1_AccelerationChanged(object sender, EventArgs e)
        {
            runArc1.Acceleration = commonRun1.Acceleration;
            runLine1.Acceleration = commonRun1.Acceleration;
            runTurn1.Acceleration = commonRun1.Acceleration;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
