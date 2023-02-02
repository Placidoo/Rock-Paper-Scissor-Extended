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

namespace RockPaperAndScissor
{
    public partial class mainMenu : Form
    {

        // Variables Here

        public bool Play;





        public mainMenu()
        {
            InitializeComponent();
            File.Delete("singlePlayer.ini");
            loadMenu();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (Play)
            {
                // Single Player
                singleDrawCard sdc = new singleDrawCard();
                sdc.Show();
                this.Hide();
            }
            else
            {
                Play = true;
                loadPlay();
                btnPlay.Image = Properties.Resources.singlePlayerHover;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (Play)
            {
                // Online Match
                MessageBox.Show("Coming Soon!");
            }
            else
            {
                // About the Game
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Play)
            {
                Play = false;
                loadMenu();
                btnExit.Image = Properties.Resources.exitHover;
            }
            else
            {
                Application.Exit();
            }
        }





        // Navigation Here

        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            if (Play)
            {
                btnPlay.Image = Properties.Resources.singlePlayerHover;
            }
            else
            {
                btnPlay.Image = Properties.Resources.playHover;
            }
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            if (Play)
            {
                btnPlay.Image = Properties.Resources.singlePlayer;
            }
            else
            {
                btnPlay.Image = Properties.Resources.Play;
            }
        }

        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            if (Play)
            {
                btnAbout.Image = Properties.Resources.onlineMatchHover;
            }
            else
            {
                btnAbout.Image = Properties.Resources.aboutHover;
            }
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            if (Play)
            {
                btnAbout.Image = Properties.Resources.onlineMatch;
            }
            else
            {
                btnAbout.Image = Properties.Resources.About;
            }
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            if (Play)
            {
                btnExit.Image = Properties.Resources.returnHover;
            }
            else
            {
                btnExit.Image = Properties.Resources.exitHover;
            }
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            if (Play)
            {
                btnExit.Image = Properties.Resources._return;
            }
            else
            {
                btnExit.Image = Properties.Resources.Exit;
            }
        }


        // Methods Here

        void loadMenu()
        {
            btnPlay.Image = Properties.Resources.Play;
            btnAbout.Image = Properties.Resources.About;
            btnExit.Image = Properties.Resources.Exit;
        }

        void loadPlay()
        {
            btnPlay.Image = Properties.Resources.singlePlayer;
            btnAbout.Image = Properties.Resources.onlineMatch;
            btnExit.Image = Properties.Resources._return;
        }

        
    }
}
