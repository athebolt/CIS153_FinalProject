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
            this.lbl_go_whoWon.AutoSize = true;
            this.lbl_go_whoWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_go_whoWon.Location = new System.Drawing.Point(341, 108);
            this.lbl_go_whoWon.Name = "lbl_go_whoWon";
            this.lbl_go_whoWon.Size = new System.Drawing.Size(119, 24);
            this.lbl_go_whoWon.TabIndex = 1;
            this.lbl_go_whoWon.Text = "[player] wins!";
            this.lbl_go_whoWon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_go_playAgain
            // 
            this.btn_go_playAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_go_playAgain.Location = new System.Drawing.Point(305, 176);
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
            this.btn_go_review.Location = new System.Drawing.Point(305, 247);
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
            this.btn_go_exit.Location = new System.Drawing.Point(305, 318);
            this.btn_go_exit.Name = "btn_go_exit";
            this.btn_go_exit.Size = new System.Drawing.Size(191, 54);
            this.btn_go_exit.TabIndex = 4;
            this.btn_go_exit.Text = "Exit to Title";
            this.btn_go_exit.UseVisualStyleBackColor = true;
            this.btn_go_exit.Click += new System.EventHandler(this.btn_go_exit_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}