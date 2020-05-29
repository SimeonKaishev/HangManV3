using HangManV2.Commons;
using HangManV2.Context;
using HangManV2.Data;
using HangManV2.InterfacesFolder;
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
    /// This class handles the view for creating a team
    /// </summary>
    /// <param name="teamName">String containing the name of team that is to be created.</param>
    public partial class TeamCreateForm : Form, IKeybaord, IKeyboardBasic, IKeyboardFull
    {
        private string teamName;
        public TeamCreateForm()
        {
            InitializeComponent();
            teamName = "";
            lblTeamNameShown.Text = "";
        }

        private void TeamCreateForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
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
        /// <summary>
        /// Creates a team and joins the current user
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                TeamBusiness.CreateTeam(teamName);
                string message2 = "Team Created!";
                string caption2 = "Success!";
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                MessageBox.Show(message2, caption2, buttons2);
                this.Hide();
                var window = new TeamInfoForm();
                window.ShowDialog();
                this.Close();
            }
            catch (TeamNameNullExeption)
            {
                string message = "Team name cannot be null!";
                string caption = "Error!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            catch (TeamAlreadyExistsExeption)
            {
                teamName = "";
                lblTeamNameShown.Text = "";
                string message = "Team already exists!";
                string caption = "Error!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            catch (InvalidOperationException)
            {
                string message = "Team name cannot be over 10 characters!";
                string caption = "Error!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }
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
            teamName += checkedLetter;
            UpdateLabel();
        }
        /// <summary>
        /// The method updates the label that shows the current team name
        /// </summary>
        private void UpdateLabel()
        {
            lblTeamNameShown.Text = teamName;
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
        }

        private void btnCreate_KeyDown(object sender, KeyEventArgs e)
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
        /// The method deletes the last letter of the selected label
        /// </summary>
        /// <example>
        /// <code>
        ///  Backspace();
        /// </code>
        /// </example>
        public void Backspace()
        { 
                    if (this.teamName.Length > 0)
                    {
                        this.teamName = this.teamName.Substring(0, teamName.Length - 1);
                                             
                    }
            UpdateLabel();
        }
        public void btnBackspace_Click(object sender, EventArgs e)
        {
            Backspace();
        }
        #region keyboard
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

        private void TeamCreateForm_KeyDown(object sender, KeyEventArgs e)
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
            if (imput == "Space")
            {
                ButtonClicked('_');
            }
            else
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
    }
}
