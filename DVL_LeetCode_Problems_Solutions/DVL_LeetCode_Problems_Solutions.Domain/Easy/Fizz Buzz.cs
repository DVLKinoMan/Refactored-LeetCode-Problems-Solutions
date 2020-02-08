using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Fizz Buzz (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static IList<string> FizzBuzz(int n)
        {
            var list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                switch (i % 3)
                {
                    case 0 when i % 5 == 0:
                        list.Add("FizzBuzz");
                        break;
                    case 0:
                        list.Add("Fizz");
                        break;
                    default:
                    {
                        list.Add(i % 5 == 0 ? "Buzz" : i.ToString());
                        break;
                    }
                }
            }

            return list;
        }
    }
}