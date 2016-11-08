using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace TestConsole
{
    public partial class Form1 : Form
    {
        private RobotConsole console = new RobotConsole();
        public Form1()
        {
            InitializeComponent();
            this.consoleView1.RobotConsole = console;

            for (int i = 0; i < 4; i++) {
                console[(Leds)i].LedEnabled = console[(Switches)i].SwitchEnabled;
                console[(Switches)i].SwitchStateChanged += Form1_SwitchStateChanged;
            }
            
        }

        private void Form1_SwitchStateChanged(object sender, SwitchEventArgs e)
        {
            console[(Leds)e.Swi].LedEnabled = e.SwitchEnabled;
        }
    }
}
