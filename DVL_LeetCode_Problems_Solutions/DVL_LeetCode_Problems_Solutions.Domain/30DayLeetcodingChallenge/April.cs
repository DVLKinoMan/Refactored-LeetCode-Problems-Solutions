using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Single Number (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SingleNumber(int[] nums)
        {
            int k = 0;
            foreach (var num in nums)
                k ^= num;
            return k;
        }

        /// <summary>
        /// Happy Number (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsHappy(int n)
        {
            var set = new HashSet<int>();
            while (set.Add(n) && n != 1)
                n = Sum(n);

            return n == 1;

            int Sum(int k)
            {
                int res = 0;
                while (k != 0)
                {
                    res += (int) Math.Pow(k % 10, 2);
                    k /= 10;
                }

                return res;
            }
        }

        /// <summary>
        /// Maximum Subarray (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaxSubArray(int[] nums)
        {
            int currSum = nums[0], maxSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (currSum + nums[i] < nums[i])
                    currSum = nums[i];
                else currSum += nums[i];
                maxSum = Math.Max(maxSum, currSum);
            }

            return maxSum;
        }

        // public static void MoveZeroes(int[] nums) {
        //     int lastZeroIndex = nums.Length;
        //     for (int i = 0; i < lastZeroIndex; i++)
        //         if (nums[i] == 0)
        //         {
        //             int i2 = i;
        //             while (i2 != lastZeroIndex - 1)
        //             {
        //                 //swap
        //                 nums[i2 + 1] += nums[i2];
        //                 nums[i2] = nums[i2 + 1] - nums[i2];
        //                 nums[i2 + 1] -= nums[i2];
        //                 i2++;
        //             }
        //
        //             lastZeroIndex--;
        //             i--;
        //         }
        // }

        /// <summary>
        /// Best Time to Buy and Sell Stock II (Not Mine)
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit2(int[] prices)
        {
            int total = 0;
            for (int i = 0; i < prices.Length - 1; i++)
                if (prices[i + 1] > prices[i])
                    total += prices[i + 1] - prices[i];

            return total;
        }

        // public static IList<IList<string>> GroupAnagrams(string[] strs) {
        //     var dic=new Dictionary<string, List<string>>();
        //     foreach (var str in strs)
        //     {
        //         var strSorted = String.Concat(str.OrderBy(s => s));
        //         if (dic.ContainsKey(strSorted))
        //             dic[strSorted].Add(str);
        //         else dic.Add(strSorted, new List<string> { str });
        //     }
        //
        //     var result = new List<IList<string>>();
        //     foreach (var d in dic)
        //         result.Add(d.Value);
        //
        //     return result;
        // }

        /// <summary>
        /// Counting Elements (Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int CountElements(int[] arr)
        {
            var counts = new int[1001];
            foreach (var num in arr)
                counts[num]++;

            int count = 0;
            for (int i = 0; i < counts.Length - 1; i++)
                if (counts[i] != 0 && counts[i + 1] != 0)
                    count += counts[i];

            return count;
        }

        /// <summary>
        /// Backspace String Compare (Mine)
        /// </summary>
        /// <param name="S"></param>
        /// <param name="T"></param>
        /// <returns></returns>
        public static bool BackspaceCompare(string S, string T)
        {
            return GetString(S) == GetString(T);

            string GetString(string str)
            {
                var builder = new StringBuilder();
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '#')
                    {
                        if (builder.Length != 0)
                            builder.Remove(builder.Length - 1, 1);
                    }
                    else builder.Append(str[i]);
                }

                return builder.ToString();
            }
        }

        /// <summary>
        /// Min Stack (Mine)
        /// </summary>
        public class MinStack
        {
            private Stack<int> _originalStack;
            private Stack<int> _minStack;

            /** initialize your data structure here. */
            public MinStack()
            {
                _originalStack = new Stack<int>();
                _minStack = new Stack<int>();
            }

            public void Push(int x)
            {
                _originalStack.Push(x);
                _minStack.Push(_minStack.Count == 0 ? x : Math.Min(_minStack.Peek(), x));
            }

            public void Pop()
            {
                _originalStack.Pop();
                _minStack.Pop();
            }

            public int Top()
            {
                return _originalStack.Peek();
            }

            public int GetMin()
            {
                return _minStack.Peek();
            }
        }

        /// <summary>
        ///  Contiguous Array (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindMaxLength(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] == 0)
                    nums[i] = -1;

            var sumToIndex = new Dictionary<int, int> {{0, -1}};
            int sum = 0, max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sumToIndex.ContainsKey(sum))
                    max = Math.Max(max, i - sumToIndex[sum]);
                else
                    sumToIndex[sum] = i;
            }

            return max;
        }

        /// <summary>
        /// Perform String Shifts (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        public static string StringShift(string s, int[][] shift)
        {
            int shiftNum = 0;
            foreach (var sh in shift)
            {
                if (sh[0] == 0)
                    shiftNum -= sh[1];
                else shiftNum += sh[1];
            }

            if (shiftNum % s.Length == 0)
                return s;

            var builder = new StringBuilder();
            int ind = shiftNum < 0 ? Math.Abs(shiftNum) % s.Length : s.Length - shiftNum % s.Length;
            int j = ind;
            do
            {
                builder.Append(s[j]);
                j = j == s.Length - 1 ? 0 : j + 1;
            } while (j != ind);

            return builder.ToString();
        }

        /// <summary>
        /// Valid Parenthesis String (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool CheckValidString(string s)
        {
            return Check();

            bool Check(int index = 0, int k = 0)
            {
                if (index == s.Length)
                    return k == 0;

                if (s[index] == ')')
                {
                    if (k <= 0)
                        return false;
                    return Check(index + 1, k - 1);
                }

                if (s[index] == '(')
                    return Check(index + 1, k + 1);

                return Check(index + 1, k - 1) ||
                       Check(index + 1, k + 1) ||
                       Check(index + 1, k);
            }
        }

        /// <summary>
        /// Leftmost Column with at Least a One (Mine)
        /// </summary>
        /// <param name="binaryMatrix"></param>
        /// <returns></returns>
        public static int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
        {
            var list = binaryMatrix.Dimensions();
            int m = list[0], n = list[1];
            int st = 0, end = n - 1, res = int.MaxValue;
            while (st <= end)
            {
                int mid = (st + end) / 2;
                if (RightColumn(mid))
                {
                    end = mid - 1;
                    res = mid;
                }
                else st = mid + 1;
            }

            return res == int.MaxValue ? -1 : res;

            bool RightColumn(int col)
            {
                for (int i = 0; i < m; i++)
                    if (binaryMatrix.Get(i, col) == 1)
                        return true;

                return false;
            }
        }

        /// <summary>
        /// LRU Cache (Mine)
        /// </summary>
        public class LRUCache
        {
            private Dictionary<int, int> _dict;
            private int _capacity;
            private int _currSize;
            private List<int> _recentlyUsedKeys;

            public LRUCache(int capacity)
            {
                _capacity = capacity;
                _currSize = 0;
                _recentlyUsedKeys = new List<int>();
                _dict = new Dictionary<int, int>();
            }

            public int Get(int key)
            {
                if (!_dict.ContainsKey(key))
                    return -1;
                _recentlyUsedKeys.Remove(key);
                _recentlyUsedKeys.Add(key);
                return _dict[key];
            }

            public void Put(int key, int value)
            {
                if (_capacity == _currSize && !_dict.ContainsKey(key))
                {
                    _currSize--;
                    _dict.Remove(_recentlyUsedKeys[0]);
                    _recentlyUsedKeys.RemoveAt(0);
                }

                if (!_dict.ContainsKey(key))
                    _currSize++;
                _dict[key] = value;
                _recentlyUsedKeys.Remove(key);
                _recentlyUsedKeys.Add(key);
            }
        }

        public static bool CanJump2(int[] nums)
        {
            if (nums.Length <= 1)
                return true;

            int zeroIndex = -1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (zeroIndex == -1 && nums[i] == 0)
                    zeroIndex = i;
                else if (zeroIndex != -1 && nums[i] > zeroIndex - i)
                    zeroIndex = -1;
            }

            return zeroIndex == -1;
        }

        /// <summary>
        ///   First Unique Number (Mine)
        /// </summary>
        public class FirstUnique
        {
            private Queue<int> _queue = new Queue<int>();
            private HashSet<int> _notUniqueSet = new HashSet<int>();
            private HashSet<int> _addedNums = new HashSet<int>();

            public FirstUnique(int[] nums)
            {
                foreach (var num in nums)
                    Add(num);
            }

            public int ShowFirstUnique()
            {
                while (_queue.Count != 0 && _notUniqueSet.Contains(_queue.Peek()))
                    _queue.Dequeue();

                return _queue.Count == 0 ? -1 : _queue.Peek();
            }

            public void Add(int value)
            {
                _queue.Enqueue(value);
                if (!_addedNums.Add(value))
                    _notUniqueSet.Add(value);
            }
        }
        
        /// <summary>
        /// Binary Tree Maximum Path Sum (Not Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int MaxPathSum(TreeNode root)
        {
            int maxValue = 0;
            MaxSum(root);
            return maxValue;

            int MaxSum(TreeNode node)
            {
                if (node == null)
                    return 0;
                
                int left = Math.Max(0, MaxSum(node.left));
                int right = Math.Max(0, MaxSum(node.right));

                maxValue = Math.Max(maxValue, left + right + node.val);

                return Math.Max(left, right) + node.val;
            }
        }
    }
}