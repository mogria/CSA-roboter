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
            this.Visible = true;
            NumberEntered = 0;

        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button numberButton = sender as Button;
                int number = int.Parse(numberButton.Text);

                NumberEntered *= 10;
                NumberEntered += number;
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

        public static void UpdateFromButton(object sender)
        {
            if (!(sender is Button)) return;

            Button button = sender as Button;
            if (!(button.Tag is TextBox)) return;

            TextBox textBox = button.Tag as TextBox;

            NumericInputForm form = new NumericInputForm();
            form.NumberEntered = int.Parse(textBox.Text);

            if (form.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = form.NumberEntered + "";
            }
        }
    }
}