﻿using HangManV2.Data;
using HangManV2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManV2
{    /// <summary>
     /// This class handles oprations of the main menu
     /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userLabel.Text = CurrentUser.username;
            pointsLabel.Text= CurrentUser.poitAmount.ToString();
        }
        /// <summary>
        /// The method opens a dificulty selection window and closes the menu
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new DifficultyWindow();
            window.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// The method opens a custom word play window and closes the menu
        /// </summary>
        private void btnCustom_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new CustomWordForm();
            window.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// The method opens a window for adding a word to the db and closes the menu
        /// </summary>
        private void btnAddWord_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new WordInsertionForm();
            window.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// The method goes to the starting screen and removes the current user and closes the menu
        /// </summary>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            CurrentUser.Clear();
            this.Hide();
            var window = new StartingScreen();
            window.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// The method opens the ranking window and closes the menu
        /// </summary>
        private void btnRanking_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new Ranking();
            window.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// The method opens a team info window or a no team window if the crrent user hasnt joined a team
        /// </summary>
        private void btnTeams_Click(object sender, EventArgs e)
        {
            if (CurrentUser.poitAmount < 50)
            {
                string message = "You need at least 50 points to join a team!";
                string caption = "Error!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                if (CurrentUser.teamId == 1 || CurrentUser.teamId == 0)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void userLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
