using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculatorFormsApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int num_1 = Convert.ToInt32(number1TextBox.Text);
            int num_2 = Convert.ToInt32(number2TextBox.Text);

            if (radioButton1.Checked)
            {
                // Add
                number3TextBox.Text = (num_1 + num_2).ToString();
            }
            else if (radioButton2.Checked)
            {
                // Subtract
                number3TextBox.Text = (num_1 - num_2).ToString();
            }
            else if (radioButton3.Checked)
            {
                // Multiply
                number3TextBox.Text = (num_1 * num_2).ToString();
            }
            else if (radioButton4.Checked)
            {
                // Divide
                number3TextBox.Text = (num_1 / num_2).ToString();
            }
            else
            {
                number3TextBox.Text = "Select an operation";
            }
        }

        private void number1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void number2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
