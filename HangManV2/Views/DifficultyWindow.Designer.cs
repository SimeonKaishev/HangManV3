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
            this.btnEasy.Location = new System.Drawing.Point(256, 71);
            this.btnEasy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(105, 36);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "EZ";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(193, 111);
            this.btnMedium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(105, 36);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.Text = "RegularJoe";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Enabled = false;
            this.btnHard.Location = new System.Drawing.Point(193, 149);
            this.btnHard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(105, 36);
            this.btnHard.TabIndex = 2;
            this.btnHard.Text = "Harder Daddy";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btnImpossible
            // 
            this.btnImpossible.Enabled = false;
            this.btnImpossible.Location = new System.Drawing.Point(193, 189);
            this.btnImpossible.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImpossible.Name = "btnImpossible";
            this.btnImpossible.Size = new System.Drawing.Size(105, 36);
            this.btnImpossible.TabIndex = 3;
            this.btnImpossible.Text = "no";
            this.btnImpossible.UseVisualStyleBackColor = true;
            this.btnImpossible.Click += new System.EventHandler(this.btnImpossible_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(8, 8);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(50, 20);
            this.btnGoBack.TabIndex = 103;
            this.btnGoBack.Text = "back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // DifficultyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnImpossible);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DifficultyWindow";
            this.Text = "Form2";
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