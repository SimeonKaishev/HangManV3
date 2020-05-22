using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangManV2;
using System.Collections.Generic;
using HangManV2.Data;

namespace HangmanTesting
{
    [TestClass]
    public class WordAddTest
    {
        [DataTestMethod]
        [DataRow("a")]
        [DataRow("a")]
        [DataRow(" ")]
        [DataRow(",")]
        public void TestCheckIfWordPlayableThrowsExeption(string word)
        {
            Assert.ThrowsException<HangManV2.Commons.WordUnplayableExeption>(() => HangManV2.Context.WordAddBusiness.CheckIfWordPlayable(word));
        }
        [DataTestMethod]
        [DataRow("bla")]
        [DataRow("test")]
        [DataRow("again")]
        [DataRow("pneumonoultramicroscopicsilicovolcanoconiosis")]
        public void TestCheckIfWordPlayableDoesntThrowExeption(string word)
        {
            HangManV2.Context.WordAddBusiness.CheckIfWordPlayable(word);
        }
        [DataTestMethod]
        [DataRow("ass")]
        [DataRow("test")]
        [DataRow("float")]
        [DataRow("poopie")]
        public void TestDetermineWordDifficultyDeterminesAsEasy(string word)
        {
            string difficulty=HangManV2.Context.WordAddBusiness.DetermineWordDifficulty(word);
            Assert.AreEqual("easy", difficulty);
        }
        [DataTestMethod]
        [DataRow("argument")]
        [DataRow("evidence")]
        [DataRow("blockade")]
        [DataRow("mrpoopie")]
        public void TestDetermineWordDifficultyDeterminesAsMedium(string word)
        {
            string difficulty = HangManV2.Context.WordAddBusiness.DetermineWordDifficulty(word);
            Assert.AreEqual("medium", difficulty);
        }
        [DataTestMethod]
        [DataRow("adventurism")]
        [DataRow("avouchments")]
        public void TestDetermineWordDifficultyDeterminesAsHard(string word)
        {
            string difficulty = HangManV2.Context.WordAddBusiness.DetermineWordDifficulty(word);
            Assert.AreEqual("hard", difficulty);
        }
        [DataTestMethod]
        [DataRow("pneumonoultramicroscopicsilicovolcanoconiosis")]
        public void TestDetermineWordDifficultyDeterminesAsImpossible(string word)
        {
            string difficulty = HangManV2.Context.WordAddBusiness.DetermineWordDifficulty(word);
            Assert.AreEqual("impossible", difficulty);
        }
        [TestMethod]
        public void TestCheckIfWordListEmptyThrowsWordAlreadyExistsExeption()
        {
            List<string> listOfWords = new List<string>();
            listOfWords.Add("test");
            Assert.ThrowsException<HangManV2.Commons.WordAlreadyExistsExeption>(() => HangManV2.Context.WordAddBusiness.CheckIfWordListEmpty(listOfWords));
        }
        [TestMethod]
        public void TestCheckIfWordListEmptyDoesntThrowWordAlreadyExistsExeption()
        {
            List<string> listOfWords = new List<string>();
           HangManV2.Context.WordAddBusiness.CheckIfWordListEmpty(listOfWords);
        }
    }
}
