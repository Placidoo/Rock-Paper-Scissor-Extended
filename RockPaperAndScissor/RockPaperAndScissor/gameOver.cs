using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperAndScissor
{
    public partial class gameOver : Form
    {
        public gameOver()
        {
            InitializeComponent();

            string text = File.ReadAllText("singlePlayer.ini");
            string[] Text = text.Split('\n');

            lblResult.Text = Text[0];
            lblScore.Text = Text[1];
        }

        private void gameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblPlayAgain_Click(object sender, EventArgs e)
        {
            singleDrawCard sdc = new singleDrawCard();
            sdc.Show();
            this.Hide();
        }

        private void lblMainMenu_Click(object sender, EventArgs e)
        {
            mainMenu mm = new mainMenu();
            mm.Show();
            this.Hide();
        }
    }
}
