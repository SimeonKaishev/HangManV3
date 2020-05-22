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
     /// This class handles the view for choosing word difficulty
     /// </summary>
    public partial class DifficultyWindow : Form
    {
        public DifficultyWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Calls the Ranked Gameplay view with the difficulty set to medium
        /// </summary>
        private void btnMedium_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new RankedGameWindow("medium");
            window.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Calls the Ranked Gameplay view with the difficulty set to easy
        /// </summary>
        private void btnEasy_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new GameWindow("easy");
            window.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Calls the Ranked Gameplay view with the difficulty set to hard
        /// </summary>
        private void btnHard_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new GameWindow("hard");
            window.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Calls the Ranked Gameplay view with the difficulty set to ipossible
        /// </summary>
        private void btnImpossible_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new GameWindow("impossible");
            window.ShowDialog();
            this.Close();
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

        private void DifficultyWindow_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }
    }
}
