using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameGUI
{
    public partial class MainForm : Form
    {
        public int GuessesLeft, Number;
        private Random random;
        private ComputerGuessForm ComputerForm;

        private void ComputerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ComputerRadioButton.Checked)
            {
                if (Application.OpenForms.OfType<ComputerGuessForm>().Count() == 0)
                {
                    ComputerForm = new ComputerGuessForm();
                    ComputerForm.Show();
                }
                else
                {
                    ComputerForm.Focus();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            random = new Random();
            GuessesLeft = 10;
            GuessesLeftLabel.Text = Convert.ToString(GuessesLeft);
            GuessesListBox.Items.Clear();
            Number = random.Next(0, 101);
            ResponseLabel.Visible = false;
            GuessButton.Enabled = true;
            MeRadioButton.Checked = true;
            GuessTextBox.Focus();
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            int Guess = Convert.ToInt32(GuessTextBox.Text);
            if (Guess > Number)
            {
                ResponseLabel.Text = "Too high!";
                GuessesLeft--;
            }
            else if (Guess < Number)
            {
                ResponseLabel.Text = "Too low!";
                GuessesLeft--;
            }
            else
            {
                ResponseLabel.Text = "You got it!";
            }
            ResponseLabel.Visible = true;
            GuessesLeftLabel.Text = Convert.ToString(GuessesLeft);
            GuessesListBox.Items.Add(Guess + ": " + ResponseLabel.Text);

            if (GuessesLeft == 0)
            {
                ResponseLabel.Text = $"No more guesses, you lose. The number was {Number}";
                GuessButton.Enabled = false;
            }
        }

        private void GuessTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        public MainForm()
        {
            InitializeComponent();
        }
    }
}
