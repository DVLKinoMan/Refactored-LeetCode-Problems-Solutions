﻿using DVL_LeetCode_Problems_Solutions.Domain.Classes.Node;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// N-ary Tree Level Order Traversal (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (root == null)
                return result;

            var nodeLists = new List<List<Node>>() { new List<Node>() { root } };
            while (nodeLists.Count != 0)
            {
                var nodesInOneLevel = nodeLists.First();
                nodeLists.RemoveAt(0);

                var list = new List<int>();
                var nodesList = new List<Node>();
                foreach (var node in nodesInOneLevel)
                {
                    list.Add(node.val);
                    foreach (var child in node.children)
                        nodesList.Add(child);
                }

                if (nodesList.Count != 0)
                    nodeLists.Add(nodesList);

                result.Add(list);
            }

            return result;
        }
    }
}
