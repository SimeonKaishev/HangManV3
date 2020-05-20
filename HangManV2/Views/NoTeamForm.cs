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
    
     /// <summary>
     /// This class handles oprations of the view that is shown when the current user isnt in a team.
     /// </summary>
    public partial class NoTeamForm : Form
    {
        public NoTeamForm()
        {
            InitializeComponent();
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
        private void btnJoin_Click(object sender, EventArgs e)
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
