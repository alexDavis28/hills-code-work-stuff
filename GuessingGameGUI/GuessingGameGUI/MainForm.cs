using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void NewGame(int LoadedNumber, int LoadedGuessesLeft, List<string> LoadedGuesses)
        {
            random = new Random();
            GuessesLeft = LoadedGuessesLeft;
            GuessesLeftLabel.Text = Convert.ToString(GuessesLeft);
            GuessesListBox.Items.Clear();
            Number = LoadedNumber;
            ResponseLabel.Visible = false;
            GuessButton.Enabled = true;
            MeRadioButton.Checked = true;
            GuessTextBox.Focus();

            foreach (string guess in LoadedGuesses)
            {
                GuessesListBox.Items.Add(guess);
            }

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save: number, guesses, num_guesses_left

            String data = Convert.ToString(Number) + "\n" + Convert.ToString(GuessesLeft) + "\n";
            foreach (object item in GuessesListBox.Items)
            {
                data += Convert.ToString(item);
                data += "\n";
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, data);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int number = 50, guesses_left = 10;
            List<String> guesses = new List<string> { };
            int counter = 0;

            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            OFD.FilterIndex = 0;

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                foreach (string line in File.ReadLines(OFD.FileName))
                {
                    if (counter==0)
                    {
                        number = Convert.ToInt32(line);
                    }
                    else if (counter==1)
                    {
                        guesses_left = Convert.ToInt32(line);
                    }
                    else
                    {
                        guesses.Add(line);
                    }
                    counter++;
                }
            }
            NewGame(number, guesses_left, guesses);
        }

        public MainForm()
        {
            InitializeComponent();
        }
    }
}
