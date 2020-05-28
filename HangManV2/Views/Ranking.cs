using HangManV2.Context;
using HangManV2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManV2.Views
{
    /// <summary>
    /// This class handles the view for ranking
    /// </summary>
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The method shows the top 10 players nad their points and the place of the current user overall
        /// </summary>
        /// <param name="topPlayers">Array of users containing the top 10 players.</param>
        /// <param name="place">integer conatining the overall position of the current user.</param>
        private void Ranking_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;

            RankingController.Refresh();
            List<User> topPlayers = RankingController.GetTopPlayersList();
            int counter = 1;
            foreach (var item in topPlayers)
            {
                switch(item.Username.Length)
                {
                    case 1: lBoxRanking.Items.Add(" #" + counter.ToString() + " " + item.Username + "               ->        " + item.PointAmount + " pts");
                        break;
                    case 2: lBoxRanking.Items.Add(" #" + counter.ToString() + " " + item.Username + "             ->        " + item.PointAmount + " pts");
                        break;
                    case 3: lBoxRanking.Items.Add(" #" + counter.ToString() + " " + item.Username + "            ->       " + item.PointAmount + " pts");
                        break;
                    case 4: lBoxRanking.Items.Add(" #" + counter.ToString() + " " + item.Username + "        ->        " + item.PointAmount + " pts");
                        break;
                    case 5: lBoxRanking.Items.Add(" #" + counter.ToString() + " " + item.Username + "       ->        " + item.PointAmount + " pts");
                        break;
                    case 6: lBoxRanking.Items.Add(" #" + counter.ToString() + " " + item.Username + "      ->        " + item.PointAmount + " pts");
                        break;
                    case 7: lBoxRanking.Items.Add(" #" + counter.ToString() + " " + item.Username + "    ->        " + item.PointAmount + " pts");
                        break;
                    case 8: lBoxRanking.Items.Add(" #" + counter.ToString() + " " + item.Username + "   ->       " + item.PointAmount + " pts");
                        break;
                    case 9: lBoxRanking.Items.Add(" #" + counter.ToString() + " " + item.Username + " ->      " + item.PointAmount + " pts");
                        break;
                    case 10: lBoxRanking.Items.Add(" #" + counter.ToString() + " " + item.Username + "->     " + item.PointAmount + " pts");
                        break;
                    default: lBoxRanking.Items.Add(" #" + counter.ToString() + " " + item.Username + "  ->     " + item.PointAmount + " pts");
                        break;
                }
               
            }
            int place = RankingController.GetPlayerPosition();
            lblShowPlace.Text = "You are number " + place.ToString()+" in the univerce";
            List<Team> teams = TeamBusiness.GetListOfTeams();
            int counter2 = 1;
            foreach (var item in teams)
            {
                if (item.TeamId != 1)
                {
                    lbTeamsShow.Items.Add(" #" + counter2.ToString() + " " + item.TeamName + "      ->      " + item.TeamPointAmount + " pts");
                    counter2++;
                }
            }
   
        }
        /// <summary>
        /// Returns the user to the previous window
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new Form1();
            window.ShowDialog();
            this.Close();
        }

        private void lbTeamsShow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lBoxRanking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
