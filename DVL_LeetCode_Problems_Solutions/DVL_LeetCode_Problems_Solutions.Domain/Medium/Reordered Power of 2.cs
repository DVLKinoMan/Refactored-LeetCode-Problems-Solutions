using System;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Reordered Power of 2 (Not Mine)
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public bool ReorderedPowerOf2(int N)
        {
            //Slower
            //string str = ReorderedPowerOf2Helper(N);
            //for (int i = 0; i < 32; i++)
            //    if (ReorderedPowerOf2Helper(1 << i) == str)
            //        return true;

            //return false;

            //Faster
            long num = ReorderedPowerOf2Helper2(N);
            for (int i = 0; i < 32; i++)
                if (ReorderedPowerOf2Helper2(1 << i) == num)
                    return true;

            return false;
        }

        private string ReorderedPowerOf2Helper(int num)
        {
            var arr = num.ToString().ToCharArray();
            Array.Sort(arr);
            return string.Join("", arr);
        }

        private long ReorderedPowerOf2Helper2(int num)
        {
            long res = 0;
            for (; num > 0; num /= 10) res += (int)Math.Pow(10, num % 10);
            return res;
        }
    }
}
