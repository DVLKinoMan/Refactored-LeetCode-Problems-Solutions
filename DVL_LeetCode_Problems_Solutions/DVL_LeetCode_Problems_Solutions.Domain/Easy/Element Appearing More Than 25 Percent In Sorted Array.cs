namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Element Appearing More Than 25% In Sorted Array (Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FindSpecialInteger(int[] arr)
        {
            int len = arr.Length / 4;
            for (int i = len; i < arr.Length; i++)
                if (arr[i] == arr[i - len])
                    return arr[i];

            return arr[arr.Length - 1];
        }
    }
}
