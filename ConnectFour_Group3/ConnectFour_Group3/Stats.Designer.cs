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
            this.SuspendLayout();
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWins.Location = new System.Drawing.Point(134, 87);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(195, 36);
            this.lblPlayerWins.TabIndex = 0;
            this.lblPlayerWins.Text = "Player Wins:";
            // 
            // lblPlayerwinper
            // 
            this.lblPlayerwinper.AutoSize = true;
            this.lblPlayerwinper.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerwinper.Location = new System.Drawing.Point(134, 226);
            this.lblPlayerwinper.Name = "lblPlayerwinper";
            this.lblPlayerwinper.Size = new System.Drawing.Size(216, 36);
            this.lblPlayerwinper.TabIndex = 1;
            this.lblPlayerwinper.Text = "Player Win %:";
            // 
            // lblAIwins
            // 
            this.lblAIwins.AutoSize = true;
            this.lblAIwins.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIwins.Location = new System.Drawing.Point(860, 87);
            this.lblAIwins.Name = "lblAIwins";
            this.lblAIwins.Size = new System.Drawing.Size(136, 36);
            this.lblAIwins.TabIndex = 2;
            this.lblAIwins.Text = "AI Wins:";
            // 
            // lblAIwinper
            // 
            this.lblAIwinper.AutoSize = true;
            this.lblAIwinper.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIwinper.Location = new System.Drawing.Point(860, 226);
            this.lblAIwinper.Name = "lblAIwinper";
            this.lblAIwinper.Size = new System.Drawing.Size(157, 36);
            this.lblAIwinper.TabIndex = 3;
            this.lblAIwinper.Text = "AI Win %:";
            // 
            // ctrPlayerWins
            // 
            this.ctrPlayerWins.AutoSize = true;
            this.ctrPlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPlayerWins.Location = new System.Drawing.Point(376, 87);
            this.ctrPlayerWins.Name = "ctrPlayerWins";
            this.ctrPlayerWins.Size = new System.Drawing.Size(32, 36);
            this.ctrPlayerWins.TabIndex = 4;
            this.ctrPlayerWins.Text = "0";
            // 
            // ctrPlayerWinPer
            // 
            this.ctrPlayerWinPer.AutoSize = true;
            this.ctrPlayerWinPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPlayerWinPer.Location = new System.Drawing.Point(376, 226);
            this.ctrPlayerWinPer.Name = "ctrPlayerWinPer";
            this.ctrPlayerWinPer.Size = new System.Drawing.Size(32, 36);
            this.ctrPlayerWinPer.TabIndex = 5;
            this.ctrPlayerWinPer.Text = "0";
            // 
            // ctrAIWins
            // 
            this.ctrAIWins.AutoSize = true;
            this.ctrAIWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrAIWins.Location = new System.Drawing.Point(1036, 87);
            this.ctrAIWins.Name = "ctrAIWins";
            this.ctrAIWins.Size = new System.Drawing.Size(32, 36);
            this.ctrAIWins.TabIndex = 6;
            this.ctrAIWins.Text = "0";
            // 
            // ctrAIWinPer
            // 
            this.ctrAIWinPer.AutoSize = true;
            this.ctrAIWinPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrAIWinPer.Location = new System.Drawing.Point(1036, 243);
            this.ctrAIWinPer.Name = "ctrAIWinPer";
            this.ctrAIWinPer.Size = new System.Drawing.Size(32, 36);
            this.ctrAIWinPer.TabIndex = 7;
            this.ctrAIWinPer.Text = "0";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 830);
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
    }
}