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
    public partial class RankedGameWindow : Form, IGame, IKeybaord
    {
        private string difficulty;
        private GamePlayBusiness gamePlayBusiness;
        private int points;
        TimerForPoints timer;
        private List<char> playedChars;
        public RankedGameWindow(string difficulty)
        {
            InitializeComponent();
            this.difficulty = difficulty;
            gamePlayBusiness = new GamePlayBusiness(WordChooser.ChooseWord(difficulty));
            lblHiddenWord.Text = gamePlayBusiness.HiddenWord;
            points = 0;
            timer = new TimerForPoints();
        }

        private void RankedGameWindow_Load(object sender, EventArgs e)
        {
            int a = timer.GetPoits();
            playedChars = new List<char>();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }
        public void UpdateWord()
        {
            lblHiddenWord.Text = gamePlayBusiness.HiddenWord;
        }
        public void CheckIfWon()
        {
            if (!gamePlayBusiness.HiddenWord.Contains('_'))
            {
                CurrentUser.UpdatePoitAmount(points);
                string message2 = "You win " + points.ToString()+" poits! "+
                    "You are currently in place "+RankingController.GetPlayerPosition()+" overall"
                    ;
                string caption2 = "Success!";
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                MessageBox.Show(message2, caption2, buttons2);
                this.Hide();
                var window = new Form1();
                window.ShowDialog();
                this.Close();
            }
        }
        public void CheckIfLost()
        {
            if (gamePlayBusiness.Mistakes == 9)
            {
                string message2 = "You lose! "+ "You are currently in place " + RankingController.GetPlayerPosition() + " overall";
                string caption2 = "Opposite of success!";
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                MessageBox.Show(message2, caption2, buttons2);
                this.Hide();
                var window = new Form1();
                window.ShowDialog();
                this.Close();
            }
        }
        public void ButtonClicked(char value)
        {
            if (!playedChars.Contains(value))
            {
                try
                {
                    gamePlayBusiness.PlayLetter(value);
                    points += timer.GetPoits();

                }
                catch (IncorectLetterExeption)
                {
                    ShowNextPic();
                    // lblLivesLeft.Text = (9 - gamePlayBusiness.Mistakes).ToString();
                }
                finally
                {
                    playedChars.Add(value);
                    UpdateWord();
                    CheckIfLost();
                    CheckIfWon();
                }
            }
        }
        public void ShowNextPic()
        {
            switch (gamePlayBusiness.Mistakes)
            {
                case 1:
                    picPole.Visible = true;
                    break;
                case 2:
                    picPole2.Visible = true;
                    break;
                case 3:
                    picRope.Visible = true;
                    break;
                case 4:
                    picHead.Visible = true;
                    break;
                case 5:
                    picBody.Visible = true;
                    break;
                case 6:
                    picArmRight.Visible = true;
                    break;
                case 7:
                    picArmLeft.Visible = true;
                    break;
                case 8:
                    picLegRight.Visible = true;
                    break;
                case 9:
                    picLegLeft.Visible = true;
                    break;
            }
        }
        #region keyboard
        public void btnQ_Click(object sender, EventArgs e)
        {
            ButtonClicked('q');
            btnQ.Enabled = false;
        }

        public void btnW_Click(object sender, EventArgs e)
        {
            ButtonClicked('w');
            btnW.Enabled = false;
        }

        public void btnE_Click(object sender, EventArgs e)
        {
            ButtonClicked('e');
            btnE.Enabled = false;
        }

        public void btnR_Click(object sender, EventArgs e)
        {
            ButtonClicked('r');
            btnR.Enabled = false;
        }

        public void btnT_Click(object sender, EventArgs e)
        {
            ButtonClicked('t');
            btnT.Enabled = false;
        }

        public void btnY_Click(object sender, EventArgs e)
        {
            ButtonClicked('y');
            btnY.Enabled = false;
        }

        public void btnU_Click(object sender, EventArgs e)
        {
            ButtonClicked('u');
            btnU.Enabled = false;
        }

        public void btnI_Click(object sender, EventArgs e)
        {
            ButtonClicked('i');
            btnI.Enabled = false;
        }

        public void btnO_Click(object sender, EventArgs e)
        {
            ButtonClicked('o');
            btnO.Enabled = false;
        }

        public void btnP_Click(object sender, EventArgs e)
        {
            ButtonClicked('p');
            btnP.Enabled = false;
        }

        public void btnA_Click(object sender, EventArgs e)
        {
            ButtonClicked('a');
            btnA.Enabled = false;
        }

        public void btnS_Click(object sender, EventArgs e)
        {
            ButtonClicked('s');
            btnS.Enabled = false;
        }

        public void btnD_Click(object sender, EventArgs e)
        {
            ButtonClicked('d');
            btnD.Enabled = false;
        }

        public void btnF_Click(object sender, EventArgs e)
        {
            ButtonClicked('f');
            btnF.Enabled = false;
        }

        public void btnG_Click(object sender, EventArgs e)
        {
            ButtonClicked('g');
            btnG.Enabled = false;
        }

        public void btnH_Click(object sender, EventArgs e)
        {
            ButtonClicked('h');
            btnH.Enabled = false;
        }

        public void btnJ_Click(object sender, EventArgs e)
        {
            ButtonClicked('j');
            btnJ.Enabled = false;
        }

        public void btnK_Click(object sender, EventArgs e)
        {
            ButtonClicked('k');
            btnK.Enabled = false;
        }

        public void btnL_Click(object sender, EventArgs e)
        {
            ButtonClicked('l');
            btnL.Enabled = false;
        }

        public void btnZ_Click(object sender, EventArgs e)
        {
            ButtonClicked('z');
            btnZ.Enabled = false;
        }

        public void btnX_Click(object sender, EventArgs e)
        {
            ButtonClicked('x');
            btnX.Enabled = false;
        }

        public void btnC_Click(object sender, EventArgs e)
        {
            ButtonClicked('c');
            btnC.Enabled = false;
        }

        public void btnV_Click(object sender, EventArgs e)
        {
            ButtonClicked('v');
            btnV.Enabled = false;
        }

        public void btnB_Click(object sender, EventArgs e)
        {
            ButtonClicked('b');
            btnB.Enabled = false;
        }

        public void btnN_Click(object sender, EventArgs e)
        {
            ButtonClicked('n');
            btnN.Enabled = false;
        }

        public void btnM_Click(object sender, EventArgs e)
        {
            ButtonClicked('m');
            btnM.Enabled = false;
        }
        #endregion

        private void lblHiddenWord_Click(object sender, EventArgs e)
        {

        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            string imput = e.KeyCode.ToString();

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

        private void btnL_Click_1(object sender, EventArgs e)
        {

        }
    }
}
