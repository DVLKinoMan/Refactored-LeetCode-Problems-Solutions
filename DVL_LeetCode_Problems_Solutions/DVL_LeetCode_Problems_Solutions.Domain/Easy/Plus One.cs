using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Plus One (Mine)
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static int[] PlusOne(int[] digits)
        {
            bool k = true;
            var list = new List<int>();
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int num = digits[i] + System.Convert.ToInt32(k);
                if (num >= 10)
                {
                    num %= 10;
                    k = true;
                }
                else k = false;
                
                list.Add(num);
            }

            if (k)
                list.Add(1);
            list.Reverse();

            return list.ToArray();
        }

        /// <summary>
        /// Plus One (Mine)
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public static int[] PlusOne2(int[] digits)
        {
            int k = 1;
            var list = new List<int>();
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int num = digits[i] + k;
                if (num >= 10)
                {
                    num %= 10;
                    k = 1;
                }
                else k = 0;

                list.Add(num);
            }

            if (k == 1)
                list.Add(k);
            list.Reverse();

            return list.ToArray();
        }
    }
}
