namespace HangManV2.Views
{
    partial class TeamJoinForm
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
            this.dgTeamsShow = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnJoin = new System.Windows.Forms.Button();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.btnPointsSort = new System.Windows.Forms.Button();
            this.btnAvgPointsSort = new System.Windows.Forms.Button();
            this.btnMembersSort = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeamsShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTeamsShow
            // 
            this.dgTeamsShow.AllowUserToAddRows = false;
            this.dgTeamsShow.AllowUserToDeleteRows = false;
            this.dgTeamsShow.AllowUserToResizeColumns = false;
            this.dgTeamsShow.AllowUserToResizeRows = false;
            this.dgTeamsShow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.dgTeamsShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTeamsShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgTeamsShow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(169)))), ((int)(((byte)(110)))));
            this.dgTeamsShow.Location = new System.Drawing.Point(628, 105);
            this.dgTeamsShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgTeamsShow.Name = "dgTeamsShow";
            this.dgTeamsShow.ReadOnly = true;
            this.dgTeamsShow.RowHeadersWidth = 62;
            this.dgTeamsShow.RowTemplate.Height = 28;
            this.dgTeamsShow.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgTeamsShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTeamsShow.Size = new System.Drawing.Size(887, 694);
            this.dgTeamsShow.TabIndex = 0;
            // 
            // column1
            // 
            this.column1.HeaderText = "TeamName";
            this.column1.MinimumWidth = 8;
            this.column1.Name = "column1";
            this.column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TeamPoints";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "teamMembers";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "AvaregePonts";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJoin.Image = global::HangManV2.Properties.Resources.NoTeamJoinButton;
            this.btnJoin.Location = new System.Drawing.Point(1569, 645);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(152, 79);
            this.btnJoin.TabIndex = 1;
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.BackColor = System.Drawing.Color.Yellow;
            this.lblSortBy.Location = new System.Drawing.Point(649, 827);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(0, 17);
            this.lblSortBy.TabIndex = 2;
            // 
            // btnPointsSort
            // 
            this.btnPointsSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPointsSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPointsSort.Image = global::HangManV2.Properties.Resources.PointsButton;
            this.btnPointsSort.Location = new System.Drawing.Point(884, 908);
            this.btnPointsSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPointsSort.Name = "btnPointsSort";
            this.btnPointsSort.Size = new System.Drawing.Size(133, 62);
            this.btnPointsSort.TabIndex = 3;
            this.btnPointsSort.UseVisualStyleBackColor = false;
            this.btnPointsSort.Click += new System.EventHandler(this.btnPointsSort_Click);
            // 
            // btnAvgPointsSort
            // 
            this.btnAvgPointsSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAvgPointsSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAvgPointsSort.Image = global::HangManV2.Properties.Resources.AvgPoints2;
            this.btnAvgPointsSort.Location = new System.Drawing.Point(1044, 908);
            this.btnAvgPointsSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAvgPointsSort.Name = "btnAvgPointsSort";
            this.btnAvgPointsSort.Size = new System.Drawing.Size(213, 62);
            this.btnAvgPointsSort.TabIndex = 4;
            this.btnAvgPointsSort.UseVisualStyleBackColor = false;
            this.btnAvgPointsSort.Click += new System.EventHandler(this.btnAvgPointsSort_Click);
            // 
            // btnMembersSort
            // 
            this.btnMembersSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMembersSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMembersSort.Image = global::HangManV2.Properties.Resources.Members2;
            this.btnMembersSort.Location = new System.Drawing.Point(1288, 908);
            this.btnMembersSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMembersSort.Name = "btnMembersSort";
            this.btnMembersSort.Size = new System.Drawing.Size(192, 62);
            this.btnMembersSort.TabIndex = 5;
            this.btnMembersSort.UseVisualStyleBackColor = false;
            this.btnMembersSort.Click += new System.EventHandler(this.btnMembersSort_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Image = global::HangManV2.Properties.Resources.BackArrow;
            this.btnGoBack.Location = new System.Drawing.Point(45, 39);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(60, 55);
            this.btnGoBack.TabIndex = 6;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // TeamJoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HangManV2.Properties.Resources.TeamJoinBackground2_3;
            this.ClientSize = new System.Drawing.Size(2139, 1084);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnMembersSort);
            this.Controls.Add(this.btnAvgPointsSort);
            this.Controls.Add(this.btnPointsSort);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.dgTeamsShow);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeamJoinForm";
            this.Text = "TeamJoinForm";
            this.Load += new System.EventHandler(this.TeamJoinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTeamsShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTeamsShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.Button btnPointsSort;
        private System.Windows.Forms.Button btnAvgPointsSort;
        private System.Windows.Forms.Button btnMembersSort;
        private System.Windows.Forms.Button btnGoBack;
    }
}