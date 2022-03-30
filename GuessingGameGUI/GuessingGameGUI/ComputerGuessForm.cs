using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuessingGameGUI
{
    public partial class ComputerGuessForm : Form
    {
        int guess, low, high, mid, numGuesses;
        public ComputerGuessForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TooLowButton_Click(object sender, EventArgs e)
        {
            low = mid;
            MakeGuess();
        }

        private void TooHighButton_Click(object sender, EventArgs e)
        {
            high = mid;
            MakeGuess();
        }

        private void CorrectButton_Click(object sender, EventArgs e)
        {
            GuessLabel.Text = $"The number was {mid}, that took {numGuesses} guesses.";
        }

        private void ComputerGuessForm_Load(object sender, EventArgs e)
        {
            low = 0;
            high = 100;
            mid = 50;
            MakeGuess();
        }

        private void MakeGuess()
        {
            mid = (low + high) / 2;
            GuessLabel.Text = "Is it " + mid + "?";
            numGuesses++;
        }

    }
}
