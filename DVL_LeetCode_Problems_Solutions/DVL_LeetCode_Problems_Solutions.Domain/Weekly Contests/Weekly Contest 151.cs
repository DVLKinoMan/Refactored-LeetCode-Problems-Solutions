using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static IList<string> InvalidTransactions(string[] transactions) {
            var list = new List<string>();
            var dic = new Dictionary<string,List<(string city, int min, int amount)>>();
            for (int i = 0; i < transactions.Length; i++)
            {
                var arr = transactions[i].Split(',');
                string name = arr[0], city = arr[3];
                int amount = int.Parse(arr[2]), min = int.Parse(arr[1]);

                if (dic.ContainsKey(name))
                    dic[name].Add((city, min, amount));
                else dic.Add(name, new List<(string city, int min, int amount)>{(city, min, amount)});
            }

            int len = list.Count;
            foreach(var d in dic)
                for (int i = 0; i < d.Value.Count; i++)
                {
                    var transaction = d.Value[i];
                    if (transaction.amount>1000 || d.Value.Where((t,ind)=>ind!=i && Math.Abs(t.min - transaction.min) <= 60 && t.city != transaction.city).Count()>0)
                        list.Add($"{d.Key},{transaction.min},{transaction.amount},{transaction.city}");
                }

            return list;
        }

        public static int[] NumSmallerByFrequency(string[] queries, string[] words)
        {
            int[] result = new int[queries.Length];
            int[] arr = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
                arr[i] = f(words[i]);

            for (int i=0;i<queries.Length;i++)
            {
                int ans = f(queries[i]);
                result[i]=arr.Count(num => ans < num);
            }

            return result;

            int f(string s)
            {
                var dic = new Dictionary<char,int>();
                char smallest = 'z';
                foreach (var ch in s)
                {
                    smallest = smallest > ch ? ch : smallest;
                    if (dic.ContainsKey(ch))
                        dic[ch]++;
                    else dic.Add(ch, 1);
                }

                return dic[smallest];
            }
        }
    }
}
