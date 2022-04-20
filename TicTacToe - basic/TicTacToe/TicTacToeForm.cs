using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToeForm : Form
    {
        private string NoughtOrCross;
        private Button[,] gridButtons;

        // Grid
        const int SQUARE_GRID_SIZE = 3;
        const int cols = SQUARE_GRID_SIZE;
        const int rows = SQUARE_GRID_SIZE;
        const int gridWidth = 300;
        const int gridHeight = 300;
        const int tileWidth = gridWidth / cols;
        const int tileHeight = gridHeight / rows;
        const int gridTop = 100;
        const int gridLeft = 50;

        private void NewGame()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    gridButtons[r, c].Text = "";
                    gridButtons[r, c].Enabled = true;
                    gridButtons[r, c].BackColor = Color.Beige;
                }
            }
            NoughtOrCross = "X";
        }

        /// <summary>
        /// Generates a grid of buttons  
        /// </summary>
        /// <param name="rows">Numebr of rows</param>
        /// <param name="cols">Number of columns</param>
        /// <param name="tileWidth">Button Width</param>
        /// <param name="tileHeight">Button Height</param>
        /// <param name="gridTop">Vertical position</param> 
        /// <param name="gridLeft">Horizontal position</param>
        private void CreateGrid(int rows, int cols, int tileWidth, int tileHeight, int gridTop, int gridLeft)
        {
            gridButtons = new Button[rows, cols];
            // double for loop to handle all rows and columns
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    // create new Button control which will be one 
                    // of the buttons of the grid
                    gridButtons[r, c] = new Button()
                    {
                        Size = new Size(tileWidth, tileHeight),
                        Location = new Point(tileWidth * c + gridLeft, tileHeight * r + gridTop),
                        BackColor = Color.Beige,
                        Font = new Font("Arial", gridWidth / cols / 3), // font size proportional to width and # columns
                    };
                    // you can also modify the properties 
                    gridButtons[r, c].ForeColor = Color.Black;
                    // add to Form's Controls so that they show up
                    gridButtons[r, c].Click += new EventHandler(gridButtonClick);
                    // 
                    Controls.Add(gridButtons[r, c]);
                }
            }

        }


        public TicTacToeForm()
        {
            InitializeComponent();
        }


        
       
        private void Form1_Load(object sender, EventArgs e)
        {

            CreateGrid(rows, cols, tileWidth, tileHeight, gridTop, gridLeft);
            NewGame();

        }
        private void gridButtonClick(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "")
            {
                ((Button)sender).Text = NoughtOrCross;

                if (CheckWin())
                {
                    MessageBox.Show($"{NoughtOrCross} wins!");
                    NewGame();
                }
                else
                {
                    if (NoughtOrCross == "X")
                    {
                        NoughtOrCross = "O";
                    }
                    else
                    {
                        NoughtOrCross = "X";
                    }
                }
            }
            
        }

        private bool CheckWin()
        {
            bool result = false;
            for (int r = 0; r < rows; r++)
            {
                if (gridButtons[r, 0].Text == gridButtons[r, 1].Text && gridButtons[r,0].Text == gridButtons[r, 2].Text && gridButtons[r, 0].Text != "")
                {
                    result = true;
                }
            }
            for (int c = 0; c < cols; c++)
            {
                if (gridButtons[0, c].Text == gridButtons[1, c].Text && gridButtons[1, c].Text == gridButtons[2, c].Text && gridButtons[0, c].Text != "")
                {
                    result = true;
                }
            }
            if (gridButtons[0, 0].Text == gridButtons[1, 1].Text && gridButtons[1, 1].Text == gridButtons[2, 2].Text && gridButtons[0, 0].Text != "")
            {
                result = true;
            }
            if (gridButtons[0, 2].Text == gridButtons[1, 1].Text && gridButtons[1, 1].Text == gridButtons[2, 0].Text && gridButtons[0, 2].Text != "")
            {
                result = true;
            }
            return result;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
    
}
