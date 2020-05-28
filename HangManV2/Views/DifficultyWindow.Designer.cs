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
            this.btnEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEasy.Image = global::HangManV2.Properties.Resources.EasyButton;
            this.btnEasy.Location = new System.Drawing.Point(1015, 433);
            this.btnEasy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(265, 96);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedium.Image = global::HangManV2.Properties.Resources.MediumButton;
            this.btnMedium.Location = new System.Drawing.Point(1015, 534);
            this.btnMedium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(265, 96);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHard.Image = global::HangManV2.Properties.Resources.HardButton;
            this.btnHard.Location = new System.Drawing.Point(1015, 635);
            this.btnHard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(265, 96);
            this.btnHard.TabIndex = 2;
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnImpossible
            // 
            this.btnImpossible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnImpossible.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImpossible.Image = global::HangManV2.Properties.Resources.ImpossibleButton;
            this.btnImpossible.Location = new System.Drawing.Point(1015, 736);
            this.btnImpossible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImpossible.Name = "btnImpossible";
            this.btnImpossible.Size = new System.Drawing.Size(265, 96);
            this.btnImpossible.TabIndex = 3;
            this.btnImpossible.UseVisualStyleBackColor = false;
            this.btnImpossible.Click += new System.EventHandler(this.btnImpossible_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoBack.Image = global::HangManV2.Properties.Resources.BackArrow;
            this.btnGoBack.Location = new System.Drawing.Point(49, 42);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(60, 55);
            this.btnGoBack.TabIndex = 103;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // DifficultyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HangManV2.Properties.Resources.DifficultyWindowBackGround2;
            this.ClientSize = new System.Drawing.Size(2139, 1084);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnImpossible);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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