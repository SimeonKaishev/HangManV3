using HangManV2.Commons;
using HangManV2.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManV2.Context
{
    /// <summary>
    /// This class handles operations connected with teams
    /// </summary>
    class TeamBusiness
    {
        /// <summary>
        /// The method checks if the given value for team name is null
        /// </summary>
        /// <example>
        /// <code>
        /// try
        /// {
        ///  CheckIfTeamNameNull(ImputTeamName);
        ///  }
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Commons.TeamNameNullExeption">Thrown when the inserted team name is null
        /// </exception>

        private static void CheckIfTeamNameNull(string ImputTeamName)
        {
            if (ImputTeamName == "")
            {
                throw new TeamNameNullExeption();
            }
        }
        /// <summary>
        /// The method checks if the given value for team name is already used by another team
        /// </summary>
        /// <example>
        /// <code>
        /// try
        /// {
        ///  CheckIfTeamExists(ImputTeamName);
        ///  }
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Commons.TeamAlreadyExistsExeption">Thrown when the inserted  team name is already used by another team
        /// </exception>

        private static void CheckIfTeamExists(string ImputTeamName)
        {
            using (var dbcontext = new TeamContext())
            {
                var usrname = (from t in dbcontext.Teams where t.TeamName == ImputTeamName select t.TeamName).ToList();
                if (usrname.Count != 0)
                {
                    throw new TeamAlreadyExistsExeption();
                }
            }
        }
        /// <summary>
        /// The method creates a team undert the given name and adds it to the database
        /// </summary>
        /// <example>
        /// <code>
        /// try
        /// {
        ///  TeamBusiness.CreateTeam(ImputTeamName);
        ///  }
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Commons.TeamAlreadyExistsExeption">Thrown when the inserted  team name is already used by another team
        /// </exception>
        /// <exception cref="HangManV2.Commons.TeamNameNullExeption">Thrown when the inserted team name is null
        /// </exception>
        public static void CreateTeam(string ImputTeamName)
        {
            try
            {
                CheckIfTeamNameNull(ImputTeamName);
            }
            catch (TeamNameNullExeption)
            {
                throw new TeamNameNullExeption();
            }
            try
            {
                CheckIfTeamExists(ImputTeamName);
            }
            catch (TeamAlreadyExistsExeption)
            {
                throw new TeamAlreadyExistsExeption();
            }
            using (var dbcontext = new TeamContext())
            {
                RemovePointsFromOldTeam();
                team newTeam = new team();
                newTeam.TeamName = ImputTeamName;
                newTeam.TeamPointAmount = CurrentUser.poitAmount;
                dbcontext.Teams.Add(newTeam);
                dbcontext.SaveChanges();
                CurrentUser.UpdateUserTeamInDB(newTeam.TeamId);
                
            }
        }
        /// <summary>
        /// The method removes the current users points from their teamID
        /// </summary>
        /// <example>
        /// <code>
        ///  RemovePointsFromOldTeam();
        /// </code>
        /// </example>
        private static void RemovePointsFromOldTeam()
        {
            if (CurrentUser.teamId != 1)
            {
                using (var dbcontext = new TeamContext())
                {
                    var oldTeam = dbcontext.Teams.Find(CurrentUser.teamId);
                    var oldTeamUpdatedpoints = oldTeam;
                    oldTeamUpdatedpoints.TeamPointAmount -= CurrentUser.poitAmount;
                    dbcontext.Entry(oldTeam).CurrentValues.SetValues(oldTeamUpdatedpoints);
                   // dbcontext.Teams.Add(newTeam);
                    dbcontext.SaveChanges();
                }
            }
        }
        /// <summary>
        /// The method returns a list of all team sorted by points
        /// </summary>
        ///  <returns>
        /// List<team>
        /// </returns>
        /// <example>
        /// <code>
        /// var ListOfTeams = GetListOfTeams();
        /// </code>
        /// </example>
        public static List<team> GetListOfTeams()
        {
            using (var dbcontext = new TeamContext())
            {
                var listOfAllTeams = (from t in dbcontext.Teams 
                                      orderby t.TeamPointAmount 
                                      descending select t).ToList();
                return listOfAllTeams;
            }
        }
        /// <summary>
        /// The method returns a dictionary wit value of number of team members and a key of a team 
        /// </summary>
        ///  <returns>
        /// Dictionary<team, int>
        /// </returns>
        /// <example>
        /// <code>
        ///  GetListOfTeams();
        /// </code>
        /// </example>
        public static Dictionary<team, int> GetTeamsAndNumOfMembers()
        {
            var ListOfTeams = GetListOfTeams();
            Dictionary<team, int> TeamsAndNumOfMem = new Dictionary<team, int>();
            using (var dbcontext = new UserContext())
            { 
              foreach (var item in ListOfTeams)
                {
                    var members = (from user in dbcontext.Users 
                                   where user.TeamId == item.TeamId 
                                   select user.Id).Count();
                    if (members != 0||item.TeamId!=1)
                    {
                        TeamsAndNumOfMem.Add(item, members);
                    }
                }
            }
            return TeamsAndNumOfMem;
        }
        /// <summary>
        /// The method returns the team id of a given team's name
        /// </summary>
        ///  <returns>
        /// int
        /// </returns>
        /// <example>
        /// <code>
        ///  TeamBusiness.GetTeamIdByName(string teamName);
        /// </code>
        /// </example>
        public static int GetTeamIdByName(string teamName)
        {
            using (var dbcontext = new TeamContext())
            {
                var TeamIdFound = (from t in dbcontext.Teams 
                                   where t.TeamName == teamName 
                                   select t.TeamId).ToArray();
                return TeamIdFound[0];
            }
        }
        /// <summary>
        /// The method returns a string array with the current user's team
        /// </summary>
        ///  <returns>
        /// string[]
        /// </returns>
        /// <example>
        /// <code>
        ///  TeamBusiness.GetTeamInfo();
        /// </code>
        /// </example>
        public static string[] GetTeamInfo()
        {
            string[] teamInfo = new string[5];
            team myTeam;
            using (var dbcontext = new TeamContext())
            {
                myTeam = dbcontext.Teams.Find(CurrentUser.teamId);

            }    
            teamInfo[0] = myTeam.TeamName;
            teamInfo[1] = myTeam.TeamPointAmount.ToString();
            using (var dbcontext = new UserContext())
            {
                var members = (from user in dbcontext.Users 
                               where user.TeamId == CurrentUser.teamId 
                               select user.Id).Count();
                teamInfo[2] = members.ToString();
                teamInfo[3] = (myTeam.TeamPointAmount / members).ToString();
            }
            teamInfo[4] = GetUserPLaceInTeam();
            return teamInfo;
        }
        /// <summary>
        /// The method returns the current user's place in their team
        /// </summary>
        ///  <returns>
        /// string
        /// </returns>
        /// <example>
        /// <code>
        ///  TeamBusiness.GetUserPLaceInTeam();
        /// </code>
        /// </example>
        private static string GetUserPLaceInTeam()
        {
            List<user> playersByPoints = new List<user>();
            using (var dbcontext = new UserContext())
            {
                playersByPoints = (from user in dbcontext.Users
                                   where user.TeamId == CurrentUser.teamId
                                   orderby user.PointAmount descending
                                   select user).ToList();
            }
            int counter = 0;
            foreach (var item in playersByPoints)
            {
                counter++;
                if (item.Id == CurrentUser.id)
                {
                    break;
                }
            }
            return counter.ToString();
        }
        /// <summary>
        /// The method returns a list of all current members of the team of the current user
        /// </summary>
        ///  <returns>
        /// List<user>
        /// </returns>
        /// <example>
        /// <code>
        ///  TeamBusiness.GetUserPLaceInTeam();
        /// </code>
        /// </example>
        public static List<user> GetAllUsersInTeam()
        {
            List<user> playersByPoints = new List<user>();
            using (var dbcontext = new UserContext())
            {
                playersByPoints = (from user in dbcontext.Users
                                   where user.TeamId == CurrentUser.teamId
                                   orderby user.PointAmount descending
                                   select user).ToList();
            }
            return playersByPoints;
        }
        /// <summary>
        /// The method checks if the given team id is the same as the one of the current user
        /// </summary>
        /// <example>
        /// <code>
        ///  TeamBusiness.CheckIfTeamDifferent(int teamId);
        /// </code>
        /// </example>
        /// <exception cref="HangManV2.Commons.AlreadyInTeamExeption">Thrown when the ids match
        /// </exception>
        public static void CheckIfTeamDifferent(int teamId)
        {
            if (teamId == CurrentUser.teamId)
            {
                throw new AlreadyInTeamExeption();
            }
        }
    }
}
