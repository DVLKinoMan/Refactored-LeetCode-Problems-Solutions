using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain.Medium
{
    partial class ProblemSolver
    {
        public static int MinHeightShelves(int[][] books, int shelf_width)
        {
            var booksList = books.OrderByDescending(b => b[1]).ToList();
            int sumHeight = 0, maxHeightInShelf = 0, widthInShelf = 0;
            while (booksList.Count != 0)
            {
                var book = booksList.First();
                widthInShelf += book[0];
                if (widthInShelf > shelf_width)
                {
                    sumHeight += maxHeightInShelf;
                    maxHeightInShelf = 0;
                    widthInShelf = 0;
                    continue;
                }

                maxHeightInShelf = Math.Max(maxHeightInShelf, book[1]);
                booksList.RemoveAt(0);
            }

            sumHeight += maxHeightInShelf;

            return sumHeight;
        }
    }
}
