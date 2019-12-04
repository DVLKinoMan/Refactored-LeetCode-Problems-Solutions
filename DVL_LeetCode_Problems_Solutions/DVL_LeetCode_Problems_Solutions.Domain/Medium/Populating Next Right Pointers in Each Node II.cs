using DVL_LeetCode_Problems_Solutions.Domain.Classes.NodeWithNext;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Populating Next Right Pointers in Each Node II (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static Node Connect2(Node root)
        {
            var leftNode = root;
            while (leftNode != null)
            {
                var across = leftNode;
                while (across != null)
                {
                    var nextLeftNode = GetNodeLeftNode(across.next);

                    if (across.left != null)
                        across.left.next = across.right ?? nextLeftNode;
                    if (across.right != null)
                        across.right.next = nextLeftNode;
                    across = across.next;
                }

                leftNode = leftNode.left ?? leftNode.right ?? GetNodeLeftNode(leftNode.next);
            }

            return root;

            Node GetNodeLeftNode(Node nd)
            {
                var f = nd;
                while (f != null)
                {
                    var res = f.left ?? f.right;
                    if (res != null)
                        return res;
                    f = f.next;
                }

                return null;
            }
        }
    }
}
