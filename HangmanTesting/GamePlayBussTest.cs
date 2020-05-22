using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangManV2;
using System.Collections.Generic;
using HangManV2.Data;
using HangManV2.Context;

namespace HangmanTesting
{
    [TestClass]
    public class GamePlayBussTest
    {
        private GamePlayBusiness gamePlayBusiness = new GamePlayBusiness("test");

        [DataTestMethod]
        [DataRow('a')]
        [DataRow('i')]
        [DataRow('h')]
        [DataRow('g')]
        public void TestPlayLetterThrowsIncorectLetterExeption(char letter)
        {
           
            Assert.ThrowsException<HangManV2.Commons.IncorectLetterExeption>(() => gamePlayBusiness.PlayLetter(letter));
        }
        [DataTestMethod]
        [DataRow('t')]
        [DataRow( 'e')]
        [DataRow('s')]
        public void TestPlayLetterDoesntThrowIncorectLetterExeption( char letter)
        {
            gamePlayBusiness.PlayLetter(letter);
        }
        [DataTestMethod]
        [DataRow('t',0)]
        [DataRow('e',1)]
        [DataRow('s',2)]
        public void TestFindPossitionOfLettersInWordFindsPositionAs1(char letter,int expectedPos)
        {
            List<int> ListOfInts = gamePlayBusiness.FindPossitionOfLettersInWord(letter);
            Assert.AreEqual(ListOfInts[0], expectedPos);
        }
        [DataTestMethod]
        [DataRow('a')]
        [DataRow('i')]
        [DataRow('h')]
        [DataRow('g')]
        public void TestCheckIfLetterCorrectThrowsIncorectLetterExeption(char letter)
        {
            Assert.ThrowsException<HangManV2.Commons.IncorectLetterExeption>(() => gamePlayBusiness.CheckIfLetterCorrect(letter));
        }
        [DataTestMethod]
        [DataRow('t')]
        [DataRow('e')]
        [DataRow('s')]
        public void TestCheckIfLetterCorrectDoesntThrowIncorectLetterExeption(char letter)
        {
            gamePlayBusiness.PlayLetter(letter);
        }
        [TestMethod]
        public void TestCreateHiddenWordCreatesCorrectly()
        {
            string hidden = gamePlayBusiness.CreateHiddenWord();
            Assert.AreEqual(hidden, "t__t");
        }
        [TestMethod]
        public void TestWordIsSavedCorrectly()
        {
            Assert.AreEqual(gamePlayBusiness.WordInPlay, "test");
        }
        [TestMethod]
        public void TestHiddenWordIsSavedCorrectly()
        {
            Assert.AreEqual(gamePlayBusiness.HiddenWord, "t__t");
        }
        [TestMethod]
        public void TestMistakesStartAt0()
        {
            Assert.AreEqual(gamePlayBusiness.Mistakes, 0);
        }
    }
    
}
