using HangManV2.Commons;
using HangManV2.Context;
using HangManV2.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManV2.Views
{
    public partial class TeamJoinForm : Form
    {
        /// <summary>
        /// This class handles the view for joining a team
        /// </summary>
        public TeamJoinForm()
        {
            InitializeComponent();
           
        }
        /// <summary>
        /// The method shows all the teams that have points and members
        /// </summary>
        private void TeamJoinForm_Load(object sender, EventArgs e)
        {
            Dictionary<team, int> TeamsAndNumOfMem = TeamBusiness.GetTeamsAndNumOfMembers();
            foreach (var item in TeamsAndNumOfMem)
            {
                if(item.Key.TeamPointAmount!=0&&item.Value!= 0)
                dgTeamsShow.Rows.Add(item.Key.TeamName, item.Key.TeamPointAmount, item.Value, item.Key.TeamPointAmount / item.Value);
            }
            dgTeamsShow.Sort(Column2,ListSortDirection.Descending);
        }
        /// <summary>
        /// sorts the teams by points
        /// </summary>
        private void btnPointsSort_Click(object sender, EventArgs e)
        {
            dgTeamsShow.Sort(Column2, ListSortDirection.Descending);
        }
        /// <summary>
        /// sorts the teams by points per member
        /// </summary>
        private void btnAvgPointsSort_Click(object sender, EventArgs e)
        {
            dgTeamsShow.Sort(Column4, ListSortDirection.Descending);
        }
        /// <summary>
        /// sorts the teams by members
        /// </summary>
        private void btnMembersSort_Click(object sender, EventArgs e)
        {
            dgTeamsShow.Sort(Column3, ListSortDirection.Descending);
        }
        /// <summary>
        /// The method returns the team id of a given team's name
        /// </summary>
        ///  <returns>
        /// int
        /// </returns>
        /// <example>
        /// <code>
        ///  int newTeamId = GetSelectedTeamId(teamName);
        /// </code>
        /// </example>
        private int GetSelectedTeamId(string teamName)
        {
            
            int newTeamId = TeamBusiness.GetTeamIdByName(teamName);
            return newTeamId;
        }
        /// <summary>
        /// The method returns the team name of the selected team
        /// </summary>
        ///  <returns>
        /// string
        /// </returns>
        /// <example>
        /// <code>
        ///  string teamName = GetSelecttedTeamName();
        /// </code>
        /// </example>
        private string GetSelecttedTeamName()
        { 
           int rowindex = dgTeamsShow.SelectedRows[0].Index;
            string teamName = dgTeamsShow.Rows[rowindex].Cells[0].Value.ToString();
            return teamName;
        }
        /// <summary>
        /// The method changes the current user's team
        /// </summary>
        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (dgTeamsShow.SelectedRows.Count != 1)
            {
                string message = "Please select ONE team";
                string caption = "Error!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                try
                {
                    string teamName = GetSelecttedTeamName();
                    int newTeamId = GetSelectedTeamId(teamName);
                    TeamBusiness.CheckIfTeamDifferent(newTeamId);
                    CurrentUser.ChangeTeam(newTeamId);
                    string message2 = "Joined" + teamName + "!";
                    string caption2 = "Success!";
                    MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                    MessageBox.Show(message2, caption2, buttons2);
                    this.Hide();
                    var window = new TeamInfoForm();
                    window.ShowDialog();
                    this.Close();
                }
                catch (IndexOutOfRangeException)
                {
                    string message = "Please select ONE team";
                    string caption = "Error!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                catch (AlreadyInTeamExeption)
                {
                    string message = "You are already in team";
                    string caption = "Error!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
            }
        }
        /// <summary>
        /// Returns the user to the previous window
        /// </summary>
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            if (CurrentUser.teamId == 1)
            {
                this.Hide();
                var window = new NoTeamForm();
                window.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                var window = new TeamInfoForm();
                window.ShowDialog();
                this.Close();
            }
        }
    }
}
