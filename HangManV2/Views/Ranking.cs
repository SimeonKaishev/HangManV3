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
            RankingContext.Refresh();
            List<user> topPlayers = RankingContext.GetTopPlayersList();
            int counter = 1;
            foreach (var item in topPlayers)
            {
                lBoxRanking.Items.Add("#"+counter.ToString()+" "+item.Username+" - "+item.PointAmount+" points");
                counter++; 
            }
            int place = RankingContext.GetPlayerPosition();
            lblShowPlace.Text = "You are number " + place.ToString()+" in the univerce";
   
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
    }
}
