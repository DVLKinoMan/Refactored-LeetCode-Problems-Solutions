using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Implement Queue using Stacks (Mine)
        /// </summary>
        public class MyQueue
        {
            private Stack<int> _stack;
            private Stack<int> _reversedStack;

            /** Initialize your data structure here. */
            public MyQueue()
            {
                _stack = new Stack<int>();
                _reversedStack = new Stack<int>();
            }

            /** Push element x to the back of queue. */
            public void Push(int x)
            {
                while(_reversedStack.Count!=0)
                    _stack.Push(_reversedStack.Pop());
                _stack.Push(x);
            }

            /** Removes the element from in front of queue and returns that element. */
            public int Pop()
            {
                while(_stack.Count!=0)
                    _reversedStack.Push(_stack.Pop());
                return _reversedStack.Pop();
            }

            /** Get the front element. */
            public int Peek()
            {
                while(_stack.Count!=0)
                    _reversedStack.Push(_stack.Pop());
                return _reversedStack.Peek();
            }

            /** Returns whether the queue is empty. */
            public bool Empty()
            {
                return _stack.Count == 0 && _reversedStack.Count == 0;
            }
        }
    }
}