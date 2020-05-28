using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangManV2;
using System.Collections.Generic;
using HangManV2.Data;

namespace HangmanTesting
{
    [TestClass]
    public class LogInBussTests
    {
        [TestMethod]
        public void TestCheckIfUsrListEmptyThrowsUserDoesntExistExeption()
        {
            List<user> ListOfIUsers = new List<user>();
            Assert.ThrowsException<HangManV2.Commons.UserDoesntExistExeption>(() => HangManV2.Context.LoginBusiness.CheckIfUsrListEmpty(ListOfIUsers));
        }
        [TestMethod]
        public void TestCheckIfUsrListEmptyDoesntThrowUserDoesntExistExeption()
        {
            List<user> ListOfIUsers = new List<user>();
             user usr = new user();
             ListOfIUsers.Add(usr);
            HangManV2.Context.LoginBusiness.CheckIfUsrListEmpty(ListOfIUsers);
        }
    }
}
