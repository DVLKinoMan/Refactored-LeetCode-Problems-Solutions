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
            char minChar = char.MaxValue, firstMax = char.MaxValue;
            foreach (var letter in letters)
            {
                minChar = minChar < letter ? minChar : letter;
                if (letter > target && letter < firstMax)
                    firstMax = letter;
            }

            return firstMax != char.MaxValue ? firstMax : minChar;
        }
    }
}
