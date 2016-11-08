using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class SwitchView : UserControl
    {

        private bool state;

        public bool State
        {
            set
            {
                pictureBox1.Image = value ? RobotView.Resources.SwitchOn : RobotView.Resources.SwitchOff;
                state = value;
            }
            get
            {
                return state;
            }
        }

        private RobotCtrl.Switch _switch;

        public RobotCtrl.Switch Switch
        {
            get { return _switch; }
            set
            {
                if (_switch != null) _switch.SwitchStateChanged -= Switch_SwitchStateChanged; 
                _switch = value;
                if (value != null)
                {
                    State = value.SwitchEnabled;
                    value.SwitchStateChanged += Switch_SwitchStateChanged;
                }
            }
        }

        private void Switch_SwitchStateChanged(object sender, RobotCtrl.SwitchEventArgs e)
        {
            if (InvokeRequired)
            {
                this.Invoke(new EventHandler<RobotCtrl.SwitchEventArgs>(Switch_SwitchStateChanged), new object[] { sender, e });
            }
            else
            {
                State = e.SwitchEnabled;
            }
        }

        public SwitchView()
        {
            InitializeComponent();
            State = false;
        }
    }
}