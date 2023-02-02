using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace RockPaperAndScissor
{
    public partial class singleDrawCard : Form
    {

        // Variables Here

        public bool drawing = false;
        public int counter = 0;
        public int rockMoves = 0;
        public int paperMoves = 0;
        public int scissorMoves = 0;

        public Random rng = new Random();


        public singleDrawCard()
        {
            InitializeComponent();
            btnDrawCard.Image = Properties.Resources.drawCard1;
            btnDrawCard.Location = new Point(224,203);
        }

        private void singleDrawCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            mainMenu menu = new mainMenu();
            menu.Show();
            this.Hide();
        }

        private void btnDrawCard_Click(object sender, EventArgs e)
        {
            if (!drawing)
            {
                btnReturn.Hide();
                counter = 0;
                drawingCard.Enabled = true;
                drawing = true;
                btnDrawCard.Cursor = Cursors.WaitCursor;
            }
        }

        private void drawingCard_Tick(object sender, EventArgs e)
        {
            counter++;
            btnDrawCard.Location = new Point(224, 203);
            if (counter == 0)
            {
                btnDrawCard.Image = Properties.Resources.drawCard1;
            }
            else if (counter == 1)
            {
                btnDrawCard.Image = Properties.Resources.drawingRock;
            }
            else if (counter == 2)
            {
                btnDrawCard.Image = Properties.Resources.drawingPaper;
            }
            else if (counter == 3)
            {
                btnDrawCard.Image = Properties.Resources.drawingScissors;
            }
            else
            {
                counter = 0;
            }

            int cardGenerator = rng.Next(1, 4);
            switch (cardGenerator)
            {
                case 1:
                    rockMoves++;
                    break;
                case 2:
                    paperMoves++;
                    break;
                case 3:
                    scissorMoves++;
                    break;
            }

            if (rockMoves + paperMoves + scissorMoves == 10)
            {
                drawingCard.Enabled = false;
                File.WriteAllText("singlePlayer.ini",$"{rockMoves}\n{paperMoves}\n{scissorMoves}");
                btnDrawCard.Hide();
                movesPanel.Show();
                lblRock.Text = $"x{rockMoves}";
                lblPaper.Text = $"x{paperMoves}";
                lblScissor.Text = $"x{scissorMoves}";
            }
        }
        private void btnProceed_Click(object sender, EventArgs e)
        {
            singleGame sg = new singleGame();
            sg.Show();
            this.Hide();
        }



        // Navigation

        private void btnDrawCard_MouseEnter(object sender, EventArgs e)
        {
            if (!drawing)
            {
                btnDrawCard.Image = Properties.Resources.drawCard2;
                btnDrawCard.Location = new Point(216, 169);
            }
        }

        private void btnDrawCard_MouseLeave(object sender, EventArgs e)
        {
            if (!drawing)
            {
                btnDrawCard.Image = Properties.Resources.drawCard1;
                btnDrawCard.Location = new Point(224, 203);
            }
        }

    }
}
