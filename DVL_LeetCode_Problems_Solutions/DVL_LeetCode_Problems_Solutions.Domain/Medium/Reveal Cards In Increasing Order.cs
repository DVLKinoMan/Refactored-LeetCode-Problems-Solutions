using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Reveal Cards In Increasing Order (Not Mine)
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        public static int[] DeckRevealedIncreasing(int[] deck)
        {
            int[] arr = new int[deck.Length];
            Array.Sort(deck);
            var queue = new Queue<int>();
            for (int i = 0; i < deck.Length; i++)
                queue.Enqueue(i);

            for (int i = 0; i < deck.Length; i++)
            {
                arr[queue.Dequeue()] = deck[i];
                if (i != deck.Length - 1)
                    queue.Enqueue(queue.Dequeue());
            }

            return arr;
        }
    }
}
