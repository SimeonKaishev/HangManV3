using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManV2.Commons
{
    class UserAlreadyExistsExeption : Exception
    {
        /// <summary>
        /// This class is an exception that is thrown when the user already exists
        /// </summary>
        public UserAlreadyExistsExeption()
        {

        }
    }
    /// <summary>
    /// This class is an exeption that is thrown when UserDoesntExist
    /// </summary>
    class UserDoesntExistExeption : Exception
    {
        public UserDoesntExistExeption()
        {

        }
    }
    /// <summary>
    /// This class is an exeption that is thrown when the password is incorrect
    /// </summary>
    class IncorrectPassExeption : Exception
    {
        public IncorrectPassExeption()
        {

        }
    }
    /// <summary>
    /// This class is an exception that is thrown when password is too short
    /// </summary>
    class PassTooShortException : Exception
    {
        public PassTooShortException()
        {

        }
    }
    /// <summary>
    /// This class is an exeption that is thrown when the chosen letten
    /// </summary>
    class IncorectLetterExeption : Exception
    {
        public IncorectLetterExeption()
        {

        }
    }
    /// <summary>
    /// This class is an exception that is thrown when the password doest meet the requirement
    /// </summary>
    class PassDoesntMeetReqExeption : Exception
    {
        public PassDoesntMeetReqExeption()
        { 
        
        }
    }
    /// <summary>
    /// This class is an exeption that is thrown when the username is null
    /// </summary>
    class UsernameNullExeption : Exception
    {
        public UsernameNullExeption()
        { 
        
        }
    }
    /// <summary>
    /// This class is an exception that is thrown when the word is unplayable
    /// </summary>
    class WordUnplayableExeption : Exception
    {
        public WordUnplayableExeption()
        {

        }
    }
    /// <summary>
    /// This class is an exeption that is thrown when the word already exists
    /// </summary>
    class WordAlreadyExistsExeption : Exception
    {
        public WordAlreadyExistsExeption()
        { 
        
        }
    }
    class TeamAlreadyExistsExeption : Exception
    {
        public TeamAlreadyExistsExeption()
        {

        }
    }
    class TeamNameNullExeption : Exception
    {
        public TeamNameNullExeption()
        {
                
        }
    }
}
