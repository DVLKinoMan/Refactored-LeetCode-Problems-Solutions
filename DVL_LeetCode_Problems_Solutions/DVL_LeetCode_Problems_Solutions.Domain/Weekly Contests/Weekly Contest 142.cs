using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static double[] SampleStats(int[] count)
        {
            double min = -1, max = -1, mean, median, mode = -1, sum = 0;

            int modeCount = 0, notZeroCount = 0;
            for (int i = 0; i < count.Length; i++)
                if (count[i] != 0)
                {
                    if (min == -1)
                        min = i;
                    max = i;
                    sum += (i * count[i]);
                    if (modeCount < count[i])
                        mode = i;
                    notZeroCount++;
                }

            mean = sum / notZeroCount;
            int k = 0, k1 = 0, prevNotZero = 0;
            while (true)
            {
                if (count[k1] != 0)
                {
                    if (k == notZeroCount / 2)
                    {
                        if (notZeroCount % 2 == 1)
                            median = k1;
                        else
                            median = (k1 + prevNotZero) / (double) 2;
                        break;
                    }

                    prevNotZero = k1;
                    k++;
                }

                k1++;
            }

            return new double[] {min, max, mean, median, mode};
        }

        /// <summary>
        /// Car Pooling (Mine)
        /// </summary>
        /// <param name="trips"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
        public static bool CarPooling(int[][] trips, int capacity)
        {
            var listTuples = new List<(int, int)>();
            int currPassengers = 0;
            foreach (var trip in trips.OrderBy(t => t[1]))
            {
                if (listTuples.Count > 0)
                    for (int i = 0; i < listTuples.Count; i++)
                        if (listTuples[i].Item1 <= trip[1])
                        {
                            currPassengers -= listTuples[i].Item2;
                            listTuples.RemoveAt(i);
                            i--;
                        }


                listTuples.Add((trip[2], trip[0]));
                currPassengers += trip[0];
                if (currPassengers > capacity)
                    return false;
            }

            return true;
        }
    }
}
