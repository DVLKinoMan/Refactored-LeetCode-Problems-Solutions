using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public class CombinationIterator
        {
            private readonly string _str;
            private readonly int _len;
            private int _index = 0;
            private readonly List<string> _list;

            public CombinationIterator(string characters, int combinationLength)
            {
                this._str = characters;
                this._len = combinationLength;
                this._list = Dfs().ToList();
            }

            public string Next()
            {
                return this._list[this._index++];
            }

            public bool HasNext()
            {
                return this._index < this._list.Count;
            }

            private IEnumerable<string> Dfs()
            {
                foreach (var it in InnerDfs(new StringBuilder()))
                    yield return it;

                IEnumerable<string> InnerDfs(StringBuilder builder, int stIndex = 0, int currLen = 0)
                {
                    if (currLen == this._len)
                    {
                        yield return builder.ToString();
                        yield break;
                    }

                    for (int i2 = stIndex; i2 < this._str.Length; i2++)
                    {
                        builder.Append(this._str[i2]);

                        foreach (var dfs in InnerDfs(builder, i2 + 1, currLen + 1))
                            yield return dfs;

                        builder.Remove(builder.Length - 1, 1);
                    }
                }
            }
        }
    }
}
