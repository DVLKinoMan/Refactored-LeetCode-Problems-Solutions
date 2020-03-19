using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        ///todo: not solved
        // public static int MaxPerformance(int n, int[] speed, int[] efficiency, int k) 
        // {
        //     int[][] ess = new int[n][];
        //     for (int i = 0; i < n; ++i)
        //         ess[i] = new int[] {efficiency[i], speed[i]};
        //     ;
        //     PriorityQueue<Integer> pq = new PriorityQueue<>(k, (a, b) -> a - b);
        //     long res = 0, sumS = 0;
        //     foreach (var es in ess.OrderBy(arr => arr[0])) {
        //         pq.add(es[1]);
        //         sumS = (sumS + es[1]);
        //         if (pq.size() > k) sumS -= pq.poll();
        //         res = Math.Max(res, (sumS * es[0]));
        //     }
        //     return (int) (res % (long)(1e9 + 7));
        // }
    }
}