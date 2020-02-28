using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Validate Stack Sequences (Mine)
        /// </summary>
        /// <param name="pushed"></param>
        /// <param name="popped"></param>
        /// <returns></returns>
        public static bool ValidateStackSequences(int[] pushed, int[] popped) {
            int pushedIndex = 0, poppedIndex = 0, n = pushed.Length;
            
            if (n == 0)
                return true;
            
            var stack = new Stack<int>();
            stack.Push(pushed[pushedIndex++]);
            while (pushedIndex != n || poppedIndex != n)
            {
                if (poppedIndex < n && stack.Count > 0 && popped[poppedIndex] == stack.Peek())
                {
                    stack.Pop();
                    poppedIndex++;
                }
                else if (pushedIndex >= n)
                    return false;
                else stack.Push(pushed[pushedIndex++]);
            }

            return true;
        } 
    }
}