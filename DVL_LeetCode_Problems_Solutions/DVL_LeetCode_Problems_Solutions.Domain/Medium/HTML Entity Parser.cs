using System.Collections.Generic;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
   partial class ProblemSolver
   {
      /// <summary>
      /// HTML Entity Parser (Mine)
      /// </summary>
      /// <param name="text"></param>
      /// <returns></returns>
      public static string EntityParser(string text) 
      {
         var dict = new Dictionary<string, char>()
         {
            {"&quot;", '"'},
            {"&apos;", '\''},
            {"&amp;", '&'},
            {"&gt;", '>'},
            {"&lt;", '<'},
            {"&frasl;", '/'}
         };
         
         var builder = new StringBuilder();
         int stIndex = -1;
         for (int i = 0; i < text.Length; i++)
         {
            if (text[i] == '&')
            {
               if (stIndex != -1)
                  builder.Append(text.Substring(stIndex, i - stIndex));
               stIndex = i;
            }
            else if (text[i] == ';' && stIndex != -1)
            {
               string str = text.Substring(stIndex, i - stIndex + 1);
               if (dict.TryGetValue(str, out var val))
                  builder.Append(val);
               else builder.Append(str);
               stIndex = -1;
            }
            else if(stIndex == -1)
               builder.Append(text[i]);
         }

         if (stIndex != -1)
            builder.Append(text.Substring(stIndex));
         
         return builder.ToString();
      }
   }
}