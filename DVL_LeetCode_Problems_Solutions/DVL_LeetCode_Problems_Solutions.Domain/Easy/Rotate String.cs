namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Rotate String (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static bool RotateString(string A, string B)
        {
            if (A == B)
                return true;

            for (int i = 0; i < A.Length; i++)
            {
                string str = A.Substring(i) + (i != 0 ? A.Substring(0, i) : "");
                if (str == B)
                    return true;
            }

            return false;
        }
    }
}
