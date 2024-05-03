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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWins.Location = new System.Drawing.Point(229, 289);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(180, 33);
            this.lblPlayerWins.TabIndex = 0;
            this.lblPlayerWins.Text = "Player Wins:";
            // 
            // lblPlayerwinper
            // 
            this.lblPlayerwinper.AutoSize = true;
            this.lblPlayerwinper.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerwinper.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPlayerwinper.Location = new System.Drawing.Point(141, 421);
            this.lblPlayerwinper.Name = "lblPlayerwinper";
            this.lblPlayerwinper.Size = new System.Drawing.Size(199, 33);
            this.lblPlayerwinper.TabIndex = 1;
            this.lblPlayerwinper.Text = "Player Win %:";
            // 
            // lblAIwins
            // 
            this.lblAIwins.AutoSize = true;
            this.lblAIwins.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIwins.Location = new System.Drawing.Point(853, 291);
            this.lblAIwins.Name = "lblAIwins";
            this.lblAIwins.Size = new System.Drawing.Size(125, 33);
            this.lblAIwins.TabIndex = 2;
            this.lblAIwins.Text = "AI Wins:";
            // 
            // lblAIwinper
            // 
            this.lblAIwinper.AutoSize = true;
            this.lblAIwinper.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAIwinper.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAIwinper.Location = new System.Drawing.Point(896, 422);
            this.lblAIwinper.Name = "lblAIwinper";
            this.lblAIwinper.Size = new System.Drawing.Size(144, 33);
            this.lblAIwinper.TabIndex = 3;
            this.lblAIwinper.Text = "AI Win %:";
            // 
            // ctrPlayerWins
            // 
            this.ctrPlayerWins.AutoSize = true;
            this.ctrPlayerWins.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPlayerWins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(147)))), ((int)(((byte)(202)))));
            this.ctrPlayerWins.Location = new System.Drawing.Point(410, 293);
            this.ctrPlayerWins.Name = "ctrPlayerWins";
            this.ctrPlayerWins.Size = new System.Drawing.Size(29, 32);
            this.ctrPlayerWins.TabIndex = 4;
            this.ctrPlayerWins.Text = "0";
            this.ctrPlayerWins.Click += new System.EventHandler(this.ctrPlayerWins_Click);
            // 
            // ctrPlayerWinPer
            // 
            this.ctrPlayerWinPer.AutoSize = true;
            this.ctrPlayerWinPer.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPlayerWinPer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(147)))), ((int)(((byte)(202)))));
            this.ctrPlayerWinPer.Location = new System.Drawing.Point(340, 424);
            this.ctrPlayerWinPer.Name = "ctrPlayerWinPer";
            this.ctrPlayerWinPer.Size = new System.Drawing.Size(29, 32);
            this.ctrPlayerWinPer.TabIndex = 5;
            this.ctrPlayerWinPer.Text = "0";
            // 
            // ctrAIWins
            // 
            this.ctrAIWins.AutoSize = true;
            this.ctrAIWins.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrAIWins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ctrAIWins.Location = new System.Drawing.Point(984, 294);
            this.ctrAIWins.Name = "ctrAIWins";
            this.ctrAIWins.Size = new System.Drawing.Size(29, 32);
            this.ctrAIWins.TabIndex = 6;
            this.ctrAIWins.Text = "0";
            // 
            // ctrAIWinPer
            // 
            this.ctrAIWinPer.AutoSize = true;
            this.ctrAIWinPer.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrAIWinPer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ctrAIWinPer.Location = new System.Drawing.Point(1046, 427);
            this.ctrAIWinPer.Name = "ctrAIWinPer";
            this.ctrAIWinPer.Size = new System.Drawing.Size(29, 32);
            this.ctrAIWinPer.TabIndex = 7;
            this.ctrAIWinPer.Text = "0";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(92, 568);
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
            this.lblTotalGames.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGames.Location = new System.Drawing.Point(525, 272);
            this.lblTotalGames.Name = "lblTotalGames";
            this.lblTotalGames.Size = new System.Drawing.Size(197, 33);
            this.lblTotalGames.TabIndex = 9;
            this.lblTotalGames.Text = "Total Games :";
            // 
            // ctrTotalGames
            // 
            this.ctrTotalGames.AutoSize = true;
            this.ctrTotalGames.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrTotalGames.Location = new System.Drawing.Point(718, 276);
            this.ctrTotalGames.Name = "ctrTotalGames";
            this.ctrTotalGames.Size = new System.Drawing.Size(29, 32);
            this.ctrTotalGames.TabIndex = 10;
            this.ctrTotalGames.Text = "0";
            // 
            // ctrTies
            // 
            this.ctrTies.AutoSize = true;
            this.ctrTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrTies.Location = new System.Drawing.Point(672, 447);
            this.ctrTies.Name = "ctrTies";
            this.ctrTies.Size = new System.Drawing.Size(32, 36);
            this.ctrTies.TabIndex = 12;
            this.ctrTies.Text = "0";
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTies.Location = new System.Drawing.Point(573, 446);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(93, 36);
            this.lblTies.TabIndex = 11;
            this.lblTies.Text = "Ties :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ties :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(675, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(236, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 2);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(531, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 2);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(857, 324);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 2);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(898, 459);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 2);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(146, 457);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(276, 2);
            this.panel5.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(584, 478);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(122, 2);
            this.panel6.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConnectFour_Group3.Properties.Resources.game_stats_new;
            this.pictureBox1.Location = new System.Drawing.Point(324, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ConnectFour_Group3.Properties.Resources.blue_side_design_1;
            this.pictureBox2.Location = new System.Drawing.Point(-3, -29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 687);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ConnectFour_Group3.Properties.Resources.red_side_design_1;
            this.pictureBox3.Location = new System.Drawing.Point(984, -29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(306, 695);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 628);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Stats";
            this.Text = "Stats";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Stats_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}