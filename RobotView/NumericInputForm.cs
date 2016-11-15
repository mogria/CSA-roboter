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

        private int numberEntered;

        public int NumberEntered
        {
            get { return numberEntered; }
            set
            {
                numberDisplay.Text = value + "";
                numberEntered = value;
            }
        }

        public NumericInputForm()
        {
            InitializeComponent();
            NumberEntered = 0;

        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button numberButton = sender as Button;
                int number = 0;
                if (int.TryParse(numberButton.Text, out number))
                {
                    NumberEntered *= 10;
                    NumberEntered += number;
                }
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            NumberEntered *= -1;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            NumberEntered /= 10;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            NumberEntered = 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}