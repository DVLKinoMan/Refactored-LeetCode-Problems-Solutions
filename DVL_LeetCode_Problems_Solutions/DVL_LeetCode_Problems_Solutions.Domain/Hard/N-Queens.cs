using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static IList<IList<string>> SolveNQueens(int n)
        {
            var result = new List<IList<string>>();
            var queensCorrdinates = new List<Tuple<int, int>>();

            int i = 0, j = 0;
            while (true)
            {
                if (i == 0 && j == n)
                    break;
                if (j == n)
                {
                    i = queensCorrdinates.Last().Item1;
                    j = queensCorrdinates.Last().Item2 + 1;
                    queensCorrdinates.RemoveAt(queensCorrdinates.Count - 1);
                    continue;
                }
                if (CanPlaceQueenIn(i, j, queensCorrdinates))
                {
                    queensCorrdinates.Add(Tuple.Create(i, j));
                    if (queensCorrdinates.Count == n)
                    {
                        result.Add(GetQueenListStringCoordinates(queensCorrdinates));
                        queensCorrdinates.RemoveAt(queensCorrdinates.Count - 1);
                    }
                    else
                    {
                        j = 0;
                        i++;
                        continue;
                    }
                }
                j++;
            }

            return result;
        }

        private static bool CanPlaceQueenIn(int i, int j, List<Tuple<int, int>> queenTuples)
        {
            foreach (var queenTuple in queenTuples)
            {
                if (queenTuple.Item2 == j)
                    return false;
                if (Math.Abs(queenTuple.Item1 - i) == Math.Abs((queenTuple.Item2 - j)))
                    return false;
            }

            return true;
        }
        
        private static List<string> GetQueenListStringCoordinates(List<Tuple<int, int>> queenTuples)
        {
            var list = new List<string>();

            foreach (var queenTuple in queenTuples)
                list.Add(new string('.', queenTuple.Item2) + 'Q' + new string('.', queenTuples.Count - (queenTuple.Item2 + 1)));

            return list;
        }
    }
}
