namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Long Pressed Name (Mine)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="typed"></param>
        /// <returns></returns>
        public static bool IsLongPressedName(string name, string typed)
        {
            char prevChar = '4';
            int nameIndex = 0;
            for (int i = 0; i < typed.Length; i++)
            {
                if (nameIndex < name.Length && name[nameIndex] == typed[i])
                {
                    nameIndex++;
                    prevChar = typed[i];
                }
                else if (typed[i] != prevChar)
                    return false;
            }

            return nameIndex == name.Length;
        }
    }
}
