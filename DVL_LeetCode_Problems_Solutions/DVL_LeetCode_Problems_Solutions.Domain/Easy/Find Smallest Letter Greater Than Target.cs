namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find Smallest Letter Greater Than Target (Mine)
        /// </summary>
        /// <param name="letters"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static char NextGreatestLetter(char[] letters, char target)
        {
            //char minChar = char.MaxValue, firstMax = char.MaxValue;
            //foreach (var letter in letters)
            //{
            //    minChar = minChar < letter ? minChar : letter;
            //    if (letter > target && letter < firstMax)
            //        firstMax = letter;
            //}

            //return firstMax != char.MaxValue ? firstMax : minChar;

            int a = 0, b = letters.Length - 1;
            while (a < b)
            {
                int mid = (a + b) / 2;
                if (letters[mid] > target)
                    b = mid - 1;
                else a = mid + 1;
            }

            if (b < 0)
                return letters[0];

            return letters[b] > target ? letters[b] : letters[b + 1 == letters.Length ? 0 : b + 1];
        }
    }
}
