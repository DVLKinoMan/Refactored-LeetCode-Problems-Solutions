using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
   {
       /// <summary>
       /// Angle Between Hands of a Clock (Mine)
       /// </summary>
       /// <param name="hour"></param>
       /// <param name="minutes"></param>
       /// <returns></returns>
      public static double AngleClock(int hour, int minutes)
      {
          hour %= 12;
          double part = (double)minutes / 60;
          double hourArrow = hour * 5 + 5 * part;
          double diff = Math.Abs(hourArrow - minutes);
          double min = Math.Min(diff, 60 - diff);
          return 360 * (min / 60);
      }
   }
}