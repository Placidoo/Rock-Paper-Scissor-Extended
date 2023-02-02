
namespace RockPaperAndScissor
{
    partial class singleDrawCard
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
            this.drawingCard = new System.Windows.Forms.Timer(this.components);
            this.movesPanel = new System.Windows.Forms.Panel();
            this.btnProceed = new System.Windows.Forms.Label();
            this.lblScissor = new System.Windows.Forms.Label();
            this.lblPaper = new System.Windows.Forms.Label();
            this.lblRock = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.PictureBox();
            this.btnDrawCard = new System.Windows.Forms.PictureBox();
            this.movesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrawCard)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingCard
            // 
            this.drawingCard.Interval = 1000;
            this.drawingCard.Tick += new System.EventHandler(this.drawingCard_Tick);
            // 
            // movesPanel
            // 
            this.movesPanel.BackgroundImage = global::RockPaperAndScissor.Properties.Resources.movesPanel;
            this.movesPanel.Controls.Add(this.btnProceed);
            this.movesPanel.Controls.Add(this.lblScissor);
            this.movesPanel.Controls.Add(this.lblPaper);
            this.movesPanel.Controls.Add(this.lblRock);
            this.movesPanel.Location = new System.Drawing.Point(78, 125);
            this.movesPanel.Name = "movesPanel";
            this.movesPanel.Size = new System.Drawing.Size(487, 496);
            this.movesPanel.TabIndex = 3;
            this.movesPanel.Visible = false;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.Transparent;
            this.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProceed.Location = new System.Drawing.Point(336, 424);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(112, 23);
            this.btnProceed.TabIndex = 1;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // lblScissor
            // 
            this.lblScissor.BackColor = System.Drawing.Color.Transparent;
            this.lblScissor.Font = new System.Drawing.Font("OMORI_GAME", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScissor.ForeColor = System.Drawing.Color.White;
            this.lblScissor.Location = new System.Drawing.Point(248, 288);
            this.lblScissor.Name = "lblScissor";
            this.lblScissor.Size = new System.Drawing.Size(100, 40);
            this.lblScissor.TabIndex = 0;
            this.lblScissor.Text = "x10";
            this.lblScissor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaper
            // 
            this.lblPaper.BackColor = System.Drawing.Color.Transparent;
            this.lblPaper.Font = new System.Drawing.Font("OMORI_GAME", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaper.ForeColor = System.Drawing.Color.White;
            this.lblPaper.Location = new System.Drawing.Point(248, 232);
            this.lblPaper.Name = "lblPaper";
            this.lblPaper.Size = new System.Drawing.Size(100, 40);
            this.lblPaper.TabIndex = 0;
            this.lblPaper.Text = "x10";
            this.lblPaper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRock
            // 
            this.lblRock.BackColor = System.Drawing.Color.Transparent;
            this.lblRock.Font = new System.Drawing.Font("OMORI_GAME", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRock.ForeColor = System.Drawing.Color.White;
            this.lblRock.Location = new System.Drawing.Point(248, 176);
            this.lblRock.Name = "lblRock";
            this.lblRock.Size = new System.Drawing.Size(100, 40);
            this.lblRock.TabIndex = 0;
            this.lblRock.Text = "x10";
            this.lblRock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReturn
            // 
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Image = global::RockPaperAndScissor.Properties.Resources.miniReturn;
            this.btnReturn.Location = new System.Drawing.Point(488, 20);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(153, 69);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnReturn.TabIndex = 1;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDrawCard
            // 
            this.btnDrawCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrawCard.Image = global::RockPaperAndScissor.Properties.Resources.drawCard1;
            this.btnDrawCard.Location = new System.Drawing.Point(224, 203);
            this.btnDrawCard.Name = "btnDrawCard";
            this.btnDrawCard.Size = new System.Drawing.Size(195, 346);
            this.btnDrawCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDrawCard.TabIndex = 0;
            this.btnDrawCard.TabStop = false;
            this.btnDrawCard.Click += new System.EventHandler(this.btnDrawCard_Click);
            this.btnDrawCard.MouseEnter += new System.EventHandler(this.btnDrawCard_MouseEnter);
            this.btnDrawCard.MouseLeave += new System.EventHandler(this.btnDrawCard_MouseLeave);
            // 
            // singleDrawCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 744);
            this.Controls.Add(this.movesPanel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDrawCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "singleDrawCard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.singleDrawCard_FormClosed);
            this.movesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDrawCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnDrawCard;
        private System.Windows.Forms.PictureBox btnReturn;
        private System.Windows.Forms.Timer drawingCard;
        private System.Windows.Forms.Panel movesPanel;
        private System.Windows.Forms.Label lblScissor;
        private System.Windows.Forms.Label lblPaper;
        private System.Windows.Forms.Label lblRock;
        private System.Windows.Forms.Label btnProceed;
    }
}