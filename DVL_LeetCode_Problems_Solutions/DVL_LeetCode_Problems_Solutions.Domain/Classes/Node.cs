using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain.Classes
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node()
        {
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}