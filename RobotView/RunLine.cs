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
    public partial class RunLine : UserControl
    {
        #region constructor & destructor
        public RunLine()
        {
            InitializeComponent();
        }
        #endregion


        #region properties
        public float Speed { get; set; }
        public float Acceleration { get; set; }
        public Drive Drive { get; set; }
        #endregion


        #region methods
        private void buttonLineNeg_Click(object sender, EventArgs e)
        {
            upDownLineLength.Value = -upDownLineLength.Value;
        }

        private void buttonLineStart_Click(object sender, EventArgs e)
        {
            if (Drive != null) Drive.RunLine(
                (float)upDownLineLength.Value / 1000,
                Speed, Acceleration);
        }

        public void Start()
        {
            buttonLineStart_Click(null, EventArgs.Empty);
        }

        public float Length
        {
            get { return (float)(upDownLineLength.Value / 1000); }
            set { upDownLineLength.Value = (decimal)(value * 1000); }
        }
        #endregion

    }
}