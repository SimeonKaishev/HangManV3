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
            this.dgUsersInTeam = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsersInTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.BackColor = System.Drawing.Color.Transparent;
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.lblTeamName.Location = new System.Drawing.Point(140, 242);
            this.lblTeamName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(171, 34);
            this.lblTeamName.TabIndex = 0;
            this.lblTeamName.Text = "Team name:";
            // 
            // lblTeamPoints
            // 
            this.lblTeamPoints.AutoSize = true;
            this.lblTeamPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblTeamPoints.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.lblTeamPoints.Location = new System.Drawing.Point(140, 276);
            this.lblTeamPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeamPoints.Name = "lblTeamPoints";
            this.lblTeamPoints.Size = new System.Drawing.Size(250, 34);
            this.lblTeamPoints.TabIndex = 1;
            this.lblTeamPoints.Text = "Team total points:";
            // 
            // lblTeamMembers
            // 
            this.lblTeamMembers.AutoSize = true;
            this.lblTeamMembers.BackColor = System.Drawing.Color.Transparent;
            this.lblTeamMembers.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.lblTeamMembers.Location = new System.Drawing.Point(140, 308);
            this.lblTeamMembers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeamMembers.Name = "lblTeamMembers";
            this.lblTeamMembers.Size = new System.Drawing.Size(361, 34);
            this.lblTeamMembers.TabIndex = 2;
            this.lblTeamMembers.Text = "Team number of members:";
            // 
            // lblTeamAvgPoints
            // 
            this.lblTeamAvgPoints.AutoSize = true;
            this.lblTeamAvgPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblTeamAvgPoints.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamAvgPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.lblTeamAvgPoints.Location = new System.Drawing.Point(140, 339);
            this.lblTeamAvgPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeamAvgPoints.Name = "lblTeamAvgPoints";
            this.lblTeamAvgPoints.Size = new System.Drawing.Size(291, 34);
            this.lblTeamAvgPoints.TabIndex = 3;
            this.lblTeamAvgPoints.Text = "Team average points:";
            // 
            // lblPlayerPlace
            // 
            this.lblPlayerPlace.AutoSize = true;
            this.lblPlayerPlace.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerPlace.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.lblPlayerPlace.Location = new System.Drawing.Point(140, 376);
            this.lblPlayerPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerPlace.Name = "lblPlayerPlace";
            this.lblPlayerPlace.Size = new System.Drawing.Size(218, 34);
            this.lblPlayerPlace.TabIndex = 4;
            this.lblPlayerPlace.Text = "You are in place";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Image = global::HangManV2.Properties.Resources.TeamInfoCreateButton;
            this.btnCreate.Location = new System.Drawing.Point(913, 675);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(115, 45);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgUsersInTeam
            // 
            this.dgUsersInTeam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.dgUsersInTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsersInTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Points});
            this.dgUsersInTeam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.dgUsersInTeam.Location = new System.Drawing.Point(663, 242);
            this.dgUsersInTeam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgUsersInTeam.Name = "dgUsersInTeam";
            this.dgUsersInTeam.RowHeadersWidth = 62;
            this.dgUsersInTeam.RowTemplate.Height = 28;
            this.dgUsersInTeam.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgUsersInTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsersInTeam.Size = new System.Drawing.Size(365, 392);
            this.dgUsersInTeam.TabIndex = 8;
            // 
            // name
            // 
            this.name.HeaderText = "Username";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 151;
            // 
            // Points
            // 
            this.Points.HeaderText = "Points";
            this.Points.MinimumWidth = 8;
            this.Points.Name = "Points";
            this.Points.Width = 150;
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.Image = global::HangManV2.Properties.Resources.SwitchButton;
            this.btnSwitch.Location = new System.Drawing.Point(663, 675);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(115, 45);
            this.btnSwitch.TabIndex = 6;
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Image = global::HangManV2.Properties.Resources.BackArrow;
            this.btnGoBack.Location = new System.Drawing.Point(35, 34);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(45, 45);
            this.btnGoBack.TabIndex = 5;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // TeamInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HangManV2.Properties.Resources.LoginFormBackground;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.dgUsersInTeam);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblPlayerPlace);
            this.Controls.Add(this.lblTeamAvgPoints);
            this.Controls.Add(this.lblTeamMembers);
            this.Controls.Add(this.lblTeamPoints);
            this.Controls.Add(this.lblTeamName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TeamInfoForm";
            this.Text = "TeamInfoForm";
            this.Load += new System.EventHandler(this.TeamInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsersInTeam)).EndInit();
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
        private System.Windows.Forms.DataGridView dgUsersInTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
    }
}