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
    public partial class RunArc : UserControl
    {
        #region constructor & destructor
        public RunArc()
        {
            InitializeComponent();
            numericInputRadius.Tag = upDownArcRadius;
            numericInputAngle.Tag = upDownArcAngle;
        }
        #endregion


        #region properties
        public float Speed { get; set; }
        public float Acceleration { get; set; }
        public Drive Drive { get; set; }
        #endregion


        #region methods
        private void buttonArcNeg_Click(object sender, EventArgs e)
        {
            upDownArcAngle.Value = -upDownArcAngle.Value;
        }


        private void buttonStartArc_Click(object sender, EventArgs e)
        {
            if (Drive != null)
            {
                if (radioButtonArcRight.Checked)
                {
                    Drive.RunArcRight((float)upDownArcRadius.Value / 1000,
                        (float)upDownArcAngle.Value, Speed, Acceleration);
                }
                else
                {
                    Drive.RunArcLeft((float)upDownArcRadius.Value / 1000,
                        (float)upDownArcAngle.Value, Speed, Acceleration);
                }
            }
        }

        public void Start()
        {
            buttonStartArc_Click(null, EventArgs.Empty);
        }

        private void ButtonNumericInput_Click(object sender, EventArgs args)
        {
            if (!(sender is Button)) return;

            Button button = sender as Button;
            if (!(button.Tag is TextBox)) return;

            TextBox textBox = button.Tag as TextBox;

            NumericInputForm form = new NumericInputForm();
            form.NumberEntered = int.Parse(textBox.Text);

            if(form.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = form.NumberEntered + "";
            }
        }
        #endregion
    }
}