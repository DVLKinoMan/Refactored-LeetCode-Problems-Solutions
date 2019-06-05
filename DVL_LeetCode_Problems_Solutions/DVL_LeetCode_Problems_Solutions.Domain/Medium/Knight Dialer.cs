using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int KnightDialer(int N)
        {
            var list = new List<(int, int)>()
                {(1, 4), (1, 3), (1, 2), (2, 1), (2, 2), (2, 3), (2, 4), (3, 2), (3, 3), (3, 4)};

            int count = 0;
            var knightMoves = new int[] {1, 2};
            foreach (var node in list)
                KnightDialerHelper(node, 0, N - 1, ref count, list, knightMoves);

            return count;
        }

        private static void KnightDialerHelper((int x, int y) node, int height, int n, ref int count,
            List<(int, int)> list, int[] knightMoves)
        {
            if (!list.Contains(node))
                return;

            if (height == n)
            {
                count = count == Math.Pow(10, 9) + 6 ? 0 : count + 1;
                return;
            }

            for (int i = 0; i < knightMoves.Length; i++)
            for (int j = 0; j < knightMoves.Length; j++)
                if (i != j)
                {
                    KnightDialerHelper((node.x + knightMoves[i], node.y + knightMoves[j]), height + 1, n, ref count,
                        list, knightMoves);
                    KnightDialerHelper((node.x + knightMoves[i], node.y - knightMoves[j]), height + 1, n, ref count,
                        list, knightMoves);
                    KnightDialerHelper((node.x - knightMoves[i], node.y + knightMoves[j]), height + 1, n, ref count,
                        list, knightMoves);
                    KnightDialerHelper((node.x - knightMoves[i], node.y - knightMoves[j]), height + 1, n, ref count,
                        list, knightMoves);
                }

        }
    }
}
