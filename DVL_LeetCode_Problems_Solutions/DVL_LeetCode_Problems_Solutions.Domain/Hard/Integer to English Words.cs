using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Integer to English Words (Mine)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string NumberToWords(int num)
        {
            if (num == 0)
                return "Zero";

            var units = new[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            var teens = new[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            var tens = new[]
            {
                "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty",
                "Ninety"
            };
            var hundreds = new[] { "Thousand", "Million", "Billion" };

            int  count = -1;
            var builder = new StringBuilder();
            while (num != 0)
            {
                int k = num % 1000;
                int unit = k % 10;
                int ten = k % 100 - (unit * 10);
                int hundred = k / 100;

                if (count != -1 && (hundred != 0 || unit != 0 || ten != 0))
                    builder.Insert(0, hundreds[count] + " ");

                if (ten == 1)
                    builder.Insert(0, teens[unit] + " ");
                else
                {
                    if (unit != 0)
                        builder.Insert(0, units[unit - 1] + " ");
                    if (ten != 0)
                        builder.Insert(0, tens[ten - 2] + " ");
                }

                if (hundred != 0)
                    builder.Insert(0, units[hundred - 1] + " Hundred ");

                count++;
                num /= 1000;
            }

            return builder.ToString().TrimEnd();
        }
    }
}
