using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Day of the Year (Mine)
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static int DayOfYear(string date)
        {
            var arr = date.Split('-');
            var dateTime = new DateTime(int.Parse(arr[0]), int.Parse(arr[1]), int.Parse(arr[2]));
            return dateTime.DayOfYear;
        }
    }
}
