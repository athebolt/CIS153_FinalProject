namespace ConnectFour_Group3
{
    partial class GameOver
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_go_whoWon = new System.Windows.Forms.Label();
            this.btn_go_playAgain = new System.Windows.Forms.Button();
            this.btn_go_review = new System.Windows.Forms.Button();
            this.btn_go_exit = new System.Windows.Forms.Button();
            this.lbl_go_playerWins = new System.Windows.Forms.Label();
            this.lbl_go_AIWins = new System.Windows.Forms.Label();
            this.lbl_go_playerWinP = new System.Windows.Forms.Label();
            this.lbl_go_AIWinP = new System.Windows.Forms.Label();
            this.lbl_go_totalGames = new System.Windows.Forms.Label();
            this.lbl_go_ties = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over";
            // 
            // lbl_go_whoWon
            // 
            this.lbl_go_whoWon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_go_whoWon.AutoSize = true;
            this.lbl_go_whoWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_go_whoWon.Location = new System.Drawing.Point(305, 108);
            this.lbl_go_whoWon.Name = "lbl_go_whoWon";
            this.lbl_go_whoWon.Size = new System.Drawing.Size(191, 31);
            this.lbl_go_whoWon.TabIndex = 1;
            this.lbl_go_whoWon.Text = "AI Player Wins";
            this.lbl_go_whoWon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_go_playAgain
            // 
            this.btn_go_playAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_go_playAgain.Location = new System.Drawing.Point(62, 358);
            this.btn_go_playAgain.Name = "btn_go_playAgain";
            this.btn_go_playAgain.Size = new System.Drawing.Size(191, 54);
            this.btn_go_playAgain.TabIndex = 2;
            this.btn_go_playAgain.Text = "Play Again?";
            this.btn_go_playAgain.UseVisualStyleBackColor = true;
            this.btn_go_playAgain.Click += new System.EventHandler(this.btn_go_playAgain_Click);
            // 
            // btn_go_review
            // 
            this.btn_go_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_go_review.Location = new System.Drawing.Point(302, 358);
            this.btn_go_review.Name = "btn_go_review";
            this.btn_go_review.Size = new System.Drawing.Size(191, 54);
            this.btn_go_review.TabIndex = 3;
            this.btn_go_review.Text = "Review Board";
            this.btn_go_review.UseVisualStyleBackColor = true;
            this.btn_go_review.Click += new System.EventHandler(this.btn_go_review_Click);
            // 
            // btn_go_exit
            // 
            this.btn_go_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_go_exit.Location = new System.Drawing.Point(542, 358);
            this.btn_go_exit.Name = "btn_go_exit";
            this.btn_go_exit.Size = new System.Drawing.Size(191, 54);
            this.btn_go_exit.TabIndex = 4;
            this.btn_go_exit.Text = "Exit to Title";
            this.btn_go_exit.UseVisualStyleBackColor = true;
            this.btn_go_exit.Click += new System.EventHandler(this.btn_go_exit_Click);
            // 
            // lbl_go_playerWins
            // 
            this.lbl_go_playerWins.AutoSize = true;
            this.lbl_go_playerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_go_playerWins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(147)))), ((int)(((byte)(202)))));
            this.lbl_go_playerWins.Location = new System.Drawing.Point(41, 214);
            this.lbl_go_playerWins.Name = "lbl_go_playerWins";
            this.lbl_go_playerWins.Size = new System.Drawing.Size(114, 24);
            this.lbl_go_playerWins.TabIndex = 5;
            this.lbl_go_playerWins.Text = "Player Wins:";
            this.lbl_go_playerWins.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_go_playerWins.Visible = false;
            // 
            // lbl_go_AIWins
            // 
            this.lbl_go_AIWins.AutoSize = true;
            this.lbl_go_AIWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_go_AIWins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.lbl_go_AIWins.Location = new System.Drawing.Point(545, 214);
            this.lbl_go_AIWins.Name = "lbl_go_AIWins";
            this.lbl_go_AIWins.Size = new System.Drawing.Size(79, 24);
            this.lbl_go_AIWins.TabIndex = 6;
            this.lbl_go_AIWins.Text = "AI Wins:";
            this.lbl_go_AIWins.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_go_AIWins.Visible = false;
            // 
            // lbl_go_playerWinP
            // 
            this.lbl_go_playerWinP.AutoSize = true;
            this.lbl_go_playerWinP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_go_playerWinP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(147)))), ((int)(((byte)(202)))));
            this.lbl_go_playerWinP.Location = new System.Drawing.Point(41, 283);
            this.lbl_go_playerWinP.Name = "lbl_go_playerWinP";
            this.lbl_go_playerWinP.Size = new System.Drawing.Size(190, 24);
            this.lbl_go_playerWinP.TabIndex = 7;
            this.lbl_go_playerWinP.Text = "Player Win %: 00.00%";
            this.lbl_go_playerWinP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_go_playerWinP.Visible = false;
            // 
            // lbl_go_AIWinP
            // 
            this.lbl_go_AIWinP.AutoSize = true;
            this.lbl_go_AIWinP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_go_AIWinP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.lbl_go_AIWinP.Location = new System.Drawing.Point(545, 283);
            this.lbl_go_AIWinP.Name = "lbl_go_AIWinP";
            this.lbl_go_AIWinP.Size = new System.Drawing.Size(155, 24);
            this.lbl_go_AIWinP.TabIndex = 8;
            this.lbl_go_AIWinP.Text = "AI Win %: 00.00%";
            this.lbl_go_AIWinP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_go_AIWinP.Visible = false;
            // 
            // lbl_go_totalGames
            // 
            this.lbl_go_totalGames.AutoSize = true;
            this.lbl_go_totalGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_go_totalGames.Location = new System.Drawing.Point(308, 214);
            this.lbl_go_totalGames.Name = "lbl_go_totalGames";
            this.lbl_go_totalGames.Size = new System.Drawing.Size(121, 24);
            this.lbl_go_totalGames.TabIndex = 9;
            this.lbl_go_totalGames.Text = "Total Games:";
            this.lbl_go_totalGames.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_go_totalGames.Visible = false;
            // 
            // lbl_go_ties
            // 
            this.lbl_go_ties.AutoSize = true;
            this.lbl_go_ties.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_go_ties.Location = new System.Drawing.Point(308, 283);
            this.lbl_go_ties.Name = "lbl_go_ties";
            this.lbl_go_ties.Size = new System.Drawing.Size(51, 24);
            this.lbl_go_ties.TabIndex = 10;
            this.lbl_go_ties.Text = "Ties:";
            this.lbl_go_ties.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_go_ties.Visible = false;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_go_ties);
            this.Controls.Add(this.lbl_go_totalGames);
            this.Controls.Add(this.lbl_go_AIWinP);
            this.Controls.Add(this.lbl_go_playerWinP);
            this.Controls.Add(this.lbl_go_AIWins);
            this.Controls.Add(this.lbl_go_playerWins);
            this.Controls.Add(this.btn_go_exit);
            this.Controls.Add(this.btn_go_review);
            this.Controls.Add(this.btn_go_playAgain);
            this.Controls.Add(this.lbl_go_whoWon);
            this.Controls.Add(this.label1);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameOver_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_go_whoWon;
        private System.Windows.Forms.Button btn_go_playAgain;
        private System.Windows.Forms.Button btn_go_review;
        private System.Windows.Forms.Button btn_go_exit;
        private System.Windows.Forms.Label lbl_go_playerWins;
        private System.Windows.Forms.Label lbl_go_AIWins;
        private System.Windows.Forms.Label lbl_go_playerWinP;
        private System.Windows.Forms.Label lbl_go_AIWinP;
        private System.Windows.Forms.Label lbl_go_totalGames;
        private System.Windows.Forms.Label lbl_go_ties;
    }
}