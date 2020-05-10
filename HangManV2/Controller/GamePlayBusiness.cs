using HangManV2.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManV2.Context
{
    /// <summary>
    /// This class handles operations connected with playng the game 
    /// </summary>
    /// <param name="WordInPlay">String containing the word currently in play.</param>
    /// <param name="HiddenWord">String containing the word currently in play but in asteriscs.</param>
    /// <param name="Mistakes">Intager containing the amount of wrong guesses the player has made.</param>
    class GamePlayBusiness
    {
        public string WordInPlay { get; set; }
        public string HiddenWord { get; set; }
        public int Mistakes { get; set; }
        public GamePlayBusiness(string WordInPlay)
        {
            this.WordInPlay = WordInPlay;
            this.HiddenWord = CreateHiddenWord();
            this.Mistakes = 0;
        }
        /// <summary>
        /// The method checks if a character is in the played word
        /// </summary>
        /// <example>
        /// <code>
        /// gamePlayBusiness.PlayLetter(value);
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Context.IncorectLetterExeption">Thrown when the character is not contained in the word
        /// </exception>
        public void PlayLetter(char playedLetter)
        {
            try
            {
                CheckIfLetterCorrect(playedLetter);
                List<int> letterPositions = FindPossitionOfLettersInWord(playedLetter);
                string test = this.HiddenWord;
                foreach (var item in letterPositions)
                {
                    this.HiddenWord = this.HiddenWord.Remove(item, 1);
                    this.HiddenWord = this.HiddenWord.Insert(item, playedLetter.ToString());
                }
            }
            catch (IncorectLetterExeption)
            {
                this.Mistakes++;
                throw new IncorectLetterExeption();
            }

        }
        /// <summary>
        /// Finds the position of a specified char in the word in play
        /// </summary>
        /// <returns>
        ///  A list of intagers which are the positions
        /// </returns>
        /// <example>
        /// <code>
        /// List<int> letterPositions = FindPossitionOfLettersInWord(playedLetter);
        /// </code>
        private List<int> FindPossitionOfLettersInWord(char playedLetter)
        {
            List<int> letterPos = new List<int>();
            for (int i = 0; i < this.WordInPlay.Length; i++)
            {
                if (this.WordInPlay[i] == playedLetter)
                {
                    letterPos.Add(i);
                }
            }
            return letterPos;
        }
        /// <summary>
        /// The method checks if the played word contains a character
        /// </summary>
        /// <example>
        /// <code>
        /// CheckIfLetterCorrect(playedLetter);
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Context.IncorectLetterExeption">Thrown when the character is not contained in the word
        /// </exception>
        private void CheckIfLetterCorrect(char playedLetter)
        {
            if (!this.WordInPlay.Contains(playedLetter))
            {
                throw new IncorectLetterExeption();
            }

        }
        /// <summary>
        /// The method creates a hidden version of the word in play
        /// </summary>
        /// <example>
        /// <code>
        /// this.HiddenWord = CreateHiddenWord();
        /// </code>
        /// </example>
        /// <param name="firstLetter">Char containing the first letter of the word in play</param>
        /// <param name="lastLetter">the last letter</param>
        /// <param name="hidden">the part of the word in play that gets replced by asterisks</param>
        private string CreateHiddenWord()
        {
            char firstLetter = this.WordInPlay[0];
            char lastLetter = this.WordInPlay[this.WordInPlay.Length - 1];
            String hidden = new String(new char[this.WordInPlay.Length - 2]).Replace('\0', '_');
            //hidden.Insert(0, firstLetter.ToString());
            hidden = firstLetter + hidden + lastLetter;
            return hidden;
        }

    }
}
