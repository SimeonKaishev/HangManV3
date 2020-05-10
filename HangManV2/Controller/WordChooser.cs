using HangManV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManV2.Context
{
    /// <summary>
    /// This class handles operation connected with choosing a random word
    /// </summary>
    static class WordChooser
    {
        // <summary>
        /// The method chooses a random word with certain difficulty
        /// </summary>
        /// <example>
        /// <code>
        /// gamePlayBusiness = new GamePlayBusiness(WordChooser.ChooseWord(difficulty));
        /// </code>
        /// </example>
        public static string ChooseWord(string difficulty)
        {
            using (var dbcontext = new WordContext())
            {
                var idsOfCorrectDiff = (from word in dbcontext.Words where word.Difficulty == difficulty select word.Id).ToArray();
                int chosenId = idsOfCorrectDiff[ChooseRandomNum(idsOfCorrectDiff.Length)];
                var chosenWord = dbcontext.Words.Find(chosenId);
                return chosenWord.Word1;
            }
        }
        /// <summary>
        /// The method selects a random nuber
        /// </summary>
        ///  <returns>
        /// randomnumber
        /// </returns>
        /// <example>
        /// <code>
        /// int chosenId = idsOfCorrectDiff[ChooseRandomNum(idsOfCorrectDiff.Length)];
        /// </code>
        /// </example>
        private static int ChooseRandomNum(int ArraySize)
        {
            Random rnd = new Random();
            int chosenNum = rnd.Next(ArraySize);
            return chosenNum;
        }
    }
}
