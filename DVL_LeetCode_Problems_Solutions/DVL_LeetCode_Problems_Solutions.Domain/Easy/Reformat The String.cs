using System;
using System.Collections.Generic;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
   {
      /// <summary>
      /// Reformat The String (Mine)
      /// </summary>
      /// <param name="s"></param>
      /// <returns></returns>
      public static string Reformat(string s) 
      {
         var digits = new List<char>();
         var letters = new List<char>();
         foreach (var ch in s)
         {
            if(char.IsDigit(ch))
               digits.Add(ch);
            else letters.Add(ch);
         }

         if (Math.Abs(digits.Count - letters.Count) > 1)
            return string.Empty;
         
         var result = new StringBuilder();
         int digitIndex = 0, letterIndex = 0;
         if (letters.Count > digits.Count)
         {
            result.Append(letters[letterIndex++]);
            while (digitIndex < digits.Count)
            {
               result.Append(digits[digitIndex++]);
               result.Append(letters[letterIndex++]);
            }
         }
         else
         {
            if (digits.Count > letters.Count)
               result.Append(digits[digitIndex++]);
            while (digitIndex < digits.Count)
            {
               result.Append(letters[letterIndex++]);
               result.Append(digits[digitIndex++]);
            }
         }

         return result.ToString();
      }
   }
}