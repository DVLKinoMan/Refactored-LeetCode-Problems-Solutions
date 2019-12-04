namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }

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
