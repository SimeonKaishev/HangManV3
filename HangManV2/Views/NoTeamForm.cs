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
    public partial class NoTeamForm : Form
    {
        public NoTeamForm()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new Form1();
            window.ShowDialog();
            this.Close();
            
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new TeamJoinForm();
            window.ShowDialog();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new TeamCreateForm();
            window.ShowDialog();
            this.Close();
        }
    }
}
