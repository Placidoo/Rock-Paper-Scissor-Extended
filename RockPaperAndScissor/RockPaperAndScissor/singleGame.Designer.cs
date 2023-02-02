
namespace RockPaperAndScissor
{
    partial class singleGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblScissor = new System.Windows.Forms.Label();
            this.lblPaper = new System.Windows.Forms.Label();
            this.lblRock = new System.Windows.Forms.Label();
            this.scoreUpdater = new System.Windows.Forms.Timer(this.components);
            this.btnRock = new System.Windows.Forms.PictureBox();
            this.btnPaper = new System.Windows.Forms.PictureBox();
            this.btnScissor = new System.Windows.Forms.PictureBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.lblEnemyScore = new System.Windows.Forms.Label();
            this.announcement = new System.Windows.Forms.Panel();
            this.flow1 = new System.Windows.Forms.Timer(this.components);
            this.lblAnnouncement = new System.Windows.Forms.Label();
            this.flow2 = new System.Windows.Forms.Timer(this.components);
            this.flow3 = new System.Windows.Forms.Timer(this.components);
            this.setEnemyCards = new System.Windows.Forms.Timer(this.components);
            this.flow4 = new System.Windows.Forms.Timer(this.components);
            this.flow5 = new System.Windows.Forms.Timer(this.components);
            this.enemyCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScissor)).BeginInit();
            this.announcement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScissor
            // 
            this.lblScissor.BackColor = System.Drawing.Color.Transparent;
            this.lblScissor.Font = new System.Drawing.Font("OMORI_GAME", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScissor.ForeColor = System.Drawing.Color.Black;
            this.lblScissor.Location = new System.Drawing.Point(72, 136);
            this.lblScissor.Name = "lblScissor";
            this.lblScissor.Size = new System.Drawing.Size(100, 40);
            this.lblScissor.TabIndex = 1;
            this.lblScissor.Text = "x10";
            this.lblScissor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaper
            // 
            this.lblPaper.BackColor = System.Drawing.Color.Transparent;
            this.lblPaper.Font = new System.Drawing.Font("OMORI_GAME", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaper.ForeColor = System.Drawing.Color.Black;
            this.lblPaper.Location = new System.Drawing.Point(72, 80);
            this.lblPaper.Name = "lblPaper";
            this.lblPaper.Size = new System.Drawing.Size(100, 40);
            this.lblPaper.TabIndex = 2;
            this.lblPaper.Text = "x10";
            this.lblPaper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRock
            // 
            this.lblRock.BackColor = System.Drawing.Color.Transparent;
            this.lblRock.Font = new System.Drawing.Font("OMORI_GAME", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRock.ForeColor = System.Drawing.Color.Black;
            this.lblRock.Location = new System.Drawing.Point(72, 24);
            this.lblRock.Name = "lblRock";
            this.lblRock.Size = new System.Drawing.Size(100, 40);
            this.lblRock.TabIndex = 3;
            this.lblRock.Text = "x10";
            this.lblRock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scoreUpdater
            // 
            this.scoreUpdater.Enabled = true;
            this.scoreUpdater.Tick += new System.EventHandler(this.scoreUpdater_Tick);
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.Transparent;
            this.btnRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRock.Image = global::RockPaperAndScissor.Properties.Resources.rock;
            this.btnRock.Location = new System.Drawing.Point(32, 459);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(195, 265);
            this.btnRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnRock.TabIndex = 4;
            this.btnRock.TabStop = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            this.btnRock.MouseEnter += new System.EventHandler(this.btnRock_MouseEnter);
            this.btnRock.MouseLeave += new System.EventHandler(this.btnRock_MouseLeave);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.Transparent;
            this.btnPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaper.Image = global::RockPaperAndScissor.Properties.Resources.paper;
            this.btnPaper.Location = new System.Drawing.Point(224, 459);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(195, 265);
            this.btnPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPaper.TabIndex = 4;
            this.btnPaper.TabStop = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            this.btnPaper.MouseEnter += new System.EventHandler(this.btnPaper_MouseEnter);
            this.btnPaper.MouseLeave += new System.EventHandler(this.btnPaper_MouseLeave);
            // 
            // btnScissor
            // 
            this.btnScissor.BackColor = System.Drawing.Color.Transparent;
            this.btnScissor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScissor.Image = global::RockPaperAndScissor.Properties.Resources.scissors;
            this.btnScissor.Location = new System.Drawing.Point(416, 459);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(195, 265);
            this.btnScissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnScissor.TabIndex = 4;
            this.btnScissor.TabStop = false;
            this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
            this.btnScissor.MouseEnter += new System.EventHandler(this.btnScissor_MouseEnter);
            this.btnScissor.MouseLeave += new System.EventHandler(this.btnScissor_MouseLeave);
            // 
            // lblTurn
            // 
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("KG Crossing A Line", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(488, 48);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(152, 32);
            this.lblTurn.TabIndex = 5;
            this.lblTurn.Text = "0";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYourScore
            // 
            this.lblYourScore.BackColor = System.Drawing.Color.Transparent;
            this.lblYourScore.Font = new System.Drawing.Font("KG Crossing A Line", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourScore.ForeColor = System.Drawing.Color.White;
            this.lblYourScore.Location = new System.Drawing.Point(488, 120);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(152, 32);
            this.lblYourScore.TabIndex = 5;
            this.lblYourScore.Text = "0";
            this.lblYourScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnemyScore
            // 
            this.lblEnemyScore.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyScore.Font = new System.Drawing.Font("KG Crossing A Line", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyScore.ForeColor = System.Drawing.Color.White;
            this.lblEnemyScore.Location = new System.Drawing.Point(488, 200);
            this.lblEnemyScore.Name = "lblEnemyScore";
            this.lblEnemyScore.Size = new System.Drawing.Size(152, 32);
            this.lblEnemyScore.TabIndex = 5;
            this.lblEnemyScore.Text = "0";
            this.lblEnemyScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // announcement
            // 
            this.announcement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(186)))), ((int)(((byte)(61)))));
            this.announcement.Controls.Add(this.lblAnnouncement);
            this.announcement.Location = new System.Drawing.Point(0, 272);
            this.announcement.Name = "announcement";
            this.announcement.Size = new System.Drawing.Size(642, 112);
            this.announcement.TabIndex = 6;
            this.announcement.Visible = false;
            // 
            // flow1
            // 
            this.flow1.Interval = 1000;
            this.flow1.Tick += new System.EventHandler(this.flow1_Tick);
            // 
            // lblAnnouncement
            // 
            this.lblAnnouncement.BackColor = System.Drawing.Color.Transparent;
            this.lblAnnouncement.Font = new System.Drawing.Font("KG Crossing A Line", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnouncement.Location = new System.Drawing.Point(0, 0);
            this.lblAnnouncement.Name = "lblAnnouncement";
            this.lblAnnouncement.Size = new System.Drawing.Size(640, 112);
            this.lblAnnouncement.TabIndex = 0;
            this.lblAnnouncement.Text = "lblAnnouncement";
            this.lblAnnouncement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flow2
            // 
            this.flow2.Interval = 1000;
            this.flow2.Tick += new System.EventHandler(this.flow2_Tick);
            // 
            // flow3
            // 
            this.flow3.Interval = 1000;
            this.flow3.Tick += new System.EventHandler(this.flow3_Tick);
            // 
            // setEnemyCards
            // 
            this.setEnemyCards.Tick += new System.EventHandler(this.setEnemyCards_Tick);
            // 
            // flow4
            // 
            this.flow4.Interval = 1000;
            this.flow4.Tick += new System.EventHandler(this.flow4_Tick);
            // 
            // flow5
            // 
            this.flow5.Interval = 1000;
            this.flow5.Tick += new System.EventHandler(this.flow5_Tick);
            // 
            // enemyCard
            // 
            this.enemyCard.BackColor = System.Drawing.Color.Transparent;
            this.enemyCard.Image = global::RockPaperAndScissor.Properties.Resources.rock;
            this.enemyCard.Location = new System.Drawing.Point(224, 8);
            this.enemyCard.Name = "enemyCard";
            this.enemyCard.Size = new System.Drawing.Size(195, 265);
            this.enemyCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyCard.TabIndex = 7;
            this.enemyCard.TabStop = false;
            this.enemyCard.Visible = false;
            // 
            // singleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RockPaperAndScissor.Properties.Resources.singleGame;
            this.ClientSize = new System.Drawing.Size(641, 744);
            this.Controls.Add(this.enemyCard);
            this.Controls.Add(this.announcement);
            this.Controls.Add(this.lblEnemyScore);
            this.Controls.Add(this.lblYourScore);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.lblScissor);
            this.Controls.Add(this.lblPaper);
            this.Controls.Add(this.lblRock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "singleGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.singleGame_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.btnRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScissor)).EndInit();
            this.announcement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enemyCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScissor;
        private System.Windows.Forms.Label lblPaper;
        private System.Windows.Forms.Label lblRock;
        private System.Windows.Forms.Timer scoreUpdater;
        private System.Windows.Forms.PictureBox btnRock;
        private System.Windows.Forms.PictureBox btnPaper;
        private System.Windows.Forms.PictureBox btnScissor;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.Label lblEnemyScore;
        private System.Windows.Forms.Panel announcement;
        private System.Windows.Forms.Timer flow1;
        private System.Windows.Forms.Label lblAnnouncement;
        private System.Windows.Forms.Timer flow2;
        private System.Windows.Forms.Timer flow3;
        private System.Windows.Forms.Timer setEnemyCards;
        private System.Windows.Forms.Timer flow4;
        private System.Windows.Forms.Timer flow5;
        private System.Windows.Forms.PictureBox enemyCard;
    }
}