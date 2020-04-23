using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// The k-th Lexicographical String of All Happy Strings of Length n (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static string GetHappyString(int n, int k)
        {
            var arr = new char[]{'a', 'b', 'c'};
            int count = 0;
            return Rec(new StringBuilder()).ToString();
            
            StringBuilder Rec(StringBuilder str)
            {
                if (str.Length == n)
                {
                    count++;
                    return str;
                }

                for (int i = 0; i < arr.Length; i++)
                    if (str.Length == 0 || str[str.Length - 1] != arr[i])
                    {
                        str.Append(arr[i]);
                        Rec(str);
                        if (count == k)
                            return str;
                        str.Remove(str.Length - 1, 1);
                    }

                return new StringBuilder();
            }
        }
    }
}