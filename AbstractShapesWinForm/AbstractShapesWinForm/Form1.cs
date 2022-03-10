using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shapes;

namespace AbstractShapesWinForm
{
    public partial class Form1 : Form
    {
        Shape shape;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateSquareBtn_Click(object sender, EventArgs e)
        {
            shape = new Square(Convert.ToInt32(txtLengthSideSquare.Text));
        }

        private void DisplayShapeBtn_Click(object sender, EventArgs e)
        {
            if (shape != null)
            {
                Graphics g = this.CreateGraphics();
                sidesLbl.Text = "Number of sides: " + shape.Sides;
                AreaLbl.Text = "Area: " + String.Format("{0:0.00}", shape.CalculateArea());
                shape.Draw(g, 100, 100);
            }
        }
    }
}
