using System;
using System.Collections.Generic;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Text Justification (Not mine Solution)
        /// </summary>
        /// <param name="words"></param>
        /// <param name="maxWidth"></param>
        /// <returns></returns>
        public static IList<string> FullJustify(string[] words, int maxWidth)
        {
            int l = 0, curLength = 0, n = words.Length;
            var res = new List<string>();

            for (int i = 0; i <= n; i++)
            {
                /* If end of input or adding a new word to the line exceeds maxWidth */
                if (i == n || curLength + words[i].Length + i - l > maxWidth)
                {
                    int rs = maxWidth - curLength; // Number of remaining spaces                
                    StringBuilder line = new StringBuilder();

                    while (l < i)
                    {
                        line.Append(words[l]);

                        int cs; //Space after the word                    
                        if (l == i - 1)
                            cs = rs; //If last word in the line
                        else if (i == n)
                            cs = 1; //If last line
                        else cs = (int)Math.Ceiling((double)rs / (i - l - 1)); //Distribute spaces, more to left                   

                        rs -= cs; //update remaining spaces                    
                        while (cs-- != 0)
                        {
                            line.Append(" ");
                        }

                        l++;
                    }

                    res.Add(line.ToString());
                    curLength = 0;
                }
                if (i != n) curLength += words[i].Length;
            }
            return res;
        }
    }
}
