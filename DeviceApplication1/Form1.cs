using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace DeviceApplication1
{
    public partial class Form1 : Form
    {

        private MotorCtrl motorCtrlLeft = new MotorCtrl(0xF328);
        private MotorCtrl motorCtrlRight = new MotorCtrl(0xF320);
        private DriveCtrl driveCtrl = new DriveCtrl(0xF330);
        public Form1()
        {
            InitializeComponent();

            motorCtrlView1.MotorCtrl = motorCtrlLeft;
            motorCtrlView2.MotorCtrl = motorCtrlRight;
            driveCtrlView.DriveCtrl = driveCtrl;
        }
        
    }
}
