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
    public partial class singleGame : Form
    {

        // Variables Here

        public int rockMoves = 0;
        public int paperMoves = 0;
        public int scissorMoves = 0;

        public int enemyRock = 0;
        public int enemyPaper = 0;
        public int enemyScissor = 0;

        public int turn = 0;
        public int yourScore = 0;
        public int enemyScore = 0;

        public string myMove;
        public string enemyMove;
        public string result;

        public Random rng = new Random();



        public singleGame()
        {
            InitializeComponent();

            string scores = File.ReadAllText("singlePlayer.ini");
            string[] Scores = scores.Split('\n');

            rockMoves = Convert.ToInt32(Scores[0]);
            paperMoves = Convert.ToInt32(Scores[1]);
            scissorMoves = Convert.ToInt32(Scores[2]);

            Start();
        }

        private void singleGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void scoreUpdater_Tick(object sender, EventArgs e)
        {
            lblRock.Text = $"x{rockMoves}";
            lblPaper.Text = $"x{paperMoves}";
            lblScissor.Text = $"x{scissorMoves}";

            lblTurn.Text = turn.ToString();
            lblYourScore.Text = yourScore.ToString();
            lblEnemyScore.Text = enemyScore.ToString();

            if (rockMoves == 0)
            {
                btnRock.Image = Properties.Resources.rockEmpty;
                btnRock.Enabled = false;
            }
            if (paperMoves == 0)
            {
                btnPaper.Image = Properties.Resources.paperEmpty;
                btnPaper.Enabled = false;
            }
            if (scissorMoves == 0)
            {
                btnScissor.Image = Properties.Resources.scissorsEmpty;
                btnScissor.Enabled = false;
            }
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            if (rockMoves > 0)
            {
                resetPositions();
                myMove = "Rock";
                btnPaper.Location = new Point(224, 578);
                btnScissor.Location = new Point(416, 578);

                rockMoves--;

                madeMove();
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            if (paperMoves > 0)
            {
                resetPositions();
                myMove = "Paper";
                btnRock.Location = new Point(32, 578);
                btnScissor.Location = new Point(416, 578);


                paperMoves--;

                madeMove();
            }
        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            if (scissorMoves > 0)
            {
                resetPositions();
                myMove = "Scissor";
                btnRock.Location = new Point(32, 578);
                btnPaper.Location = new Point(224, 578);

                scissorMoves--;

                madeMove();
            }
        }





        // Navigation

        private void btnRock_MouseEnter(object sender, EventArgs e)
        {
            if (rockMoves != 0)
            {
                btnRock.Image = Properties.Resources.rockHover;
            }
        }

        private void btnRock_MouseLeave(object sender, EventArgs e)
        {
            if (rockMoves != 0)
            {
                btnRock.Image = Properties.Resources.rock;
            }
        }

        private void btnPaper_MouseEnter(object sender, EventArgs e)
        {
            if (paperMoves != 0)
            {
                btnPaper.Image = Properties.Resources.paperHover;
            }
        }

        private void btnPaper_MouseLeave(object sender, EventArgs e)
        {
            if (paperMoves != 0)
            {
                btnPaper.Image = Properties.Resources.paper;
            }
        }

        private void btnScissor_MouseEnter(object sender, EventArgs e)
        {
            if (scissorMoves != 0)
            {
                btnScissor.Image = Properties.Resources.scissorsHover;
            }
        }

        private void btnScissor_MouseLeave(object sender, EventArgs e)
        {
            if (scissorMoves != 0)
            {
                btnScissor.Image = Properties.Resources.scissors;
            }
        }




        // Methods Here

        void enableButtons()
        {
            btnRock.Enabled = true;
            btnPaper.Enabled = true;
            btnScissor.Enabled = true;
        }

        void disableButtons()
        {
            btnRock.Enabled = false;
            btnPaper.Enabled = false;
            btnScissor.Enabled = false;
        }

        void resetPositions()
        {
            btnRock.Location = new Point(32, 459);
            btnPaper.Location = new Point(224, 459);
            btnScissor.Location = new Point(416, 459);
        }






        // Flow of Game Here

        void Start()
        {
            setEnemyCards.Enabled = true;
            disableButtons();
            turn = 0;
            yourScore = 0;
            enemyScore = 0;
            countdown = 11;

            myMove = null;
            enemyMove = null;
            flow1.Enabled = true;
        }

        private void setEnemyCards_Tick(object sender, EventArgs e)
        {
            int cardGenerator = rng.Next(1, 4);
            switch (cardGenerator)
            {
                case 1:
                    enemyRock++;
                    break;
                case 2:
                    enemyPaper++;
                    break;
                case 3:
                    enemyScissor++;
                    break;
            }

            if (enemyRock + enemyPaper + enemyScissor == 10)
            {
                setEnemyCards.Enabled = false;
            }
        }

        // Game will start in 3.. 2.. 1..

        public int countdown = 11;

        private void flow1_Tick(object sender, EventArgs e)
        {
            countdown--;
            disableButtons();
            announcement.Show();
            lblAnnouncement.Text = $"Game will start in {countdown}...";

            if (countdown <= 0 && enemyRock + enemyPaper + enemyScissor == 10)
            {
                flow1.Enabled = false;
                turn++;
                yourTurn();

            }
        }

        void yourTurn()
        {
            resetPositions();
            lblAnnouncement.Text = "YOUR TURN";
            enableButtons();
        }

        void madeMove()
        {
            disableButtons();
            countdown = 3;
            flow2.Enabled = true;
        }

        private void flow2_Tick(object sender, EventArgs e)
        {
            countdown--;
            lblAnnouncement.Text = $"You Chosed {myMove}";

            if (countdown <= 0)
            {
                flow2.Enabled = false;
                countdown = 2;
                makeEnemyMove();
                flow3.Enabled = true;
            }
        }

        void makeEnemyMove()
        {
            int enemyDecision = rng.Next(1, 4);
            switch (enemyDecision)
            {
                case 1:
                    if (enemyRock <= 0)
                    {
                        makeEnemyMove();
                    }
                    else
                    {
                        enemyMove = "Rock";
                        enemyCard.Image = Properties.Resources.rock;
                        enemyRock--;
                    }
                    break;
                case 2:
                    if (enemyPaper <= 0)
                    {
                        makeEnemyMove();
                    }
                    else
                    {
                        enemyMove = "Paper";
                        enemyCard.Image = Properties.Resources.paper;
                        enemyPaper--;
                    }
                    break;
                case 3:
                    if (enemyScissor <= 0)
                    {
                        makeEnemyMove();
                    }
                    else
                    {
                        enemyMove = "Scissor";
                        enemyCard.Image = Properties.Resources.scissors;
                        enemyScissor--;
                    }
                    break;
            }
        }

        private void flow3_Tick(object sender, EventArgs e)
        {
            countdown--;
            lblAnnouncement.Text = "Enemy is thinking. . .";



            if (countdown <= 0 && enemyMove != null)
            {
                flow3.Enabled = false;
                countdown = 3;
                flow4.Enabled = true;
            }
            if (countdown <= 0 && enemyMove == null)
            {
                countdown = 2;
            }
        }

        private void flow4_Tick(object sender, EventArgs e)
        {
            countdown--;
            lblAnnouncement.Text = $"Enemy Chosed {enemyMove}";
            enemyCard.Show();


            if (countdown <= 0)
            {
                flow4.Enabled = false;
                evaluateResult();
            }
        }

        void evaluateResult()
        {
            if (myMove == "Rock" && enemyMove == "Rock")
            {
                result = "DRAW";
            }
            if (myMove == "Paper" && enemyMove == "Paper")
            {
                result = "DRAW";
            }
            if (myMove == "Scissor" && enemyMove == "Scissor")
            {
                result = "DRAW";
            }



            if (myMove == "Rock" && enemyMove == "Paper")
            {
                result = "YOU LOSE";
            }
            if (myMove == "Rock" && enemyMove == "Scissor")
            {
                result = "YOU WIN";
            }



            if (myMove == "Paper" && enemyMove == "Rock")
            {
                result = "YOU WIN";
            }
            if (myMove == "Paper" && enemyMove == "Scissor")
            {
                result = "YOU LOSE";
            }



            if (myMove == "Scissor" && enemyMove == "Rock")
            {
                result = "YOU LOSE";
            }
            if (myMove == "Scissor" && enemyMove == "Paper")
            {
                result = "YOU WIN";
            }

            lblAnnouncement.Text = $"{result}!";

            turn++;
            if (result == "YOU WIN")
            {
                yourScore++;
                announcement.BackColor = Color.Green;
            }
            if (result == "YOU LOSE")
            {
                enemyScore++;
                announcement.BackColor = Color.Red;
            }
            if (result == "DRAW")
            {
                announcement.BackColor = Color.FromArgb(107, 112, 92);
            }

            countdown = 5;
            flow5.Enabled = true;
        }

        private void flow5_Tick(object sender, EventArgs e)
        {
            countdown--;
            lblAnnouncement.Text = $"{result}!";



            if (countdown <= 0)
            {
                if (rockMoves + paperMoves + scissorMoves != 0)
                {
                    flow5.Enabled = false;
                    announcement.BackColor = Color.FromArgb(238, 186, 61);
                    enemyCard.Hide();
                    yourTurn();
                }
                else
                {
                    flow5.Enabled = false;
                    //Game Over
                    if (yourScore > enemyScore)
                    {
                        File.WriteAllText("singlePlayer.ini", $"YOU WIN\n{yourScore} - {enemyScore}");
                    }
                    if (yourScore < enemyScore)
                    {
                        File.WriteAllText("singlePlayer.ini", $"YOU LOSE\n{yourScore} - {enemyScore}");
                    }
                    if (yourScore == enemyScore)
                    {
                        File.WriteAllText("singlePlayer.ini", $"DRAW\n{yourScore} - {enemyScore}");
                    }

                    gameOver go = new gameOver();
                    go.Show();
                    this.Hide();
                }
            }
        }
    }
}
