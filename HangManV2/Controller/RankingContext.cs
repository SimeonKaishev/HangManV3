using HangManV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangManV2.Context
{
    /// <summary>
    /// This class handles oprations connected with ranking
    /// </summary>
     /// <param name="topUsers">A list of users.</param>
    public static class RankingController
    {
        private static List<User> topUsers=new List<User>();
        /// <summary>
        /// The method returns a list of the top 10 users
        /// </summary>
        /// <returns>
        ///  A list of the top 10 users
        /// </returns>
        /// <example>
        /// <code>
        ///  List<user> topPlayers = RankingContext.GetTopPlayersList();
        /// </code>
        /// </example>
        public static List<User> GetTopPlayersList()
        {
            return topUsers;
        }
        /// <summary>
        /// The method updates the list of top 10 players
        /// </summary>
        /// <example>
        /// <code>
        /// RankingContext.Refresh();      
        /// </code>
        /// </example>
        public static void Refresh()
        {
            using (var dbcontext = new UserContext())
            {
                var topTenPlayers = (from user in dbcontext.Users
                                     orderby user.PointAmount descending
                                     select user).Take(10).ToList();
                topUsers = topTenPlayers;
            }
        }
        /// <summary>
        /// The method returns the position of the current player compared to everyone else
        /// </summary>
        /// <returns>
        ///  the place of the current player
        /// </returns>
        /// <example>
        /// <code>
        /// List<user> topPlayers = RankingContext.GetTopPlayersList();
        /// </code>
        /// </example>
        public static int GetPlayerPosition()
        {
            List<User> playersByPoints = new List<User>();
            using (var dbcontext = new UserContext())
            {
                 playersByPoints = (from user in dbcontext.Users
                                     orderby user.PointAmount descending
                                     select user).ToList();
            }
            
            return GetPlayerPosInList(playersByPoints, CurrentUser.id);
        }
        public static int GetPlayerPosInList(List<User> listOfUsers,int playerId)
        {
            int counter = 1;
            foreach (var item in listOfUsers)
            {
                
                if (item.Id == playerId)
                {
                    break;
                }
                counter++;
            }
            return counter;
        }
    }
}