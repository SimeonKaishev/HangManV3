using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManV2.Commons
{
    public class UserAlreadyExistsExeption : Exception
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
    public class UserDoesntExistExeption : Exception
    {
        public UserDoesntExistExeption()
        {

        }
    }
    /// <summary>
    /// This class is an exeption that is thrown when the password is incorrect
    /// </summary>
    public class IncorrectPassExeption : Exception
    {
        public IncorrectPassExeption()
        {

        }
    }
    /// <summary>
    /// This class is an exception that is thrown when password is too short
    /// </summary>
    public class PassTooShortException : Exception
    {
        public PassTooShortException()
        {

        }
    }
    /// <summary>
    /// This class is an exeption that is thrown when the chosen letten
    /// </summary>
    public class IncorectLetterExeption : Exception
    {
        public IncorectLetterExeption()
        {

        }
    }
    /// <summary>
    /// This class is an exception that is thrown when the password doest meet the requirement
    /// </summary>
    public class PassDoesntMeetReqExeption : Exception
    {
        public PassDoesntMeetReqExeption()
        { 
        
        }
    }
    /// <summary>
    /// This class is an exeption that is thrown when the username is null
    /// </summary>
    public class UsernameNullExeption : Exception
    {
        public UsernameNullExeption()
        { 
        
        }
    }
    /// <summary>
    /// This class is an exception that is thrown when the word is unplayable
    /// </summary>
    public class WordUnplayableExeption : Exception
    {
        public WordUnplayableExeption()
        {

        }
    }
    /// <summary>
    /// This class is an exeption that is thrown when the word already exists
    /// </summary>
    public class WordAlreadyExistsExeption : Exception
    {
        public WordAlreadyExistsExeption()
        { 
        
        }
    }
    /// <summary>
    /// This class is an exeption that is thrown when the team already exists
    /// </summary>
    public class TeamAlreadyExistsExeption : Exception
    {
        public TeamAlreadyExistsExeption()
        {

        }
    }
    /// <summary>
    /// This class is an exeption that is thrown when the inserted team name is null
    /// </summary>
    public class TeamNameNullExeption : Exception
    {
        public TeamNameNullExeption()
        {
                
        }
    }
    /// <summary>
    /// This class is an exeption that is thrown when the user tries to join a team they are already a member of
    /// </summary>
    public class AlreadyInTeamExeption : Exception
    {
        public AlreadyInTeamExeption()
        {

        }
    }
}
