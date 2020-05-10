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
    class TeamBusiness
    {
        private static void CheckIfTeamNameNull(string ImputTeamName)
        {
            if (ImputTeamName == "")
            {
                throw new TeamNameNullExeption();
            }
        }
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
                team newTeam = new team();
                newTeam.TeamName = ImputTeamName;
                newTeam.TeamPointAmount = CurrentUser.poitAmount;
                dbcontext.Teams.Add(newTeam);
                dbcontext.SaveChanges();
                CurrentUser.UpdateUserTeamInDB(newTeam.TeamId);
            }
        }
        private static List<team> GetListOfTeams()
        {
            using (var dbcontext = new TeamContext())
            {
                var listOfAllTeams = (from t in dbcontext.Teams select t).ToList();
                return listOfAllTeams;
            }
        }
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

    }
}
