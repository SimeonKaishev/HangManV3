using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangManV2;
using System.Collections.Generic;
using HangManV2.Data;
using System.Runtime.CompilerServices;

namespace HangmanTesting
{
    [TestClass]
    public class MenuTest
    {

        HangManV2.Form1 menuView;
        [DataTestMethod]
        [DataRow("test")]
        [DataRow("urmum")]
        public void TestLabelsShowCorrecltUsername(string username)
        {
            CurrentUser.username = username;
            menuView = new Form1();
            Assert.AreEqual(username, menuView.userLabel.Text);
        }
        [DataTestMethod]
        [DataRow(69)]
        [DataRow(420)]
        public void TestLabelsShowCorrecltPoints(int points)
        {
            CurrentUser.poitAmount = points;
            menuView = new Form1();
            Assert.AreEqual(points, int.Parse(menuView.pointsLabel.Text));
        }
    }
}
