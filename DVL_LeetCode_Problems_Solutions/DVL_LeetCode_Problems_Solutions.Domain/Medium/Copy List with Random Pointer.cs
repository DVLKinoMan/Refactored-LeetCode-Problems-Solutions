using System.Collections.Generic;
using DVL_LeetCode_Problems_Solutions.Domain.Classes.NodeWithRandom;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    

    partial class ProblemSolver
    {
        /// <summary>
        /// Copy List with Random Pointer (Mine)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static Node CopyRandomList(Node head)
        {
            if (head == null)
                return null;

            var listOfNodes = new List<Node>();
            var listOfNewNodes = new List<Node>();
            var currNode = head;

            while (currNode != null)
            {
                listOfNodes.Add(currNode);
                listOfNewNodes.Add(new Node { val = currNode.val });
                currNode = currNode.next;
            }

            for (int i = 0; i < listOfNewNodes.Count; i++)
            {
                if (i != listOfNewNodes.Count - 1)
                    listOfNewNodes[i].next = listOfNewNodes[i + 1];
                listOfNewNodes[i].random = listOfNodes[i].random == null
                    ? null
                    : listOfNewNodes[listOfNodes.IndexOf(listOfNodes[i].random)];
            }

            return listOfNewNodes[0];
        }
    }
}
