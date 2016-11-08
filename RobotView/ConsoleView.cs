using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class ConsoleView : UserControl
    {
        private RobotConsole _robotConsole;

        public RobotConsole RobotConsole
        {
            get { return _robotConsole; }
            set
            {
                if (value != null)
                {
                    ledView1.LED = value[Leds.Led1];
                    ledView1.LedDisplay = "1";
                    ledView2.LED = value[Leds.Led2];
                    ledView2.LedDisplay = "2";
                    ledView3.LED = value[Leds.Led3];

                    ledView3.LedDisplay = "3";
                    ledView4.LED = value[Leds.Led4];

                    ledView4.LedDisplay = "4";
                    switchView1.Switch = value[Switches.Switch1];
                    switchView2.Switch = value[Switches.Switch2];
                    switchView3.Switch = value[Switches.Switch3];
                    switchView4.Switch = value[Switches.Switch4];
                    _robotConsole = value;
                }
            }
        }

        public ConsoleView()
        {
            InitializeComponent();

        }
    }
}