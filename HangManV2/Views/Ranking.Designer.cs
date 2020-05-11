namespace HangManV2.Views
{
    partial class Ranking
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
            this.lBoxRanking = new System.Windows.Forms.ListBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblShowPlace = new System.Windows.Forms.Label();
            this.lbTeamsShow = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBoxRanking
            // 
            this.lBoxRanking.BackColor = System.Drawing.SystemColors.Control;
            this.lBoxRanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxRanking.FormattingEnabled = true;
            this.lBoxRanking.ItemHeight = 20;
            this.lBoxRanking.Location = new System.Drawing.Point(195, 50);
            this.lBoxRanking.Name = "lBoxRanking";
            this.lBoxRanking.Size = new System.Drawing.Size(242, 340);
            this.lBoxRanking.TabIndex = 0;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(287, 9);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(56, 20);
            this.lblPoints.TabIndex = 1;
            this.lblPoints.Text = "points:";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(191, 9);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(52, 20);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "Player";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 34);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblShowPlace
            // 
            this.lblShowPlace.AutoSize = true;
            this.lblShowPlace.Location = new System.Drawing.Point(195, 418);
            this.lblShowPlace.Name = "lblShowPlace";
            this.lblShowPlace.Size = new System.Drawing.Size(51, 20);
            this.lblShowPlace.TabIndex = 4;
            this.lblShowPlace.Text = "label1";
            // 
            // lbTeamsShow
            // 
            this.lbTeamsShow.BackColor = System.Drawing.SystemColors.Control;
            this.lbTeamsShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTeamsShow.FormattingEnabled = true;
            this.lbTeamsShow.ItemHeight = 20;
            this.lbTeamsShow.Location = new System.Drawing.Point(475, 50);
            this.lbTeamsShow.Name = "lbTeamsShow";
            this.lbTeamsShow.Size = new System.Drawing.Size(242, 340);
            this.lbTeamsShow.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "points:";
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTeamsShow);
            this.Controls.Add(this.lblShowPlace);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lBoxRanking);
            this.Name = "Ranking";
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.Ranking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxRanking;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblShowPlace;
        private System.Windows.Forms.ListBox lbTeamsShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}