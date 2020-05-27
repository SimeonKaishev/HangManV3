using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangManV2;
using System.Collections.Generic;
using HangManV2.Data;

namespace HangmanTesting
{
    [TestClass]
    public class RankingBussTest
    {
        [TestMethod]
        public void TestGetTopPlayersListDoesntFuckingShitItselfAndDieWhenCalled()
        {
            HangManV2.Context.RankingController.GetTopPlayersList();
        }
        // static List<user> listOfUsers = new List<user>();
        [TestMethod]
        public void TestGetPlayerPosInListReturnsCorrectPosition()
        {
            List<User> ListOfUsers = new List<User>();
            User usr = new User();
            usr.Id = 1;
           Assert.AreEqual(1, HangManV2.Context.RankingController.GetPlayerPosInList(ListOfUsers,0));
        }

    }
}
