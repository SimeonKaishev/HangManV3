using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangManV2;
using System.Collections.Generic;
using HangManV2.Data;

namespace HangmanTesting
{
    [TestClass]
    public class WordBussTest
    {
        [DataTestMethod]
        [DataRow("a")]
        [DataRow("a")]
        [DataRow(" ")]
        [DataRow(",")]
        public void TestCheckIfWordPlayableThrowsExeption(string word)
        {
            Assert.ThrowsException<HangManV2.Commons.WordUnplayableExeption>(() => HangManV2.Context.CustomWordBussiness.CheckIfWordPlayable(word));
        }
        [DataTestMethod]
        [DataRow("bla")]
        [DataRow("test")]
        [DataRow("again")]
        [DataRow("pneumonoultramicroscopicsilicovolcanoconiosis")]
        public void TestCheckIfWordPlayableDoesntThrowExeption(string word)
        {
            HangManV2.Context.CustomWordBussiness.CheckIfWordPlayable(word);
        }
        [TestMethod]
        public void TestIfChooseRandomNumDoesntEatShitAndDieWhenCalled()
        {
            int num = HangManV2.Context.WordChooser.ChooseRandomNum(3);
        }
    }
}
