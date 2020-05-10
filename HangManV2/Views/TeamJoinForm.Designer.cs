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
            ((System.ComponentModel.ISupportInitialize)(this.dgTeamsShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTeamsShow
            // 
            this.dgTeamsShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTeamsShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgTeamsShow.Location = new System.Drawing.Point(12, 12);
            this.dgTeamsShow.Name = "dgTeamsShow";
            this.dgTeamsShow.RowHeadersWidth = 62;
            this.dgTeamsShow.RowTemplate.Height = 28;
            this.dgTeamsShow.Size = new System.Drawing.Size(785, 249);
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
            this.btnJoin.Location = new System.Drawing.Point(713, 385);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 56);
            this.btnJoin.TabIndex = 1;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(8, 421);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(65, 20);
            this.lblSortBy.TabIndex = 2;
            this.lblSortBy.Text = "Sort By:";
            // 
            // btnPointsSort
            // 
            this.btnPointsSort.Location = new System.Drawing.Point(79, 396);
            this.btnPointsSort.Name = "btnPointsSort";
            this.btnPointsSort.Size = new System.Drawing.Size(98, 45);
            this.btnPointsSort.TabIndex = 3;
            this.btnPointsSort.Text = "points";
            this.btnPointsSort.UseVisualStyleBackColor = true;
            this.btnPointsSort.Click += new System.EventHandler(this.btnPointsSort_Click);
            // 
            // btnAvgPointsSort
            // 
            this.btnAvgPointsSort.Location = new System.Drawing.Point(183, 396);
            this.btnAvgPointsSort.Name = "btnAvgPointsSort";
            this.btnAvgPointsSort.Size = new System.Drawing.Size(98, 45);
            this.btnAvgPointsSort.TabIndex = 4;
            this.btnAvgPointsSort.Text = "avg. points";
            this.btnAvgPointsSort.UseVisualStyleBackColor = true;
            this.btnAvgPointsSort.Click += new System.EventHandler(this.btnAvgPointsSort_Click);
            // 
            // btnMembersSort
            // 
            this.btnMembersSort.Location = new System.Drawing.Point(287, 396);
            this.btnMembersSort.Name = "btnMembersSort";
            this.btnMembersSort.Size = new System.Drawing.Size(98, 45);
            this.btnMembersSort.TabIndex = 5;
            this.btnMembersSort.Text = "members";
            this.btnMembersSort.UseVisualStyleBackColor = true;
            this.btnMembersSort.Click += new System.EventHandler(this.btnMembersSort_Click);
            // 
            // TeamJoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMembersSort);
            this.Controls.Add(this.btnAvgPointsSort);
            this.Controls.Add(this.btnPointsSort);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.dgTeamsShow);
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
    }
}