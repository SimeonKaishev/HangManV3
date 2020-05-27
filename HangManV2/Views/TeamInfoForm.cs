using HangManV2.Context;
using HangManV2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManV2.Views
{
    public partial class TeamInfoForm : Form
    {
        /// <summary>
        /// This class handles the view for viewing team information
        /// </summary>
        public TeamInfoForm()
        {
            InitializeComponent();
            string[] teamInfo = TeamBusiness.GetTeamInfo();
            lblTeamName.Text += " " + teamInfo[0];
            lblTeamPoints.Text+=" " + teamInfo[1];
            lblTeamMembers.Text += " " + teamInfo[2];
            lblTeamAvgPoints.Text += " " + teamInfo[3];
            lblPlayerPlace.Text += " " + teamInfo[4]+" in this team";
            List < User > listOfUsers= TeamBusiness.GetAllUsersInTeam();
            foreach (var item in listOfUsers)
            {
                dgUsersInTeam.Rows.Add(item.Username,item.PointAmount);
            }
        }
        /// <summary>
        /// Returns the user to the previous window
        /// </summary>
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new Form1();
            window.ShowDialog();
            this.Close();

        }
        /// <summary>
        /// The method opens a team selection window and closes the menu
        /// </summary>
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new TeamJoinForm();
            window.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// The method opens a team creation window and closes the menu
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new TeamCreateForm();
            window.ShowDialog();
            this.Close();
        }
    }
}
