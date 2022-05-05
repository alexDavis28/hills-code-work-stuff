using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using CardClasses;
using BlackJackGUI.Properties;

// TODO: add second image list for p2


namespace CardGameGUI
{
    public partial class FormBlackJack : Form 
    {
        Pack pack;
        BlackJackHand P1Hand;
        BlackJackHand P2Hand;
        // A resource manager provides convenient access to culture-specific resources at run time.
        // We need this to access the images that Resources for this project
        ResourceManager rm = Resources.ResourceManager;
        Graphics g;
        int HandLimit = 7;
        
        /// <summary>
       /// Form Constructor
       /// </summary>
        public FormBlackJack()
        {
            InitializeComponent();
        }

        private void FormBlackJack_Load(object sender, EventArgs e)
        {
            pack = new Pack();
            P1Hand = new BlackJackHand();
            P2Hand = new BlackJackHand();
            g = CreateGraphics();
            // C# ImageList Use: Windows Forms. 
            //ImageList provides a container for image data. 
            //The control is not visible directly. It is instead referenced from other controls such as ListView, 
            // which acquire the images from index values into the ImageList.
            P1ImageList.ImageSize = new Size(72, 96); // Sets the size of the images in the image list.
            P2ImageList.ImageSize = new Size(72, 96);
            pack.Shuffle();

            NewGame();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            // Hands are emptied, any card in hands is returned to the pack 
            while (!P1Hand.IsEmpty())
            {
                pack.AddCard(P1Hand.RemoveCard(P1Hand.First()));
            }

            while (!P2Hand.IsEmpty())
            {
                pack.AddCard(P2Hand.RemoveCard(P2Hand.First()));
            }

            P1ImageList.Images.Clear();
            P2ImageList.Images.Clear();
            Invalidate(); // forces to repaint the form

            P1Hand.AddCard(pack.DealCard());
            CreateImage(P1Hand.Last(), 0, 1);

            P2Hand.AddCard(pack.DealCard());
            CreateImage(P2Hand.Last(), 0, 2);

            P1CurrentScoreLabel.Visible = true;
            P2CurrentScoreLabel.Visible = true;

            Player1DealButton.Enabled = true;
            Player2DealButton.Enabled = false;

            Score();
        }

        private void Player1DealButton_Click(object sender, EventArgs e)
        {
            if (P1Hand.Size < HandLimit)
            {
                P1Hand.AddCard(pack.DealCard());
                CreateImage(P1Hand.Last(), P1Hand.Size - 1, 1);
            }
            Player1DealButton.Enabled = false;
            Player2DealButton.Enabled = true;

            Score();
        }
        private void Player2DealButton_Click(object sender, EventArgs e)
        {
            if (P2Hand.Size < HandLimit)
            {
                P2Hand.AddCard(pack.DealCard());
                CreateImage(P2Hand.Last(), P2Hand.Size - 1, 2);
            }

            Player1DealButton.Enabled = true;
            Player2DealButton.Enabled = false;

            Score();
        }

        private void CreateImage(Card card, int index, int player)
        {
            // Image name exampke: _1c 1 is the rank, c first character of suit (clubs)  
            string imagename = "_" + card.GetRank().ToString() + card.GetSuitAsString().ToLower()[0];
            // get the resource from Resources (casted to Image)
            Image cardimage = (Image)rm.GetObject(imagename);

            if (player == 1)
            {
                P1ImageList.Images.Add(cardimage);
            }
            else if (player == 2)
            {
                P2ImageList.Images.Add(cardimage);
            }
            // force a call to the Paint method of the form
            Invalidate();
        }

        private void FormBlackJack_Paint(object sender, PaintEventArgs e)
        {
            for(int i=0;i<P1ImageList.Images.Count;i++)
            {
                // (image, X, Y, Width, Height) 
                // cards will be spaced every 100 pixels (i*100)
                g.DrawImage(P1ImageList.Images[i], 100 + i * 100, 100, 72, 96);
            }

            for (int i = 0; i < P2ImageList.Images.Count; i++)
            {
                // (image, X, Y, Width, Height) 
                // cards will be spaced every 100 pixels (i*100)
                g.DrawImage(P2ImageList.Images[i], 100 + i * 100, 280, 72, 96);
            }
        }

        private void Score()
        {
            P1CurrentScoreLabel.Text = Convert.ToString(P1Hand.Size);
            P2CurrentScoreLabel.Text = Convert.ToString(P2Hand.Size);

            P1ScoreLabel.Text = Convert.ToString(P1Hand.GetScore());
            P2ScoreLabel.Text = Convert.ToString(P2Hand.GetScore());
        }
        
    }
}

