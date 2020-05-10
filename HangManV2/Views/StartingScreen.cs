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
    /// This class handles the view that the program starts on
    /// </summary>
    public partial class StartingScreen : Form
    {
        public StartingScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method takes to the logging in window
        /// </summary>
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();  
            var window = new LoginForm();
            window.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// This method takes to the registreation window
        /// </summary>
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new RegisterForm();
            window.ShowDialog();
            this.Close();
        }
    }
}
