using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find Median from Data Stream (Mine)
        /// </summary>
        public class MedianFinder
        {
            private readonly List<int> _list;

            public MedianFinder()
            {
                _list = new List<int>();
            }

            //Insertion Sort
            public void AddNum(int num)
            {
                int len = _list.Count;
                int st = 0, end = len;
                while (st < end)
                {
                    int cur = (st + end) / 2;
                    if (_list[cur] > num)
                        end = cur;
                    else st = cur + 1;
                }
                _list.Insert(st, num);
            }

            public double FindMedian()
            {
                if (_list.Count % 2 == 1)
                    return _list[_list.Count / 2];

                return (double)(_list[_list.Count / 2] + _list[_list.Count / 2 - 1]) / 2;
            }
        }
    }
}
