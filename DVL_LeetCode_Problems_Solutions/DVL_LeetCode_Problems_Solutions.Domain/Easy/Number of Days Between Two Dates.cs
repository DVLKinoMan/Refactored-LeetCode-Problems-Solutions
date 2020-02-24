using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
   {
      /// <summary>
      /// Number of Days Between Two Dates (Mine)
      /// </summary>
      /// <param name="date1"></param>
      /// <param name="date2"></param>
      /// <returns></returns>
      public static int DaysBetweenDates(string date1, string date2)
      {
         var firstDate =  DateTime.ParseExact(date1, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
         var secondDate =  DateTime.ParseExact(date2, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

         return Math.Abs(secondDate.Subtract(firstDate).Days);
      }
   }
}