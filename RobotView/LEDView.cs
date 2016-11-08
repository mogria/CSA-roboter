using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class LEDView : UserControl
    {
        private bool state;

        public bool State
        {
            set
            {
                pictureBox1.Image = value ? RobotView.Resources.LedOn : RobotView.Resources.LedOff;
                state = value;
            }
            get
            {
                return state;
            }
        }

        private RobotCtrl.Led led;

        public RobotCtrl.Led LED
        {
            get
            {
                return led;
            }
            set
            {
                if(led != null) led.LedStateChanged -= Led_LedStateChanged;
                led = value;
                if (value != null)
                {
                    State = value.LedEnabled;
                    value.LedStateChanged += Led_LedStateChanged;
                }
            }
        }

        public string LedDisplay
        {
            get
            {
                return ledNum.Text;
            }
            set
            {
                ledNum.Text = value;
            }
        }

        private void Led_LedStateChanged(object sender, RobotCtrl.LedEventArgs e)
        {
            if (InvokeRequired)
            {
                this.Invoke(new EventHandler<RobotCtrl.LedEventArgs>(Led_LedStateChanged), new object[] { sender, e });
            }
            else
            {
                State = e.LedEnabled;
            }
        }

        public LEDView()
        {
            InitializeComponent();
            State = false;
        }
    }
}
