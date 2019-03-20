using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Multiply Strings
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";

            int[] arr = num1.Select(ch => ch - '0').ToArray();
            var lists=new List<List<int>>();
            foreach (var ch in num2)
                lists.Add(MultiplyArrayAndDigit(arr, ch));

            var tempList = lists.First();
            for (int i = 1; i < lists.Count; i++)
            {
                int f = lists[i].Last();
                lists[i].RemoveAt(lists[i].Count - 1);
                tempList = AddTwoLists(tempList, lists[i]);
                tempList.Add(f);
            }
            
            return string.Join("", tempList);
        }

        private static List<int> MultiplyArrayAndDigit(int[] arr, char ch)
        {
            if (ch == '0')
                return new List<int> {0};

            var result = new List<int>();
            int digit = ch - '0';
            int plus = 0;
            foreach (var dig in arr.Reverse())
            {
                int temp = dig * digit + plus;
                result.Add(temp % 10);
                plus = temp / 10;
            }

            if (plus != 0)
                result.Add(plus);

            result.Reverse();
            return result.ToList();
        }

        private static List<int> AddTwoLists(List<int> nums1, List<int> nums2)
        {
            var result = nums1.Count > nums2.Count ? nums1 : nums2;
            int temp = 0;
            for (int i = 1; i <= result.Count; i++)
            {
                int k = 0;
                if (nums1.Count - i < 0)
                    k = nums2[result.Count - i] + temp;
                else if (nums2.Count - i < 0)
                    k = nums1[result.Count - i] + temp;
                else
                    k = nums1[nums1.Count - i] + nums2[nums2.Count - i] + temp;
                result[result.Count - i] = k % 10;
                temp = k / 10;
            }

            if(temp!=0)
                result.Insert(0,temp);

            return result;
        }
    }
}
