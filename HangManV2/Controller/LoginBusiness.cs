using HangManV2.Commons;
using HangManV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HangManV2.Context
{
    /// <summary>
    /// This class handles operations connected wit logging in
    /// </summary>
    public class LoginBusiness
    {
        /// <summary>
        /// The method checks if the user exists in the database
        /// </summary>
        /// <example>
        /// <code>
        ///       try
        ///       {
        ///         CheckIfUserExists(imputName, out usr);
        ///       }
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.ContextDoesntExistException.UserDoesntExistExeption">Thrown when the user isn't in the database
        /// </exception>
        private static void CheckIfUserExists(string imputUsername, out User uzer)
        {
            using (var dbcontext = new UserContext())
            {
                var usr = (from user in dbcontext.Users where user.Username == imputUsername select user).ToList();
                try
                {
                    CheckIfUsrListEmpty(usr);
                }
                catch (UserAlreadyExistsExeption)
                {
                    throw new UserDoesntExistExeption();
                }
                uzer = usr[0];
            }
        }
        /// <summary>
        /// The method checks if the given list of users is empty
        /// </summary>
        /// <example>
        /// <code>
        ///       try
        ///       {
        ///         CheckIfUsrListEmpty(usr);
        ///       }
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.ContextDoesntExistException.UserDoesntExistExeption">Thrown when the user isn't in the database
        /// </exception>
        public static void CheckIfUsrListEmpty(List<User> users)
        {
            if (users.Count == 0)
            {
                throw new UserDoesntExistExeption();
            }
        }
        /// <summary>
        /// sets current user based on username  if the inserted pass is correct
        /// </summary>
        /// 
        /// <example>
        /// <code>
        /// LoginBusiness.LogIn(username, pass);
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Commons.UserDoesntExistExeption">Thrown when the user isn't in the database
        /// </exception>
        /// <exception cref="HangManV2.Commons.IncorrectPassExeption">Thrown when the hashed values of the passwords don't match
        /// </exception>
        public static void LogIn(string imputName, string imputPass)
        {
            using (var dbcontext = new UserContext())
            {
                User usr = new User();
                try
                {
                    CheckIfUserExists(imputName, out usr);
                }
                catch (UserDoesntExistExeption)
                {
                    throw new UserDoesntExistExeption();
                }
                try
                {
                    Hasher.CheckPass(usr, imputPass);
                }
                catch (IncorrectPassExeption)
                {
                    throw new IncorrectPassExeption();
                }
                CurrentUser.id = usr.Id;
                CurrentUser.username = usr.Username;
                CurrentUser.poitAmount = int.Parse(usr.PointAmount.ToString());
                CurrentUser.teamId = int.Parse(usr.TeamId.ToString());
            }
        }
    }
}
