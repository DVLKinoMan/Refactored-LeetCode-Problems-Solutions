using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Defanging an IP Address (Mine)
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static string DefangIPaddr(string address) => address.Replace(".", "[.]");

        /// <summary>
        /// Corporate Flight Bookings (Not Mine)
        /// </summary>
        /// <param name="bookings"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] CorpFlightBookings(int[][] bookings, int n)
        {
            int[] res = new int[n];
            foreach (var booking in bookings)
            {
                res[booking[0] - 1] += booking[2];
                if (booking[1] < n)
                    res[booking[1]] -= booking[2];
            }

            for (int i = 1; i < n; i++)
                res[i] += res[i - 1];

            return res;
        }

        /// <summary>
        /// Delete Node And Return Forest (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="to_delete"></param>
        /// <returns></returns>
        public static IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            var roots = new List<TreeNode>();
            DelNodesHelper(root, to_delete, roots, true, null);
            return roots;
        }

        private static void DelNodesHelper(TreeNode root, int[] to_delete, List<TreeNode> roots, bool isRoot, TreeNode parent, bool isLeft = true)
        {
            if (root == null)
                return;

            if (to_delete.Contains(root.val))
            {
                if (parent != null)
                {
                    if (isLeft)
                        parent.left = null;
                    else
                        parent.right = null;
                }

                DelNodesHelper(root.left, to_delete, roots, true, root);
                DelNodesHelper(root.right, to_delete, roots, true, root, false);
                return;
            }

            if(isRoot)
                roots.Add(root);

            DelNodesHelper(root.left, to_delete, roots, false, root);
            DelNodesHelper(root.right, to_delete, roots, false, root, false);
        }
    }
}
