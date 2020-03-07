using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Partition List (Mine)
        /// </summary>
        /// <param name="head"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static ListNode Partition(ListNode head, int x)
        {
            ListNode lessRoot = null, moreRoot = null, lessPointer = null, morePointer = null;
            var current = head;
            while (current != null)
            {
                if (current.val < x)
                {
                    if (lessRoot == null)
                        lessRoot = current;
                    else lessPointer.next = current;
                    lessPointer = current;
                }
                else
                {
                    if (moreRoot == null)
                        moreRoot = current;
                    else morePointer.next = current;
                    morePointer = current;
                }

                current = current.next;
            }

            if (lessPointer != null)
                lessPointer.next = moreRoot;
            if (morePointer != null)
                morePointer.next = null;
            return lessRoot ?? moreRoot;
        }
    }
}