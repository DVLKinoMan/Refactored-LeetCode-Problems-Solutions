using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Filter Restaurants by Vegan-Friendly, Price and Distance (Mine)
        /// </summary>
        /// <param name="restaurants"></param>
        /// <param name="veganFriendly"></param>
        /// <param name="maxPrice"></param>
        /// <param name="maxDistance"></param>
        /// <returns></returns>
        public static IList<int> FilterRestaurants(int[][] restaurants, int veganFriendly, int maxPrice, int maxDistance)
        {
            return restaurants
                .Where(res => ((veganFriendly == 1 && res[2] == 1) || veganFriendly == 0) &&
                                     res[3] <= maxPrice && res[4] <= maxDistance)
                .OrderByDescending(res => res[1])
                .ThenByDescending(res => res[0])
                .Select(res => res[0])
                .ToList();
        }
    }
}
