using HangManV2.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManV2.Context
{
    /// <summary>
    /// This class handles operations connected with playng the game with an word inserted by the user
    /// </summary>
    static class CustomWordBussiness
    {
        /// <summary>
        /// Checks if the word imput by the user is elidgeble for play
        /// </summary>
        /// <example>
        /// <code>
        ///  try
        ///  {
        ///   CustomWordBussiness.CheckIfWordPlayable(word);
        ///   }
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Commons.WordUnplayableExeption">Thrown when the inserted word is too short to be played
        /// </exception>
        public static void CheckIfWordPlayable(string word)
        {
            if (word.Length < 3)
            {
                throw new WordUnplayableExeption();
            }
        }
    }
}
