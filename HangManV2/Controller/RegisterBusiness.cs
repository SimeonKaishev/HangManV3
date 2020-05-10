
using HangManV2.Commons;
using HangManV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HangManV2.Context
{
    /// <summary>
    /// This class handles operations connected wit registering
    /// </summary>
    class RegisterBusiness
    {
        /// <summary>
        /// The method checks if the password is long enought(more than 8 symbols)
        /// </summary>
        /// <example>
        /// <code>
        ///  CheckIfPassIsLongEnough(imputPass);
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Commons.PassTooShortException">Thrown when the password is less than 8 symbols
        /// </exception>
        private static void CheckIfPassIsLongEnough(string Pass)
        {
            if (Pass.Length < 8)
            {
                throw new PassTooShortException();
            }
        }
        /// <summary>
        /// The method checks if the iserted username is null
        /// </summary>
        /// <example>
        /// <code>
        ///       try
        ///       {
        ///         CheckIfUsernameNull(imputUsername);
        ///       }
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Commons.UsernameNullExeption">Thrown when the imput username is null
        /// </exception>
        private static void CheckIfUsernameNull(string username)
        {
            if (username=="")
            {
                throw new UsernameNullExeption();
            }
        }
        /// <summary>
        /// The method checks if the iserted username is already taken
        /// </summary>
        /// <example>
        /// <code>
        ///       try
        ///       {
        ///         CheckIfUserNameExists(imputUsername);
        ///       }
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Commons.UserAlreadyExistsExeption">Thrown when the imput username is null
        /// </exception>
        private static void CheckIfUserNameExists(string imputUsername)
        {
            using (var dbcontext = new UserContext())
            {
                var usrname = (from user in dbcontext.Users where user.Username == imputUsername select user.Username).ToList();
                if (usrname.Count != 0)
                {
                    throw new UserAlreadyExistsExeption();
                }
            }
        }
        /// <summary>
        /// The method checks if the iserted password has an upper and lowercase character and annumber
        /// </summary>
        /// <example>
        /// <code>
        ///       try
        ///       {
        ///         CheckIfPassMeetsRequrements(imputPass);
        ///       }
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Commons.PassDoesntMeetReqExeption">Thrown when the imput password doesnt meet the requirement
        /// </exception>
        private static void CheckIfPassMeetsRequrements(string imputPass)
        {
            if (!imputPass.Any(c => char.IsUpper(c))|| !imputPass.Any(c => char.IsLower(c))|| !imputPass.Any(c => char.IsDigit(c)))
            {
                throw new PassDoesntMeetReqExeption();
            }
        }
        /// <summary>
        /// The method adds the user to the database
        /// </summary>
        /// <example>
        /// <code>
        ///       try
        ///       {
        ///          RegisterBusiness.RegisterUser(username, pass);
        ///       }
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Commons.PassDoesntMeetReqExeption">Thrown when the imput password doesnt meet the requirement
        /// </exception>
        /// <exception cref="HangManV2.Commons.UserAlreadyExistsExeption">Thrown when the imput username is null
        /// </exception>
        /// <exception cref="HangManV2.Commons.UsernameNullExeption">Thrown when the imput username is null
        /// </exception>
        /// <exception cref="HangManV2.Commons.PassTooShortException">Thrown when the password is less than 8 symbols
        /// </exception>
        public static void RegisterUser(string imputUsername, string imputPass)
        {
            try
            {
                CheckIfUsernameNull(imputUsername);
            }
            catch (UsernameNullExeption)
            {
                throw new UsernameNullExeption();
            }
            try
            {
                CheckIfUserNameExists(imputUsername);
            }
            catch (UserAlreadyExistsExeption)
            {
                throw new UserAlreadyExistsExeption();
            }
            try
            {
                CheckIfPassIsLongEnough(imputPass);
            }
            catch (PassTooShortException)
            {
                throw new PassTooShortException();
            }
            try
            {
                CheckIfPassMeetsRequrements(imputPass);
            }
            catch (PassDoesntMeetReqExeption)
            {
                throw new PassDoesntMeetReqExeption();
            }
            using (var dbcontext = new hangmanEntities())
            {
                user usr = new user();
                usr.Username = imputUsername;
                usr.Password = Hasher.GetHash(imputPass);
                usr.TeamId = 1;
                usr.PointAmount = 0;
                dbcontext.users.Add(usr);
                dbcontext.SaveChanges();
                CurrentUser.id = usr.Id;
                CurrentUser.username = usr.Username;
                CurrentUser.poitAmount = int.Parse(usr.PointAmount.ToString());
            }

        }

    }
}
