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
        public Form1()
        {
            InitializeComponent();

            Robot robot = new Robot();
            radarView1.Radar = robot.Radar;
            driveView1.Drive = robot.Drive;
            runArc1.Drive = robot.Drive;
            runLine1.Drive = robot.Drive;
            runTurn1.Drive = robot.Drive;
            robot.Drive.Power = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
