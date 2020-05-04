namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Max Difference You Can Get From Changing an Integer (Mine)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int MaxDiff(int num)
        {
            int max, min;
            string str = num.ToString();
            char charToChange = ' ';
            for (int i = 0; i < str.Length; i++)
                if (str[i] != '9')
                {
                    charToChange = str[i];
                    break;
                }

            max = int.Parse(charToChange != ' ' ? str.Replace(charToChange, '9') : str);
            
            charToChange = ' ';
            if (str[0] != '1')
                min = int.Parse(str.Replace(str[0], '1'));
            else
            {
                for (int i = 1; i < str.Length; i++)
                    if (str[i] != '1' && str[i] != '0')
                    {
                        charToChange = str[i];
                        break;
                    }

                min = int.Parse(charToChange == ' ' ? str : str.Replace(charToChange, '0'));
            }

            return max - min;
        }
    }
}