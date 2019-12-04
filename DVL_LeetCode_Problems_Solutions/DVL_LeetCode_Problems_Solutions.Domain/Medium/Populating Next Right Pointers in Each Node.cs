using DVL_LeetCode_Problems_Solutions.Domain.Classes.NodeWithNext;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Populating Next Right Pointers in Each Node (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static Node Connect(Node root)
        {
            if (root != null)
                Rec(root, null);
            return root;

            void Rec(Node currNode, Node next)
            {
                currNode.next = next;
                if (currNode.left == null)
                    return;
                Rec(currNode.left, currNode.right);
                Rec(currNode.right, next?.left);
            }
        }
    }
}
