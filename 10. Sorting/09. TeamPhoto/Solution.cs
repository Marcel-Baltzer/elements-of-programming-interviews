using System;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._10._Sorting._09._TeamPhoto
{
    public class Solution
    {
        public class Player : IComparable
        {
            private readonly int height;

            public Player(int height)
            {
                this.height = height;
            }

            public int CompareTo(object obj)
            {
                var that = (Player) obj;

                return height.CompareTo(that.height);
            }
        }

        public class Team
        {
            private readonly List<Player> players;

            public Team(IReadOnlyCollection<int> height)
            {
                players = new List<Player>(height.Count);

                foreach (var i in height)
                {
                    players.Add(new Player(i));
                }
            }
            
            public List<Player> SortPlayersByHeight()
            {
                var sortedPlayers = new List<Player>(players);
                sortedPlayers.Sort();
                return sortedPlayers;
            }
        }
        
        public static bool ValidPlacementExists(Team a, Team b)
        {
            var aSorted = a.SortPlayersByHeight();
            var bSorted = b.SortPlayersByHeight();

            for (var i = 0; i < aSorted.Count && i < bSorted.Count; i++)
            {
                if (aSorted[i].CompareTo(bSorted[i]) >= 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}