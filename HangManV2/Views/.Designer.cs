﻿namespace HangManV2
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.lblUserShown = new System.Windows.Forms.Label();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.btnTeams = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::HangManV2.Properties.Resources.playButton;
            this.button1.Location = new System.Drawing.Point(1015, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 96);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustom.Image = global::HangManV2.Properties.Resources.CustomButton;
            this.btnCustom.Location = new System.Drawing.Point(1015, 465);
            this.btnCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(265, 96);
            this.btnCustom.TabIndex = 1;
            this.btnCustom.UseVisualStyleBackColor = false;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // lblUserShown
            // 
            this.lblUserShown.AutoSize = true;
            this.lblUserShown.Location = new System.Drawing.Point(351, 63);
            this.lblUserShown.Name = "lblUserShown";
            this.lblUserShown.Size = new System.Drawing.Size(0, 17);
            this.lblUserShown.TabIndex = 2;
            // 
            // btnAddWord
            // 
            this.btnAddWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddWord.Image = global::HangManV2.Properties.Resources.AddWordButton;
            this.btnAddWord.Location = new System.Drawing.Point(1015, 566);
            this.btnAddWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(265, 96);
            this.btnAddWord.TabIndex = 3;
            this.btnAddWord.UseVisualStyleBackColor = false;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Image = global::HangManV2.Properties.Resources.logOutButton;
            this.btnLogOut.Location = new System.Drawing.Point(1015, 869);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(265, 96);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRanking.Image = global::HangManV2.Properties.Resources.RankingButton;
            this.btnRanking.Location = new System.Drawing.Point(1015, 667);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(265, 96);
            this.btnRanking.TabIndex = 5;
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTeams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeams.Image = global::HangManV2.Properties.Resources.TeamsButton;
            this.btnTeams.Location = new System.Drawing.Point(1015, 768);
            this.btnTeams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(265, 96);
            this.btnTeams.TabIndex = 6;
            this.btnTeams.UseVisualStyleBackColor = false;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userLabel.Location = new System.Drawing.Point(249, 63);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 34);
            this.userLabel.TabIndex = 7;
            this.userLabel.Click += new System.EventHandler(this.userLabel_Click);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pointsLabel.Location = new System.Drawing.Point(249, 144);
            this.pointsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(0, 34);
            this.pointsLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HangManV2.Properties.Resources.Form1BackgroundProject2;
            this.ClientSize = new System.Drawing.Size(2139, 1084);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.btnTeams);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.lblUserShown);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Label lblUserShown;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Button btnTeams;
        public System.Windows.Forms.Label userLabel;
        public System.Windows.Forms.Label pointsLabel;
    }
}

