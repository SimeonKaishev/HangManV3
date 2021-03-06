﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HangManV2.Commons;
using HangManV2.Context;
using HangManV2.InterfacesFolder;

namespace HangManV2.Views
{
    /// <summary>
    /// This class handles the view for logging in 
    /// </summary>
    /// <param name="username">String containing the username.</param>
    /// <param name="hiddenPass">String containing the password but in asteriscs.</param>
    /// <param name="pass">String containing the password.</param>
    /// <param name="usedLabel">String containing the currently used label.</param>
    public partial class LoginForm : Form, IKeybaord, IKeyboardBasic, IKeyboardFull
    {
        public string Username { get; set; }
        public string HiddenPass { get; set; }
        private string pass;
        public string UsedLabel { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            this.pass = "";
            this.UsedLabel = "username";
            this.Username = "";
            this.HiddenPass = "";
        }
        /// <summary>
        /// The method logs the user in
        /// </summary>
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginBusiness.LogIn(Username, pass);
                this.Hide();
                var window = new Form1();
                window.ShowDialog();
                this.Close();
            }
            catch (UserDoesntExistExeption)
            {
                string message = "User doesnt exists!";
                string caption = "Error!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            catch (IncorrectPassExeption)
            {
                string message = "Incorrect password!";
                string caption = "Error!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }

        }
        /// <summary>
        /// The method updtes thhe lables that show the username and hidden password
        /// </summary>
        /// <example>
        /// <code>
        /// UpdateLables();
        /// </code>
        /// </example>
        public void UpdateLables()
        {
            lblUserNameShown.Text = Username;
            lblPassShown.Text = HiddenPass;
        }
        /// <summary>
        /// The method checks if capsLock is active and if it is makes recieved the char uppercase
        /// </summary>
        public void CheckIfUpper(char oldValue, out char value)
        {
            if (CapsLock.Checked == true)
            {

                value = char.ToUpper(oldValue);
            }
            else
            {
                value = oldValue;
            }
        }        /// <summary>
                 /// The method deletes the last letter of the selected label
                 /// </summary>
                 /// <example>
                 /// <code>
                 ///  Backspace();
                 /// </code>
                 /// </example>
        public void Backspace()
        {
            switch (UsedLabel)
            {
                case "username":
                    if (this.Username.Length > 0)
                    {
                        this.Username = this.Username.Substring(0, Username.Length - 1);
                        //lblUserNameShown.Text = username;
                    }
                    break;
                case "pass":
                    if (this.pass.Length > 0)
                    {
                        this.HiddenPass = this.HiddenPass.Substring(0, HiddenPass.Length - 1);
                        // lblPassShown.Text = hiddenPass;
                        this.pass = this.pass.Substring(0, pass.Length - 1);
                    }
                    break;
            }
            UpdateLables();
        }
        /// <summary>
        /// The method calls the backspace method when backspace on the keyboard is pressed
        /// </summary>
        public void btnBackspace_Click(object sender, EventArgs e)
        {
            Backspace();
        }
        #region keyboard
        /// <summary>
        /// The method adds the chosen char to the selected label
        /// </summary>
        /// <example>
        /// <code>
        ///  ButtonClicked('q');
        /// </code>
        /// </example>
        public void ButtonClicked(char value)
        {
            char checkedLetter;
            CheckIfUpper(value, out checkedLetter);
            switch (UsedLabel)
            {
                case "username":
                    this.Username += checkedLetter;
                    break;
                case "pass":
                    this.HiddenPass += '*';
                    this.pass += checkedLetter;
                    break;
            }
            UpdateLables();
        }
        public void btnQ_Click(object sender, EventArgs e)
        {
            ButtonClicked('q');

        }

        public void btnW_Click(object sender, EventArgs e)
        {
            ButtonClicked('w');

        }

        public void btnE_Click(object sender, EventArgs e)
        {
            ButtonClicked('e');

        }

        public void btnR_Click(object sender, EventArgs e)
        {
            ButtonClicked('r');

        }

        public void btnT_Click(object sender, EventArgs e)
        {
            ButtonClicked('t');

        }

        public void btnY_Click(object sender, EventArgs e)
        {
            ButtonClicked('y');

        }

        public void btnU_Click(object sender, EventArgs e)
        {
            ButtonClicked('u');

        }

        public void btnI_Click(object sender, EventArgs e)
        {
            ButtonClicked('i');

        }

        public void btnO_Click(object sender, EventArgs e)
        {
            ButtonClicked('o');

        }

        public void btnP_Click(object sender, EventArgs e)
        {
            ButtonClicked('p');

        }

        public void btnA_Click(object sender, EventArgs e)
        {
            ButtonClicked('a');

        }

        public void btnS_Click(object sender, EventArgs e)
        {
            ButtonClicked('s');

        }

        public void btnD_Click(object sender, EventArgs e)
        {
            ButtonClicked('d');

        }

        public void btnF_Click(object sender, EventArgs e)
        {
            ButtonClicked('f');

        }

        public void btnG_Click(object sender, EventArgs e)
        {
            ButtonClicked('g');

        }

        public void btnH_Click(object sender, EventArgs e)
        {
            ButtonClicked('h');

        }

        public void btnJ_Click(object sender, EventArgs e)
        {
            ButtonClicked('j');

        }

        public void btnK_Click(object sender, EventArgs e)
        {
            ButtonClicked('k');

        }

        public void btnL_Click(object sender, EventArgs e)
        {
            ButtonClicked('l');

        }

        public void btnZ_Click(object sender, EventArgs e)
        {
            ButtonClicked('z');

        }

        public void btnX_Click(object sender, EventArgs e)
        {
            ButtonClicked('x');

        }

        public void btnC_Click(object sender, EventArgs e)
        {
            ButtonClicked('c');

        }

        public void btnV_Click(object sender, EventArgs e)
        {
            ButtonClicked('v');

        }

        public void btnB_Click(object sender, EventArgs e)
        {
            ButtonClicked('b');

        }

        public void btnN_Click(object sender, EventArgs e)
        {
            ButtonClicked('n');

        }

        public void btnM_Click(object sender, EventArgs e)
        {
            ButtonClicked('m');

        }
        public void btnUnderscore_Click(object sender, EventArgs e)
        {
            ButtonClicked('_');
        }
        /// <summary>
        /// The method the used label to the one used for the password
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            SwitchImputPlace();
        }
        /// <summary>
        /// The method the used label to the one used for the password
        /// </summary>
        public void btnNext_Click(object sender, EventArgs e)
        {
            SwitchImputPlace();
        }
        public void SwitchImputPlace()
        {
            if (UsedLabel == "username")
            {
                UsedLabel = "pass";
                btnBack.Enabled = true;
                btnNext.Enabled = false;
                lblPassPoint.Visible = true;
                lblUsrPoint.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
            }
            else
            {
                UsedLabel = "username";
                btnBack.Enabled = false;
                btnNext.Enabled = true;
                lblPassPoint.Visible = false;
                lblUsrPoint.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
            }
        }
        public void btn1_Click(object sender, EventArgs e)
        {
            ButtonClicked('1');
        }

        public void btn2_Click(object sender, EventArgs e)
        {
            ButtonClicked('2');
        }

        public void btn3_Click(object sender, EventArgs e)
        {
            ButtonClicked('3');
        }

        public void btn4_Click(object sender, EventArgs e)
        {
            ButtonClicked('4');
        }

        public void btn5_Click(object sender, EventArgs e)
        {
            ButtonClicked('5');
        }

        public void btn6_Click(object sender, EventArgs e)
        {
            ButtonClicked('6');
        }

        public void btn7_Click(object sender, EventArgs e)
        {
            ButtonClicked('7');
        }

        public void btn8_Click(object sender, EventArgs e)
        {
            ButtonClicked('8');
        }

        public void btn9_Click(object sender, EventArgs e)
        {
            ButtonClicked('9');
        }

        public void btn0_Click(object sender, EventArgs e)
        {
            ButtonClicked('0');
        }
        #endregion
        /// <summary>
        /// The method calls the buttonPressed method for the button on the keyboard that gets pressed
        /// </summary>
        /// <exception cref="FormatException">Thrown when a button that shouldnt be pressed is pressed  

        private void btnBackspace_KeyDown(object sender, KeyEventArgs e)
        {
            string imput = e.KeyCode.ToString();
            switch (imput)
            {
                case "D1":
                    ButtonClicked('1');
                    break;
                case "D2":
                    ButtonClicked('2');
                    break;
                case "D3":
                    ButtonClicked('3');
                    break;
                case "D4":
                    ButtonClicked('4');
                    break;
                case "D5":
                    ButtonClicked('5');
                    break;
                case "D6":
                    ButtonClicked('6');
                    break;
                case "D7":
                    ButtonClicked('7');
                    break;
                case "D8":
                    ButtonClicked('8');
                    break;
                case "D9":
                    ButtonClicked('9');
                    break;
                case "D0":
                    ButtonClicked('0');
                    break;
            }
            if (imput == "Back")
            {
                Backspace();
            }
            else
            if (imput == "Capital")
            {
                if (CapsLock.Checked == false)
                {
                    CapsLock.Checked = true;
                }
                else
                {
                    CapsLock.Checked = false;
                }
            }
            else
            {
                try
                {
                    //imput.ToLower();
                    char keyValue = char.Parse(imput);
                    keyValue = char.ToLower(keyValue);
                    ButtonClicked(keyValue);
                }
                catch (FormatException)
                {

                }
            }
        }
        /// <summary>
        /// Returns the user to the previous window
        /// </summary>
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var window = new StartingScreen();
            window.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Shows the password in place of the hidden password
        /// </summary>
        private void btnPeekPass_Click(object sender, EventArgs e)
        {
            ShowPass();
        }
        public void ShowPass()
        {
            lblPassShown.Text = pass;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void CapsLock_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
