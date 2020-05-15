using HangManV2.Commons;
using HangManV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManV2.Context
{
    /// <summary>
    /// This class handles operations connected with adding words to the database
    /// </summary>
    class WordAddBusiness
    {
        /// <summary>
        /// The method adds a word with certain difficuly in the database
        /// </summary>
        /// <example>
        /// <code>
        ///       WordAddBusiness.AddWord(word, out diff);
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Commons.WordAlreadyExistsExeption">Thrown when the word is already in the database
        /// <exception cref="HangManV2.Commons.WordUnplayableExeption">Thrown when the word is less than 3 symbols
     
        public static void AddWord(string word, out string difficulty)
        {
            try
            {
                CheckIfWordAlreadyInDB(word);
            }
            catch (WordAlreadyExistsExeption)
            {
                throw new WordAlreadyExistsExeption();
            }
            try
            {
                CheckIfWordPlayable(word);
            }
            catch (WordUnplayableExeption)
            {
                throw new WordUnplayableExeption();
            }
             difficulty = DetermineWordDifficulty(word);
            using (var dbcontext = new WordContext())
            {
                word newWord = new Data.word();
                newWord.Word1 = word;
                newWord.Difficulty = difficulty;
                dbcontext.Words.Add(newWord);
                dbcontext.SaveChanges();
            }

        }
        /// <summary>
        /// The method checks if the iserted word is already i the database
        /// </summary>
        /// <example>
        /// <code>
        /// try
        /// {
        ///  CheckIfWordAlreadyInDB(word);
        ///  }
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Commons.WordAlreadyExistsExeption">Thrown when the word is already in the db
        /// </exception>
        private static void CheckIfWordAlreadyInDB(string imputWord)
        {
            using (var dbcontext = new WordContext())
            {
                var words = (from word in dbcontext.Words where word.Word1 == imputWord select word.Word1).ToList();
                if (words.Count != 0)
                {
                    throw new WordAlreadyExistsExeption();
                }
            }
        }
        /// <summary>
        /// The method checks if the word is playable(more than 3 characters)
        /// </summary>
        /// <example>
        /// <code>
        ///   CheckIfWordPlayable(word);     
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Context.WordUnplayableExeption">Thrown when the word less than 3 characters
        private static void CheckIfWordPlayable(string word)
        {
            if (word.Length < 3)
            {
                throw new WordUnplayableExeption();
            }
        }
        /// <summary>
        /// The method calculates the difficulty of the word based on the number of distinct characters
        /// </summary>
        ///  <returns>
        /// word difficulty
        /// </returns>
        /// <example>
        /// <code>
        /// WordAddBusiness.AddWord(word, out diff);
        /// </code>
        /// </example>
        private static string DetermineWordDifficulty(string word)
        {
            int countOfDistinctLetters = word.Distinct().Count();
            if (countOfDistinctLetters <= 5)
            {
                return "easy";
            }
            else
            if (countOfDistinctLetters <= 10 && countOfDistinctLetters > 5)
            {
                return "medium";
            }
            else
            if (countOfDistinctLetters <= 15 && countOfDistinctLetters > 10)
            {
                return "hard";
            }
            else
            {
                return "impossible";
            }
        }
    }
}
