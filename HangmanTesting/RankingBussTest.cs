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
            HangManV2.Context.RankingContext.GetTopPlayersList();
        }
        // static List<user> listOfUsers = new List<user>();
        [TestMethod]
        public void TestGetPlayerPosInListReturnsCorrectPosition()
        {
            List<user> ListOfUsers = new List<user>();
            user usr = new user();
            usr.Id = 1;
           Assert.AreEqual(1, HangManV2.Context.RankingContext.GetPlayerPosInList(ListOfUsers,0));
        }

    }
}
