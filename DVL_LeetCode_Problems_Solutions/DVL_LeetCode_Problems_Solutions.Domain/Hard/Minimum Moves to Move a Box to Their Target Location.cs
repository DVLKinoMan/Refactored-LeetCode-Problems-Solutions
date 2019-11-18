using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Moves to Move a Box to Their Target Location (Not Working)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int MinPushBox(char[][] grid)
        {
            (int x, int y) TCoo = (0, 0), SCoo = (0, 0), BCoo = (0, 0);
            int m = grid.Length, n = grid[0].Length, minPushes = int.MaxValue;
            var visitedSet = new HashSet<(int, int, int, int)>();
            for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                switch (grid[i][j])
                {
                    case 'T':
                        TCoo = (i, j);
                        break;
                    case 'B':
                        BCoo = (i, j);
                        break;
                    case 'S':
                        SCoo = (i, j);
                        break;
                }

            Dfs((BCoo.x, BCoo.y), 0);

            return minPushes == int.MaxValue ? -1 : minPushes;

            void Dfs((int x, int y) currPos, int currPush)
            {
                if (currPos.x == TCoo.x && currPos.y == TCoo.y)
                {
                    minPushes = Math.Min(currPush, minPushes);
                    return;
                }

                var (x, y) = currPos;
                if (BoxIsStuck(x, y))
                    return;

                var (noUpWay, noDownWay, noLeftWay, noRightWay) = BoxWays(x, y);

                //up
                if (!visitedSet.Contains((currPos.x - 1, currPos.y, x + 1, y)) && !noUpWay && !noDownWay &&
                    Dfs2(SCoo.x, SCoo.y, new HashSet<(int, int)>(), (x, y), (x + 1, y)))
                {
                    var pos = (currPos.x - 1, currPos.y, x + 1, y);
                    visitedSet.Add(pos);
                    Dfs((x - 1, y), currPush + 1);
                    visitedSet.Remove(pos);
                }

                //down
                if (!visitedSet.Contains((currPos.x + 1, currPos.y, x - 1, y)) && !noUpWay && !noDownWay &&
                    Dfs2(SCoo.x, SCoo.y, new HashSet<(int, int)>(), (x, y), (x - 1, y)))
                {
                    var pos = (currPos.x + 1, currPos.y, x - 1, y);
                    visitedSet.Add(pos);
                    Dfs((x + 1, y), currPush + 1);
                    visitedSet.Remove(pos);
                }

                //left
                if (!visitedSet.Contains((currPos.x, currPos.y - 1, x, y + 1)) && !noLeftWay && !noRightWay &&
                    Dfs2(SCoo.x, SCoo.y, new HashSet<(int, int)>(), (x, y), (x, y + 1)))
                {
                    var pos = (currPos.x, currPos.y - 1, x, y + 1);
                    visitedSet.Add(pos);
                    Dfs((x, y - 1), currPush + 1);
                    visitedSet.Remove(pos);
                }

                //right
                if (!visitedSet.Contains((currPos.x, currPos.y + 1, x, y - 1)) && !noLeftWay && !noRightWay &&
                    Dfs2(SCoo.x, SCoo.y, new HashSet<(int, int)>(), (x, y), (x, y - 1)))
                {
                    var pos = (currPos.x, currPos.y + 1, x, y - 1);
                    visitedSet.Add(pos);
                    Dfs((x, y + 1), currPush + 1);
                    visitedSet.Remove(pos);
                }

            }

            bool Dfs2(int px, int py, HashSet<(int, int)> canGoPersonSet, (int x,int y) boxCoo, (int x,int y) targetCoo)
            {
                if (px == targetCoo.x && py == targetCoo.y)
                    return true;

                canGoPersonSet.Add((px, py));

                //up
                if (!canGoPersonSet.Contains((px - 1, py)) && px != 0 && grid[px - 1][py] != '#' && !(px-1==boxCoo.x && py==boxCoo.y))
                    if (Dfs2(px - 1, py, canGoPersonSet, boxCoo, targetCoo))
                        return true;

                //down
                if (!canGoPersonSet.Contains((px + 1, py)) && px != m - 1 && grid[px + 1][py] != '#' && !(px + 1 == boxCoo.x && py == boxCoo.y))
                    if (Dfs2(px + 1, py, canGoPersonSet, boxCoo, targetCoo))
                        return true;

                //left
                if (!canGoPersonSet.Contains((px, py - 1)) && py != 0 && grid[px][py - 1] != '#' && !(px == boxCoo.x && py - 1 == boxCoo.y))
                    if (Dfs2(px, py - 1, canGoPersonSet, boxCoo, targetCoo))
                        return true;

                //right
                if (!canGoPersonSet.Contains((px, py + 1)) && py != n - 1 && grid[px][py + 1] != '#' && !(px == boxCoo.x && py + 1 == boxCoo.y))
                    if(Dfs2(px, py + 1, canGoPersonSet, boxCoo, targetCoo))
                        return true;

                return false;
            }

            bool BoxIsStuck(int x, int y)
            {
                var (noUpWay, noDownWay, noLeftWay, noRightWay) = BoxWays(x, y);
                return noUpWay && noLeftWay || noUpWay && noRightWay || noDownWay && noLeftWay ||
                       noDownWay && noRightWay;
            }

            (bool noUpWay, bool noDownWay, bool noLeftWay, bool noRightWay) BoxWays(int x, int y) =>
                (x == 0 || grid[x - 1][y] == '#',
                    x == m - 1 || grid[x + 1][y] == '#',
                    y == 0 || grid[x][y - 1] == '#',
                    y == n - 1 || grid[x][y + 1] == '#');
        }
    }
}
