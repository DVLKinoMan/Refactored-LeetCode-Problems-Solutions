using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Time Visiting All Points (Mine)
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public static int MinTimeToVisitAllPoints(int[][] points)
        {
            int time = 0;
            int len = points.Length;
            if (len == 1 || len == 0)
                return 0;

            for (int i = 1; i < len; i++)
            {
                int x1 = points[i - 1][0], y1 = points[i - 1][1], x = points[i][0], y = points[i][1];
                int currX = x1, currY = y1;
                while (!(currX == x && currY == y))
                {
                    if (currX < x)
                        currX++;
                    else if (currX > x)
                        currX--;

                    if (currY < y)
                        currY++;
                    else if (currY > y)
                        currY--;

                    time++;
                }
            }

            return time;
        }

        /// <summary>
        /// Count Servers that Communicate (Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int CountServers(int[][] grid)
        {
            int m = grid.Length, n = grid[0].Length;
            var rowsDict = new Dictionary<int, int>();
            var colsDict = new Dictionary<int, int>();
            for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (grid[i][j] == 1)
                {
                    if (rowsDict.ContainsKey(i))
                        rowsDict[i]++;
                    else rowsDict.Add(i, 1);
                    if (colsDict.ContainsKey(j))
                        colsDict[j]++;
                    else colsDict.Add(j, 1);
                }

            int count = 0;
            for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (grid[i][j] == 1)
                {
                    if (rowsDict[i] > 1 || colsDict[j] > 1)
                        count++;
                }

            return count;
        }

        /// <summary>
        /// Search Suggestions System (Mine)
        /// </summary>
        /// <param name="products"></param>
        /// <param name="searchWord"></param>
        /// <returns></returns>
        public static IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            var filteredProducts = products.OrderBy(prod=>prod).ToList();
            var resList = new List<IList<string>>();
            for (int len = 1; len <= searchWord.Length; len++)
            {
                string str = searchWord.Substring(0, len);
                filteredProducts = filteredProducts.Where(prod => prod.StartsWith(str)).ToList();
                resList.Add(filteredProducts.Take(3).ToList());
            }

            return resList;
        }
    }
}
