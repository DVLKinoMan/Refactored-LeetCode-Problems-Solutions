namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Boats to Save People (My Solution)
        /// </summary>
        /// <param name="people"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public static int NumRescueBoats(int[] people, int limit)
        {
            int count = 0;
            int[] arr = new int[limit];
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] == limit)
                    count++;
                else if (arr[people[i]] != 0)
                {
                    count++;
                    arr[people[i]]--;
                }
                else arr[limit - people[i]]++;
            }

            int startIndex = 0;
            while (startIndex < limit && arr[startIndex] == 0)
                startIndex++;

            int endIndex = limit - 1;
            while (endIndex >= 0 && arr[endIndex] == 0)
                endIndex--;

            while (startIndex != limit)
            {
                arr[startIndex]--;
                count++;
                if (arr[endIndex] != 0 && limit - startIndex + (limit - endIndex) <= limit)
                    arr[endIndex]--;
                while (startIndex < limit && arr[startIndex] == 0)
                    startIndex++;
                while (endIndex >= 0 && arr[endIndex] == 0)
                    endIndex--;
            }

            return count;
        }
    }
}
