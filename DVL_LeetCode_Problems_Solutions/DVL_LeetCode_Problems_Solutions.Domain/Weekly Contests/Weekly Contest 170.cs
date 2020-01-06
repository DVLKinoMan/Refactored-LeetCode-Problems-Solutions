using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Decrypt String from Alphabet to Integer Mapping (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string FreqAlphabets(string s)
        {
            var indexes = s.Select((ch, i) => (ch, i))
                .Where(t => t.ch == '#')
                .Select(t => t.i)
                .ToList();
            int index = 0;
            var builder = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (index < indexes.Count && i == indexes[index] - 2)
                {
                    builder.Append((char) ('a' + int.Parse(s.Substring(i, 2))));
                    index++;
                    i += 2;
                }
                else builder.Append((char) ('a' + int.Parse(s[i].ToString()) - 1));
            }

            return builder.ToString();
        }

        /// <summary>
        /// Get Watched Videos by Your Friends (Mine - but fix bug from other code)
        /// </summary>
        /// <param name="watchedVideos"></param>
        /// <param name="friends"></param>
        /// <param name="id"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public static IList<string> WatchedVideosByFriends(IList<IList<string>> watchedVideos, int[][] friends, int id,
            int level)
        {
            var result = new Dictionary<string,int>();
            var visitedSet = new HashSet<int>(){id};
            var openList = new List<int>() {id};
            int currLevel = 0;

            //bfs
            while (openList.Count > 0 && currLevel != level)
            {
                var newList = new List<int>();
                foreach (var person in openList)
                foreach (var friend in friends[person])
                    if (!visitedSet.Contains(friend))
                    {
                        newList.Add(friend);
                        visitedSet.Add(friend);
                    }

                openList = newList;
                currLevel++;
            }


            foreach (var watchedVideo in openList.Distinct().SelectMany(friend => watchedVideos[friend]))
                result[watchedVideo] = result.ContainsKey(watchedVideo) ? result[watchedVideo] + 1 : 1;

            return result.OrderBy(r=>r.Value)
                         .ThenBy(r=>r.Key)
                         .Select(r=>r.Key)
                         .ToList();
        }
    }
}
