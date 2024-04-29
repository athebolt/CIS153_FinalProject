namespace ConnectFour_Group3
{
    partial class Stats
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
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblPlayerwinper = new System.Windows.Forms.Label();
            this.lblAIwins = new System.Windows.Forms.Label();
            this.lblAIwinper = new System.Windows.Forms.Label();
            this.ctrPlayerWins = new System.Windows.Forms.Label();
            this.ctrPlayerWinPer = new System.Windows.Forms.Label();
            this.ctrAIWins = new System.Windows.Forms.Label();
            this.ctrAIWinPer = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblTotalGames = new System.Windows.Forms.Label();
            this.ctrTotalGames = new System.Windows.Forms.Label();
            this.ctrTies = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWins.Location = new System.Drawing.Point(184, 243);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(195, 36);
            this.lblPlayerWins.TabIndex = 0;
            this.lblPlayerWins.Text = "Player Wins:";
            // 
            // lblPlayerwinper
            // 
            this.lblPlayerwinper.AutoSize = true;
            this.lblPlayerwinper.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerwinper.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerwinper.Location = new System.Drawing.Point(184, 379);
            this.lblPlayerwinper.Name = "lblPlayerwinper";
            this.lblPlayerwinper.Size = new System.Drawing.Size(230, 37);
            this.lblPlayerwinper.TabIndex = 1;
            this.lblPlayerwinper.Text = "Player Win %:";
            // 
            // lblAIwins
            // 
            this.lblAIwins.AutoSize = true;
            this.lblAIwins.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIwins.Location = new System.Drawing.Point(846, 246);
            this.lblAIwins.Name = "lblAIwins";
            this.lblAIwins.Size = new System.Drawing.Size(136, 36);
            this.lblAIwins.TabIndex = 2;
            this.lblAIwins.Text = "AI Wins:";
            // 
            // lblAIwinper
            // 
            this.lblAIwinper.AutoSize = true;
            this.lblAIwinper.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIwinper.ForeColor = System.Drawing.Color.Green;
            this.lblAIwinper.Location = new System.Drawing.Point(846, 381);
            this.lblAIwinper.Name = "lblAIwinper";
            this.lblAIwinper.Size = new System.Drawing.Size(167, 37);
            this.lblAIwinper.TabIndex = 3;
            this.lblAIwinper.Text = "AI Win %:";
            // 
            // ctrPlayerWins
            // 
            this.ctrPlayerWins.AutoSize = true;
            this.ctrPlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPlayerWins.Location = new System.Drawing.Point(385, 243);
            this.ctrPlayerWins.Name = "ctrPlayerWins";
            this.ctrPlayerWins.Size = new System.Drawing.Size(32, 36);
            this.ctrPlayerWins.TabIndex = 4;
            this.ctrPlayerWins.Text = "0";
            // 
            // ctrPlayerWinPer
            // 
            this.ctrPlayerWinPer.AutoSize = true;
            this.ctrPlayerWinPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPlayerWinPer.ForeColor = System.Drawing.Color.Red;
            this.ctrPlayerWinPer.Location = new System.Drawing.Point(407, 380);
            this.ctrPlayerWinPer.Name = "ctrPlayerWinPer";
            this.ctrPlayerWinPer.Size = new System.Drawing.Size(36, 37);
            this.ctrPlayerWinPer.TabIndex = 5;
            this.ctrPlayerWinPer.Text = "0";
            // 
            // ctrAIWins
            // 
            this.ctrAIWins.AutoSize = true;
            this.ctrAIWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrAIWins.Location = new System.Drawing.Point(988, 246);
            this.ctrAIWins.Name = "ctrAIWins";
            this.ctrAIWins.Size = new System.Drawing.Size(32, 36);
            this.ctrAIWins.TabIndex = 6;
            this.ctrAIWins.Text = "0";
            // 
            // ctrAIWinPer
            // 
            this.ctrAIWinPer.AutoSize = true;
            this.ctrAIWinPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrAIWinPer.ForeColor = System.Drawing.Color.Green;
            this.ctrAIWinPer.Location = new System.Drawing.Point(1005, 382);
            this.ctrAIWinPer.Name = "ctrAIWinPer";
            this.ctrAIWinPer.Size = new System.Drawing.Size(36, 37);
            this.ctrAIWinPer.TabIndex = 7;
            this.ctrAIWinPer.Text = "0";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 568);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTotalGames
            // 
            this.lblTotalGames.AutoSize = true;
            this.lblTotalGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGames.Location = new System.Drawing.Point(518, 243);
            this.lblTotalGames.Name = "lblTotalGames";
            this.lblTotalGames.Size = new System.Drawing.Size(211, 36);
            this.lblTotalGames.TabIndex = 9;
            this.lblTotalGames.Text = "Total Games :";
            // 
            // ctrTotalGames
            // 
            this.ctrTotalGames.AutoSize = true;
            this.ctrTotalGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrTotalGames.Location = new System.Drawing.Point(734, 244);
            this.ctrTotalGames.Name = "ctrTotalGames";
            this.ctrTotalGames.Size = new System.Drawing.Size(32, 36);
            this.ctrTotalGames.TabIndex = 10;
            this.ctrTotalGames.Text = "0";
            // 
            // ctrTies
            // 
            this.ctrTies.AutoSize = true;
            this.ctrTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrTies.Location = new System.Drawing.Point(665, 382);
            this.ctrTies.Name = "ctrTies";
            this.ctrTies.Size = new System.Drawing.Size(32, 36);
            this.ctrTies.TabIndex = 12;
            this.ctrTies.Text = "0";
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTies.Location = new System.Drawing.Point(566, 381);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(93, 36);
            this.lblTies.TabIndex = 11;
            this.lblTies.Text = "Ties :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(443, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 63);
            this.label1.TabIndex = 14;
            this.label1.Text = "GAME STATS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ties :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(670, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "0";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrTies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTies);
            this.Controls.Add(this.ctrTotalGames);
            this.Controls.Add(this.lblTotalGames);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ctrAIWinPer);
            this.Controls.Add(this.ctrAIWins);
            this.Controls.Add(this.ctrPlayerWinPer);
            this.Controls.Add(this.ctrPlayerWins);
            this.Controls.Add(this.lblAIwinper);
            this.Controls.Add(this.lblAIwins);
            this.Controls.Add(this.lblPlayerwinper);
            this.Controls.Add(this.lblPlayerWins);
            this.Name = "Stats";
            this.Text = "Stats";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Stats_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblPlayerwinper;
        private System.Windows.Forms.Label lblAIwins;
        private System.Windows.Forms.Label lblAIwinper;
        private System.Windows.Forms.Label ctrPlayerWins;
        private System.Windows.Forms.Label ctrPlayerWinPer;
        private System.Windows.Forms.Label ctrAIWins;
        private System.Windows.Forms.Label ctrAIWinPer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTotalGames;
        private System.Windows.Forms.Label ctrTotalGames;
        private System.Windows.Forms.Label ctrTies;
        private System.Windows.Forms.Label lblTies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}