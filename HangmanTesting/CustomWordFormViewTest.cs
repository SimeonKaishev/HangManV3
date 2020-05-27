using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangManV2;
using System.Collections.Generic;
using HangManV2.Data;
using System.Runtime.CompilerServices;

namespace HangmanTesting
{
    [TestClass]
    public class CustomWordFormViewTest
    {
        HangManV2.Views.CustomWordForm cwView = new HangManV2.Views.CustomWordForm();
        [TestMethod]
        public void TestButtonClickedAddsCharToWord()
        {
            cwView.ButtonClicked('a');
           // logWindow.ButtonClicked('a');
            Assert.AreEqual("a", cwView.Word);
        }
        [TestMethod]
        public void TestRecognizeKeyBoardWorksForLetter()
        {
            cwView.RecognizeKeyBoard("a");
            Assert.AreEqual("a", cwView.Word);
        }
        [TestMethod]
        public void TestRecognizeKeyBoardWorksForBackspace()
        {
            cwView.RecognizeKeyBoard("a");
            cwView.RecognizeKeyBoard("Back");
            Assert.AreEqual("", cwView.Word);
        }
    }
}
