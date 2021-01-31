namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Candy (Mine)
        /// </summary>
        /// <param name="ratings"></param>
        /// <returns></returns>
        public static int Candy(int[] ratings)
        {
            if (ratings.Length == 0)
                return 0;
            if (ratings.Length == 1)
                return 1;

            int min = 1, prevCandy = 1;
            for (int i = 1; i < ratings.Length; i++)
            {
                if (ratings[i] > ratings[i - 1])
                    min += prevCandy += 1;
                else if (ratings[i] == ratings[i - 1])
                    min += prevCandy = 1;
                else
                {
                    int count = 0;
                    while (i < ratings.Length && ratings[i] < ratings[i - 1])
                    {
                        count++;
                        i++;
                    }

                    min += count % 2 == 1 ? (1 + count) / 2 : 0;
                    min += (1 + count) * (count / 2);
                    min += prevCandy <= count ? count + 1 - prevCandy : 0;
                    prevCandy = 1;
                    i--;
                }
            }

            return min;
        }
    }
}
