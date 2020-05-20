using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangManV2;
using System.Collections.Generic;

namespace HangmanTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPassUNder8charsThrowsExeption()
        {
            Assert.ThrowsException<HangManV2.Commons.PassTooShortException>(() => HangManV2.Context.RegisterBusiness.CheckIfPassIsLongEnough(" "));
        }
        [TestMethod]
        public void TestPassShoudntBeUnder8CharactersDoesntThrowExeptions()
        {
            HangManV2.Context.RegisterBusiness.CheckIfPassIsLongEnough("         ");
            // Assert.ThrowsException<HangManV2.Commons.PassTooShortException>(() => HangManV2.Context.RegisterBusiness.CheckIfPassIsLongEnough(" "));
        }
        [DataTestMethod]
        [DataRow("a")]
        [DataRow("A")]
        [DataRow("Aa")]
        [DataRow("1")]
        [DataRow("A1")]
        [DataRow("1a")]
        public void TestCheckIfPassMeetsRequrementsThrowsPassDoesntMeetReqExeption(string pass)
        {
            Assert.ThrowsException<HangManV2.Commons.PassDoesntMeetReqExeption>(() => HangManV2.Context.RegisterBusiness.CheckIfPassMeetsRequrements(pass));

        }
        [TestMethod]
        public void TestCheckIfUsernameNullThrowsUsernameNullExeption()
        {
            Assert.ThrowsException<HangManV2.Commons.UsernameNullExeption>(() => HangManV2.Context.RegisterBusiness.CheckIfUsernameNull(""));
        }
        [TestMethod]
        public void TestCheckIfUsernameNullDoesntThrowUsernameNullExeption()
        {
            HangManV2.Context.RegisterBusiness.CheckIfUsernameNull(" ");
            // Assert.ThrowsException<HangManV2.Commons.PassTooShortException>(() => HangManV2.Context.RegisterBusiness.CheckIfPassIsLongEnough(" "));
        }
        
        [TestMethod]
        public void TestCheckIfListOfUsersNamesEmptyThrowsUserExistsExeption()
        {
            List<string> ListOfStrings = new List<string>();
            ListOfStrings.Add("test");
            Assert.ThrowsException<HangManV2.Commons.UserAlreadyExistsExeption>(() => HangManV2.Context.RegisterBusiness.CheckIfListOfUsersNamesEmpty(ListOfStrings));
        }
        [TestMethod]
        public void TestCheckIfListOfUsersNamesEmptyDoesntThrowUserExistsExeption()
        {
            List<string> ListOfStrings = new List<string>();
            //ListOfStrings.Add("test");
            HangManV2.Context.RegisterBusiness.CheckIfListOfUsersNamesEmpty(ListOfStrings);
        }
        [TestMethod]
        public void TestCheckIfPassMeetsRequrementsDoestThrowExeption()
        { 
            HangManV2.Context.RegisterBusiness.CheckIfPassMeetsRequrements("Aa1");
        }
    }
}
