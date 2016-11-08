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
        
        public Form1()
        {
            InitializeComponent();


            DriveCtrl driveCtrl = new DriveCtrl(0xF330);
            driveCtrlView.DriveCtrl = driveCtrl;
            MotorCtrl motorCtrlLeft = new MotorCtrl(0xF328);
            MotorCtrl motorCtrlRight = new MotorCtrl(0xF320);
            motorCtrlView1.MotorCtrl = motorCtrlLeft;
            motorCtrlView2.MotorCtrl = motorCtrlRight;
        }
        
    }
}
