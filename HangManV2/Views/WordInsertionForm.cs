using HangManV2.Commons;
using HangManV2.Context;
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
    /// This class handles the view for adding words to the db
    /// </summary>
    /// <param name="word">String containing the word that is to be added to the database.</param>
    public partial class WordInsertionForm : Form, IKeyboardBasic, IKeybaord
    {
        private string word;
        public WordInsertionForm()
        {
            InitializeComponent();
            this.word = "";
        }
        /// <summary>
        /// The method updtes thhe lables that show the word
        /// </summary>
        /// <example>
        /// <code>
        /// UpdateLables();
        /// </code>
        /// </example>
        private void UpdateLbl()
        {
            lblWord.Text = this.word;
        }
        /// <summary>
        /// The method adds the word to the database
        /// </summary>
        private void btnAddWord_Click(object sender, EventArgs e)
        {
            string diff = "";
            try
            {
                WordAddBusiness.AddWord(word, out diff);
                string message2 = "Word added with difficulty: "+diff;
                string caption2 = "Success!";
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                MessageBox.Show(message2, caption2, buttons2);
                this.Hide();
                var window = new Form1();
                window.ShowDialog();
                this.Close();
            }
            catch (WordAlreadyExistsExeption)
            {
                string message = "Word already exists!";
                string caption = "Error!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            catch (WordUnplayableExeption)
            {
                string message = "Word must be over 2 characters!";
                string caption = "Error!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }
        /// <summary>
        /// The method adds the chosen char to the  label containing the word
        /// </summary>
        /// <example>
        /// <code>
        ///  ButtonClicked('q');
        /// </code>
        /// </example>
        public void ButtonClicked(char letterPressed)
        {
            this.word = this.word += letterPressed;
            UpdateLbl();
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
        #endregion
        /// <summary>
        /// The method calls the backspace method when backspace on the keyboard is pressed
        /// </summary>
        public void btnBackspace_Click(object sender, EventArgs e)
        {
            Backspace();
        }
        /// <summary>
        /// The method deletes the last letter of the  label and word
        /// </summary>
        /// <example>
        /// <code>
        ///  Backspace();
        /// </code>
        /// </example>
        public void Backspace()
        {
            if (this.word.Length > 0)
            {
                this.word = this.word.Substring(0, word.Length - 1);
                UpdateLbl();
            }
        }
        /// <summary>
        /// The method calls the buttonPressed method for the button on the keyboard that gets pressed
        /// </summary>
        /// <exception cref="FormatException">Thrown when a button that shouldnt be pressed is pressed  
        private void WordInsertionForm_KeyDown(object sender, KeyEventArgs e)
        {
            string imput = e.KeyCode.ToString();
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
            var window = new Form1();
            window.ShowDialog();
            this.Close();
        }
    }
}
