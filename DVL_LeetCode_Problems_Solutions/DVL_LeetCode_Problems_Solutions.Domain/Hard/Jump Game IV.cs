using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Jump Game IV (NOt Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int MinJumps(int[] arr)
        {
            // var dictIndexes = new Dictionary<int, List<int>>();
            // var minSteps = new Dictionary<int, int>();
            // var visited = new Dictionary<int,int>();
            //
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     if (dictIndexes.ContainsKey(arr[i]))
            //         dictIndexes[arr[i]].Add(i);
            //     else dictIndexes.Add(arr[i], new List<int>() {i});
            // }
            //
            // return Dfs();
            //
            // int Dfs(int index = 0, bool jumpByValue = false)
            // {
            //     if (minSteps.ContainsKey(index))
            //         return minSteps[index];
            //     if (index == arr.Length - 1)
            //         return 0;
            //
            //     visited[index] = visited.ContainsKey(index) ? visited[index] + 1 : 1;
            //     
            //     int min = arr.Length - index - 1;
            //     if (index - 1 > 0 && (!visited.TryGetValue(index - 1, out int c) || c == 0))
            //         min = Math.Min(min, 1 + Dfs(index - 1));
            //     if (index + 1 < arr.Length && (!visited.TryGetValue(index + 1, out int count) || count == 0))
            //         min = Math.Min(min, 1 + Dfs(index + 1));
            //     
            //     if (!jumpByValue)
            //         foreach (var ind in dictIndexes[arr[index]])
            //            min = Math.Min(min, 1 + Dfs(ind, true));
            //     
            //     visited[index]--;
            //
            //     return minSteps[index] = min;
            // }
            //Not Mine
            int n = arr.Length;
            var dictIndexes = new Dictionary<int, List<int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dictIndexes.ContainsKey(arr[i]))
                    dictIndexes[arr[i]].Add(i);
                else dictIndexes.Add(arr[i], new List<int>() {i});
            }

            var visited = new bool[n];
            visited[0] = true;
            var queue = new Queue<int>(); 
            queue.Enqueue(0);
            int step = 0;
            while (queue.Count != 0) {
                for (int size = queue.Count; size > 0; --size) {
                    int i = queue.Dequeue();
                    if (i == n - 1) 
                        return step; // Reached to last index
                    var next = dictIndexes[arr[i]];
                    next.Add(i - 1); 
                    next.Add(i + 1);
                    foreach (int j in next) {
                        if (j >= 0 && j < n && !visited[j]) {
                            visited[j] = true;
                            queue.Enqueue(j);
                        }
                    }
                    next.Clear();
                }
                step++;
            }
            
            return 0;
        }
    }
}