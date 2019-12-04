using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Delete Node in a BST (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static TreeNode DeleteNode(TreeNode root, int key)
        {
            var currNode = root;
            TreeNode parentNode = null;
            while (currNode != null)
            {
                if (currNode.val == key)
                    break;
                parentNode = currNode;
                currNode = currNode.val < key ? currNode.right : currNode.left;
            }

            if (currNode == null)
                return root;

            if (parentNode == null)
            {
                if (currNode.left == null)
                    return currNode.right;
                if (currNode.right == null)
                    return currNode.left;

                var mostRight = currNode.left;
                while (mostRight.right != null)
                    mostRight = mostRight.right;
                mostRight.right = currNode.right;
                return currNode.left;
            }


            bool isLeft = parentNode.left == currNode;
            if (isLeft)
            {
                if (currNode.left == null)
                    parentNode.left = currNode.right;
                else
                {
                    parentNode.left = currNode.left;
                    var mostRight = currNode.left;
                    while (mostRight.right != null)
                        mostRight = mostRight.right;
                    mostRight.right = currNode.right;
                }
            }
            else
            {
                if (currNode.right == null)
                    parentNode.right = currNode.left;
                else
                {
                    parentNode.right = currNode.right;
                    var mostLeft = currNode.right;
                    while (mostLeft.left != null)
                        mostLeft = mostLeft.left;
                    mostLeft.left = currNode.left;
                }
            }

            return root;
        }
    }
}
