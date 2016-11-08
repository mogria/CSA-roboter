using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{


    public partial class NumericInputForm : Form
    {



        private int number;

        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                numberDisplay.Text = number.ToString();
            }
        }

   
        public NumericInputForm()
        {
            InitializeComponent();
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                Button numberButton = sender as Button;
                Number = Number * 10 + int.Parse(numberButton.Text);
            }
        }
    }
}