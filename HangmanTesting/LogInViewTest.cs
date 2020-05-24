using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangManV2;
using System.Collections.Generic;
using HangManV2.Data;
using System.Runtime.CompilerServices;

namespace HangmanTesting
{
    [TestClass]
    public class LogInViewTest
    {
        HangManV2.Views.LoginForm logWindow = new HangManV2.Views.LoginForm();
        [TestMethod]
        public void TestButtonClickedAddsCharToLabel()
        {
            logWindow.ButtonClicked('a');
            Assert.AreEqual("a", logWindow.Username);
        }
        [TestMethod]
        public void TestBackspaceDeletesLastAddedChar()
        {
            logWindow.ButtonClicked('a');
            logWindow.Backspace();
            Assert.AreEqual("", logWindow.Username);
        }//btnNext_Click
        [DataTestMethod]
        [DataRow("pass","username")]
        [DataRow("username", "pass")]
        public void TestSwitchImputPlaceSwitchesToPass(string state,string expected)
        {
            logWindow.UsedLabel = state;
            logWindow.SwitchImputPlace();
            Assert.AreEqual(expected, logWindow.UsedLabel);
        }
        [TestMethod]
        public void TestButtonClickedAddsAsterixToLabelForPass()
        {
            logWindow.SwitchImputPlace();
            logWindow.ButtonClicked('a');
            Assert.AreEqual("*",logWindow.HiddenPass);
        }//CheckIfUpper
        [DataTestMethod]
        [DataRow('a', 'A')]
        [DataRow('b', 'B')]
        [DataRow('c', 'C')]
        public void TestCheckIfUpperReturnsUpperCharWhenCapsLockChecked(char imput,char expectedOutput)
        {
            logWindow.CapsLock.Checked = true;
            char toUpper;
            logWindow.CheckIfUpper(imput,out toUpper);
            Assert.AreEqual(expectedOutput, toUpper);
        }
        [DataTestMethod]
        [DataRow('a', 'a')]
        [DataRow('b', 'b')]
        [DataRow('c', 'c')]
        public void TestCheckIfUpperReturnsLowerCharWhenCapsLockNotChecked(char imput, char expectedOutput)
        {
            char toUpper;
            logWindow.CheckIfUpper(imput, out toUpper);
            Assert.AreEqual(expectedOutput, toUpper);
        }//UpdateLables
        [DataTestMethod]
        [DataRow("alabama")]
        [DataRow("test")]
        [DataRow("a")]
        public void TestUpdateLablesUpdatesLabels(string imput)
        {
            logWindow.Username = imput;
            logWindow.UpdateLables();
            Assert.AreEqual(imput, logWindow.lblUserNameShown.Text);
        }
        [DataTestMethod]
        [DataRow("alabama","*******")]
        [DataRow("test","****")]
        [DataRow("a","*")]
        public void TestUpdateLablesUpdatesLabelForHiddenPass(string imput,string expectedValue)
        {
            logWindow.SwitchImputPlace();
            var arrOfChars = imput.ToCharArray();
            for (int i = 0; i < arrOfChars.Length; i++)
            {
                logWindow.ButtonClicked(arrOfChars[i]);
            }
            logWindow.UpdateLables();
            Assert.AreEqual(expectedValue, logWindow.lblPassShown.Text);
        }
        [DataTestMethod]
        [DataRow("alabama")]
        [DataRow("test")]
        [DataRow("a")]
        public void TestShowPassWorks(string imput)
        {
            logWindow.SwitchImputPlace();
            var arrOfChars = imput.ToCharArray();
            for (int i = 0; i < arrOfChars.Length; i++)
            {
                logWindow.ButtonClicked(arrOfChars[i]);
            }
            logWindow.UpdateLables();
            logWindow.ShowPass();
            Assert.AreEqual(imput, logWindow.lblPassShown.Text);
        }

    }
}
