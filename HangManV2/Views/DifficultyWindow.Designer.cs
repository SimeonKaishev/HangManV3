namespace HangManV2.Views
{
    partial class DifficultyWindow
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
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnImpossible = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEasy
            // 
            this.btnEasy.Enabled = false;
            this.btnEasy.Location = new System.Drawing.Point(761, 352);
            this.btnEasy.Margin = new System.Windows.Forms.Padding(2);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(199, 78);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "EZ";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(761, 434);
            this.btnMedium.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(199, 78);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.Text = "RegularJoe";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Enabled = false;
            this.btnHard.Location = new System.Drawing.Point(761, 516);
            this.btnHard.Margin = new System.Windows.Forms.Padding(2);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(199, 78);
            this.btnHard.TabIndex = 2;
            this.btnHard.Text = "Harder Daddy";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnImpossible
            // 
            this.btnImpossible.Enabled = false;
            this.btnImpossible.Location = new System.Drawing.Point(761, 598);
            this.btnImpossible.Margin = new System.Windows.Forms.Padding(2);
            this.btnImpossible.Name = "btnImpossible";
            this.btnImpossible.Size = new System.Drawing.Size(199, 78);
            this.btnImpossible.TabIndex = 3;
            this.btnImpossible.Text = "no";
            this.btnImpossible.UseVisualStyleBackColor = true;
            this.btnImpossible.Click += new System.EventHandler(this.btnImpossible_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoBack.Image = global::HangManV2.Properties.Resources.BackArrow;
            this.btnGoBack.Location = new System.Drawing.Point(37, 34);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(45, 45);
            this.btnGoBack.TabIndex = 103;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // DifficultyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HangManV2.Properties.Resources.DifficultyWindowBackGround2;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnImpossible);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DifficultyWindow";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.DifficultyWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnImpossible;
        private System.Windows.Forms.Button btnGoBack;
    }
}