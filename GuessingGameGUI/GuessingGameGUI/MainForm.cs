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
            GuessesListBox.Items.Clear();
            Number = random.Next(0, 101);
            ResponseLabel.Visible = false;
        }

        public MainForm()
        {
            InitializeComponent();
        }
    }
}
