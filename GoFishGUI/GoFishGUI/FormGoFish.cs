using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFishGUI
{
    public partial class FormGoFish : Form
    {
        public FormGoFish()
        {
            InitializeComponent();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            Card card = new Card(1, 3);
        }
    }
}
