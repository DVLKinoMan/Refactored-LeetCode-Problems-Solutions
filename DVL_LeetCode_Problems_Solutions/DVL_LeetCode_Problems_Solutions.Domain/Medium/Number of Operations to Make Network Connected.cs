namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Number of Operations to Make Network Connected (Not Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="connections"></param>
        /// <returns></returns>
        public static int MakeConnected(int n, int[][] connections)
        {
            //My version (not working)
            //var dict = new Dictionary<int, int>();
            //int extra = 0, lastIndex = 0;
            //foreach (var connection in connections)
            //{
            //    int a = connection[0], b = connection[1];
            //    if (dict.ContainsKey(a))
            //    {
            //        if (dict.ContainsKey(b))
            //        {
            //            if (dict[a] == dict[b])
            //                extra++;
            //            else
            //            {
            //                int val = dict[b];
            //                foreach (var item in dict.Where(k => k.Value == val))
            //                    dict[item.Key] = dict[a];
            //            }
            //        }
            //        else
            //            dict.Add(b, dict[a]);
            //    }
            //    else
            //    {
            //        if (dict.ContainsKey(b))
            //        {
            //            if (dict.ContainsKey(a))
            //            {
            //                if (dict[a] == dict[b])
            //                    extra++;
            //                else
            //                {
            //                    int val = dict[a];
            //                    var l = dict.Where(k => k.Value == val).ToList();
            //                    foreach (var item in l)
            //                        dict[item.Key] = dict[b];
            //                }
            //            }
            //            else
            //                dict.Add(a, dict[b]);
            //        }
            //        else
            //        {
            //            dict.Add(a, lastIndex);
            //            dict.Add(b, lastIndex);
            //            lastIndex++;
            //        }
            //    }
            //}

            //int prevExtra = extra;
            //for (int i = 1; i < n; i++)
            //    if (!dict.ContainsKey(i))
            //    {
            //        if (extra > 0)
            //            extra--;
            //        else return -1;
            //    }

            //return prevExtra - extra;
           

            int[] parent = new int[n];
            for (int i = 0; i < n; i++)
                parent[i] = i;
            int m = connections.Length, components = 0, extraEdge = 0;
            for (int i = 0; i < m; i++)
            {
                int p1 = FindParent(parent, connections[i][0]);
                int p2 = FindParent(parent, connections[i][1]);
                if (p1 == p2) 
                    extraEdge++;
                else parent[p1] = p2;
            }

            for (int i = 0; i < n; i++)
                if (parent[i] == i)
                    components++;
            return (extraEdge >= components - 1) ? components - 1 : -1; 
            
            int FindParent(int[] par, int i)
            {
                if (par[i] == i)
                    return i;
                return par[i] = FindParent(par, par[i]);
            }
        }
    }
}
