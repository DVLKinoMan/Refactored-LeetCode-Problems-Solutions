﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static bool IsRobotBounded(string instructions)
        {
            int[] arr=new int[]{0, 1,2, 3};
            int d = 0, i = 0;
            char curr = instructions[0];
            while (i < instructions.Length && curr != 'G')
            {
                curr = instructions[i];
                if (curr == 'L')
                {
                    if (d + 1 > arr.Length)
                        d = 0;
                    else d++;
                }
                else if (curr == 'R')
                {
                    if (d - 1 < 0)
                        d = arr.Length - 1;
                    else d--;
                }

                i++;
            }

            if (i == instructions.Length)
                return true;

            int first = arr[d];
            while (i < instructions.Length)
            {
                curr = instructions[i];
                if (curr == 'L')
                {
                    if (d + 1 == arr.Length)
                        d = 0;
                    else d++;
                }
                else if (curr == 'R')
                {
                    if (d - 1 < 0)
                        d = arr.Length - 1;
                    else d--;
                }

                i++;
            }

            return first != arr[d];
        }

        /// <summary>
        /// Flower Planting With No Adjacent (My Solution)
        /// </summary>
        /// <param name="N"></param>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static int[] GardenNoAdj(int N, int[][] paths)
        {
            int[] res = new int[N];
            int[] colors=new int[]{1,2,3,4};
            var dic = new Dictionary<int, List<int>>();
            foreach (var path in paths)
            {
                if (dic.ContainsKey(path[0]))
                    dic[path[0]].Add(path[1]);
                else dic.Add(path[0], new List<int> {path[1]});

                if (dic.ContainsKey(path[1]))
                    dic[path[1]].Add(path[0]);
                else dic.Add(path[1], new List<int> { path[0] });
            }

            foreach (var d in dic)
            {
                if (res[d.Key - 1] == 0)
                {
                    res[d.Key - 1] = 1;
                    GardenNoAdjDFS(d.Key, dic, colors, res);
                }
            }

            for (int i = 0; i < res.Length; i++)
                if (res[i] == 0)
                    res[i] = 1;

            return res;
        }

        public static void GardenNoAdjDFS(int garden, Dictionary<int, List<int>> dic, int[] colors, int[] answers)
        {
            if (!dic.ContainsKey(garden))
            {
                answers[garden - 1] = colors[0];
                return;
            }

           var k = dic[garden].Where(v => answers[v - 1] != 0).Select(v => answers[v - 1]);
           answers[garden - 1] = colors.First(c => !k.Contains(c));
           foreach (var gard in dic[garden])
               if (answers[gard - 1] == 0)
               GardenNoAdjDFS(gard, dic, colors, answers);
        }

        public static int MaxSumAfterPartitioning(int[] A, int K)
        {
            throw new NotImplementedException();
        }
    }
}
