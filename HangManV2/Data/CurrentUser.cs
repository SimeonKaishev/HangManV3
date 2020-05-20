using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HangManV2.Data
{    /// <summary>
     /// This class keeps the current user
     /// </summary>
     /// <param name="id">integer value of users id</param>
     /// <param name="username">string value of users username </param>
     /// <param name="pointAmount">integer value of users points</param>
     /// /// <param name="teamId">integer value  of users team id</param>
    static class CurrentUser
    {
        public static int id { get; set; }
        public static string username { get; set; }
        public static int poitAmount { get; set; }
        public static int teamId { get; set; }
        /// <summary>
        /// The method the amount of points
        /// </summary>
        /// <example>
        /// <code>
        /// CurrentUser.UpdatePoitAmount(points);
        /// </code>
        /// </example>
        public static void UpdatePoitAmount(int poitsToAdd)
        {
            poitAmount = poitAmount += poitsToAdd;
            UpdateUserInDB();
        }
        /// <summary>
        /// The method updates the user in the database
        /// </summary>
        /// <example>
        /// <code>
        /// UpdateUserInDB();
        /// </code>
        /// </example>
        private static void UpdateUserInDB()
        {
            using (var dbcontext = new UserContext())
            {
                var usr = dbcontext.Users.Find(id);
                var usrNew = usr;
                usrNew.PointAmount = poitAmount;
                dbcontext.Entry(usr).CurrentValues.SetValues(usrNew);
                dbcontext.SaveChanges();
            }

           
        }
        /// <summary>
        /// The method updates the user team in the database
        /// </summary>
        /// <example>
        /// <code>
        /// UpdateUserTeamInDB(int NewTeamID);
        /// </code>
        /// </example>
        public static void UpdateUserTeamInDB(int newTeamID)
        {
            using (var dbcontext = new UserContext())
            {
                var usr = dbcontext.Users.Find(id);
                var usrNew = usr;
                usrNew.TeamId = newTeamID;
                teamId = newTeamID;
                dbcontext.Entry(usr).CurrentValues.SetValues(usrNew);
                dbcontext.SaveChanges();
            }


        }
        /// <summary>
        /// The method changes the currents userrs team id and transfers the points
        /// </summary>
        /// <example>
        /// <code>
        /// CurrentUser.ChangeTeam(int newTeamID)
        /// </code>
        /// </example>
        public static void ChangeTeam(int newTeamID)
        {
            using (var dbcontext = new TeamContext())
            {
                var oldTeam = dbcontext.Teams.Find(teamId);
                var oldTeamUpdatedpoints = oldTeam;
                oldTeamUpdatedpoints.TeamPointAmount -= poitAmount;
                dbcontext.Entry(oldTeam).CurrentValues.SetValues(oldTeamUpdatedpoints);
                var newTeam = dbcontext.Teams.Find(newTeamID);
                var newTeamUp = newTeam;
                newTeamUp.TeamPointAmount += poitAmount;
                dbcontext.Entry(newTeam).CurrentValues.SetValues(newTeamUp);
                dbcontext.SaveChanges();
            }
            UpdateUserTeamInDB(newTeamID);
        }
        /// <summary>
        /// The method sets the classes values to nll
        /// </summary>
        /// <example>
        /// <code>
        /// CurrentUser.Clear();
        /// </code>
        /// </example>
        public static void Clear()
        {
            id = 0;
            username = null;
            poitAmount = 0;
        }
    }
}
