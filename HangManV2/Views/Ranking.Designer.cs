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
            this.lBoxRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.lBoxRanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxRanking.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxRanking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lBoxRanking.FormattingEnabled = true;
            this.lBoxRanking.ItemHeight = 45;
            this.lBoxRanking.Location = new System.Drawing.Point(179, 267);
            this.lBoxRanking.Margin = new System.Windows.Forms.Padding(2);
            this.lBoxRanking.Name = "lBoxRanking";
            this.lBoxRanking.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lBoxRanking.Size = new System.Drawing.Size(482, 450);
            this.lBoxRanking.TabIndex = 0;
            this.lBoxRanking.SelectedIndexChanged += new System.EventHandler(this.lBoxRanking_SelectedIndexChanged);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(253, 162);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(0, 13);
            this.lblPoints.TabIndex = 1;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(176, 162);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(0, 13);
            this.lblPlayer.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Image = global::HangManV2.Properties.Resources.BackArrow;
            this.btnBack.Location = new System.Drawing.Point(35, 32);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 45);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblShowPlace
            // 
            this.lblShowPlace.AutoSize = true;
            this.lblShowPlace.BackColor = System.Drawing.Color.Transparent;
            this.lblShowPlace.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblShowPlace.Location = new System.Drawing.Point(523, 806);
            this.lblShowPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowPlace.Name = "lblShowPlace";
            this.lblShowPlace.Size = new System.Drawing.Size(118, 47);
            this.lblShowPlace.TabIndex = 4;
            this.lblShowPlace.Text = "label1";
            // 
            // lbTeamsShow
            // 
            this.lbTeamsShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.lbTeamsShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTeamsShow.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeamsShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTeamsShow.FormattingEnabled = true;
            this.lbTeamsShow.ItemHeight = 45;
            this.lbTeamsShow.Location = new System.Drawing.Point(971, 267);
            this.lbTeamsShow.Margin = new System.Windows.Forms.Padding(2);
            this.lbTeamsShow.Name = "lbTeamsShow";
            this.lbTeamsShow.Size = new System.Drawing.Size(482, 450);
            this.lbTeamsShow.TabIndex = 5;
            this.lbTeamsShow.SelectedIndexChanged += new System.EventHandler(this.lbTeamsShow_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HangManV2.Properties.Resources.RankingFormBackground4;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTeamsShow);
            this.Controls.Add(this.lblShowPlace);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lBoxRanking);
            this.Margin = new System.Windows.Forms.Padding(2);
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