
namespace RockPaperAndScissor
{
    partial class gameOver
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
            this.gameOverMenu = new System.Windows.Forms.Panel();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.lblPlayAgain = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.gameOverMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameOverMenu
            // 
            this.gameOverMenu.BackgroundImage = global::RockPaperAndScissor.Properties.Resources.panel;
            this.gameOverMenu.Controls.Add(this.lblMainMenu);
            this.gameOverMenu.Controls.Add(this.lblPlayAgain);
            this.gameOverMenu.Controls.Add(this.lblScore);
            this.gameOverMenu.Controls.Add(this.lblResult);
            this.gameOverMenu.Location = new System.Drawing.Point(78, 125);
            this.gameOverMenu.Name = "gameOverMenu";
            this.gameOverMenu.Size = new System.Drawing.Size(487, 496);
            this.gameOverMenu.TabIndex = 0;
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMainMenu.Font = new System.Drawing.Font("OMORI_GAME", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.Color.White;
            this.lblMainMenu.Location = new System.Drawing.Point(192, 384);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(104, 24);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMainMenu.Click += new System.EventHandler(this.lblMainMenu_Click);
            // 
            // lblPlayAgain
            // 
            this.lblPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlayAgain.Font = new System.Drawing.Font("OMORI_GAME", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayAgain.ForeColor = System.Drawing.Color.White;
            this.lblPlayAgain.Location = new System.Drawing.Point(192, 336);
            this.lblPlayAgain.Name = "lblPlayAgain";
            this.lblPlayAgain.Size = new System.Drawing.Size(104, 24);
            this.lblPlayAgain.TabIndex = 0;
            this.lblPlayAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayAgain.Click += new System.EventHandler(this.lblPlayAgain_Click);
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("KG Crossing A Line", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Black;
            this.lblScore.Location = new System.Drawing.Point(0, 184);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(488, 88);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "8 - 6";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("KG Crossing A Line", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(0, 96);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(488, 88);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "YOU WIN/LOSE";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 744);
            this.Controls.Add(this.gameOverMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gameOver";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gameOver_FormClosed);
            this.gameOverMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameOverMenu;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Label lblPlayAgain;
        private System.Windows.Forms.Label lblScore;
    }
}