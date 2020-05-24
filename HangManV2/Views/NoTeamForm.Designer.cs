namespace HangManV2.Views
{
    partial class NoTeamForm
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
            this.lblText1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.Location = new System.Drawing.Point(8, 6);
            this.lblText1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(0, 39);
            this.lblText1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 1;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Image = global::HangManV2.Properties.Resources.BackArrow;
            this.btnGoBack.Location = new System.Drawing.Point(40, 36);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(45, 45);
            this.btnGoBack.TabIndex = 2;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.Image = global::HangManV2.Properties.Resources.NoTeamJoinButton;
            this.btnJoin.Location = new System.Drawing.Point(505, 436);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(180, 90);
            this.btnJoin.TabIndex = 3;
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Image = global::HangManV2.Properties.Resources.NoTeamCreateButton;
            this.btnCreate.Location = new System.Drawing.Point(949, 436);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(180, 90);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // NoTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HangManV2.Properties.Resources.NoTeamFormBackground;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblText1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NoTeamForm";
            this.Text = "NoTeamForm";
            this.Load += new System.EventHandler(this.NoTeamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnCreate;
    }
}