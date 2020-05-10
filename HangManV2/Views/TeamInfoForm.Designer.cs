namespace HangManV2.Views
{
    partial class TeamInfoForm
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
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblTeamPoints = new System.Windows.Forms.Label();
            this.lblTeamMembers = new System.Windows.Forms.Label();
            this.lblTeamAvgPoints = new System.Windows.Forms.Label();
            this.lblPlayerPlace = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(35, 49);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(97, 20);
            this.lblTeamName.TabIndex = 0;
            this.lblTeamName.Text = "Team name:";
            // 
            // lblTeamPoints
            // 
            this.lblTeamPoints.AutoSize = true;
            this.lblTeamPoints.Location = new System.Drawing.Point(35, 98);
            this.lblTeamPoints.Name = "lblTeamPoints";
            this.lblTeamPoints.Size = new System.Drawing.Size(135, 20);
            this.lblTeamPoints.TabIndex = 1;
            this.lblTeamPoints.Text = "Team total points:";
            // 
            // lblTeamMembers
            // 
            this.lblTeamMembers.AutoSize = true;
            this.lblTeamMembers.Location = new System.Drawing.Point(35, 147);
            this.lblTeamMembers.Name = "lblTeamMembers";
            this.lblTeamMembers.Size = new System.Drawing.Size(199, 20);
            this.lblTeamMembers.TabIndex = 2;
            this.lblTeamMembers.Text = "Team number of members:";
            // 
            // lblTeamAvgPoints
            // 
            this.lblTeamAvgPoints.AutoSize = true;
            this.lblTeamAvgPoints.Location = new System.Drawing.Point(35, 195);
            this.lblTeamAvgPoints.Name = "lblTeamAvgPoints";
            this.lblTeamAvgPoints.Size = new System.Drawing.Size(161, 20);
            this.lblTeamAvgPoints.TabIndex = 3;
            this.lblTeamAvgPoints.Text = "Team average points:";
            // 
            // lblPlayerPlace
            // 
            this.lblPlayerPlace.AutoSize = true;
            this.lblPlayerPlace.Location = new System.Drawing.Point(35, 252);
            this.lblPlayerPlace.Name = "lblPlayerPlace";
            this.lblPlayerPlace.Size = new System.Drawing.Size(123, 20);
            this.lblPlayerPlace.TabIndex = 4;
            this.lblPlayerPlace.Text = "You are in place";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(571, 369);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(114, 45);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.Location = new System.Drawing.Point(307, 369);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(114, 45);
            this.btnSwitch.TabIndex = 6;
            this.btnSwitch.Text = "switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(44, 369);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(114, 45);
            this.btnGoBack.TabIndex = 5;
            this.btnGoBack.Text = "go back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // TeamInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblPlayerPlace);
            this.Controls.Add(this.lblTeamAvgPoints);
            this.Controls.Add(this.lblTeamMembers);
            this.Controls.Add(this.lblTeamPoints);
            this.Controls.Add(this.lblTeamName);
            this.Name = "TeamInfoForm";
            this.Text = "TeamInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblTeamPoints;
        private System.Windows.Forms.Label lblTeamMembers;
        private System.Windows.Forms.Label lblTeamAvgPoints;
        private System.Windows.Forms.Label lblPlayerPlace;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnGoBack;
    }
}