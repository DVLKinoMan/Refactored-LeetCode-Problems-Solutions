using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int MinimumMoves(int[][] grid)
        {
            int n = grid.Length, minOp = int.MaxValue;

            int res = Dfs((0, 0), (0, 1), 0);

            return res == int.MaxValue ? -1 : res;

            int Dfs((int i, int j) fCoo, (int i, int j) sCoo, int op, bool? lastMoveClockWise = null)
            {
                bool horPos = HorizontalPos(fCoo, sCoo);
                if (horPos && fCoo == (n - 1, n - 2) && sCoo == (n - 1, n - 1))
                    return op;

                //Right move
                if (sCoo.j != n - 1)
                {
                    if (horPos)
                    {
                        if (grid[sCoo.i][sCoo.j + 1] != 1)
                            minOp = Math.Min(minOp, Dfs(sCoo, (sCoo.i, sCoo.j + 1), op + 1));
                    }
                    else
                    {
                        if (grid[fCoo.i][fCoo.j + 1] != 1 && grid[sCoo.i][sCoo.j + 1] != 1)
                            minOp = Math.Min(minOp, Dfs((fCoo.i, fCoo.j + 1), (sCoo.i, sCoo.j + 1), op + 1));
                    }
                }

                //Down Move
                if (sCoo.i != n - 1)
                {
                    if (!horPos)
                    {
                        if (grid[sCoo.i + 1][sCoo.j] != 1)
                            minOp = Math.Min(minOp, Dfs(sCoo, (sCoo.i + 1, sCoo.j), op + 1));
                    }
                    else
                    {
                        if (grid[fCoo.i + 1][fCoo.j] != 1 && grid[sCoo.i + 1][sCoo.j] != 1)
                            minOp = Math.Min(minOp, Dfs((fCoo.i + 1, fCoo.j), (sCoo.i + 1, sCoo.j), op + 1));
                    }
                }

                //Rotate clockwise
                if (horPos && IsCounterClockWise(lastMoveClockWise) && fCoo.i != n - 1 &&
                    grid[fCoo.i + 1][fCoo.j] != 1 &&
                    grid[sCoo.i + 1][sCoo.j] != 1)
                {
                    minOp = Math.Min(minOp, Dfs(fCoo, (sCoo.i + 1, sCoo.j - 1), op + 1, true));
                }

                //Rotate counterclockwise
                if (!horPos && IsClockWise(lastMoveClockWise) && fCoo.j != n - 1 && grid[fCoo.i][fCoo.j + 1] != 1 &&
                    grid[sCoo.i][sCoo.j + 1] != 1)
                {
                    minOp = Math.Min(minOp, Dfs(fCoo, (sCoo.i - 1, sCoo.j + 1), op + 1, false));
                }

                return minOp;
            }

            bool HorizontalPos((int i, int j) fCoo, (int i, int j) sCoo) => fCoo.i == sCoo.i;

            bool IsClockWise(bool? clockWise) => clockWise != null && clockWise == true;

            bool IsCounterClockWise(bool? clockWise) => clockWise != null && clockWise == false;
        }

        /// <summary>
        /// Minimum Moves to Reach Target with Rotations (Not Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int MinimumMoves2(int[][] grid)
        {
            int n = grid.Length, moves = 0;
            var q = new Queue<int[]>();
            var seen = new HashSet<string>();
            q.Enqueue(new int[] {0, 1});
            seen.Add("0-1");

            while (q.Count != 0)
            {
                int size = q.Count;
                for (int i = 0; i < size; i++)
                {
                    int[] span = q.Dequeue();
                    int first = span[0],
                        second = span[1],
                        x1 = first / n,
                        y1 = first % n,
                        x2 = second / n,
                        y2 = second % n;
                    if (x1 == n - 1 && y1 == n - 2 && x2 == n - 1 && y2 == n - 1) return moves;

                    if (x1 == x2)
                    {
                        // horizontal
                        if (y2 + 1 < n && grid[x2][y2 + 1] == 0) move(second, second + 1); // right
                        if (x2 + 1 < n && grid[x1 + 1][y1] == 0 && grid[x2 + 1][y2] == 0)
                        {
                            move(first + n, second + n); // down
                            move(first, first + n); // clockwise
                        }
                    }

                    if (y1 == y2)
                    {
                        // vertical
                        if (x2 + 1 < n && grid[x2 + 1][y2] == 0) move(second, second + n); // down
                        if (y2 + 1 < n && grid[x1][y1 + 1] == 0 && grid[x2][y2 + 1] == 0)
                        {
                            move(first + 1, second + 1); // right
                            move(first, first + 1); // counter clockwise
                        }
                    }
                }

                moves++;
            }

            return -1;

            void move(int f, int s)
            {
                if (!seen.Contains(f + "-" + s))
                {
                    q.Enqueue(new int[] {f, s});
                    seen.Add(f + "-" + s);
                }
            }

        }
    }
}
