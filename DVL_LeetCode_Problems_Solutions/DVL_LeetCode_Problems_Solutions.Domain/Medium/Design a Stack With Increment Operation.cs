namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Design a Stack With Increment Operation (Mine)
        /// </summary>
        public class CustomStack
        {
            private class StackNode
            {
                public int Value;
                public StackNode Next;
                public StackNode Previous;

                public StackNode(int value)
                {
                    Value = value;
                }
            }

            private int _currSize = 0;
            private int _maxSize;
            private StackNode _bottom;
            private StackNode _top;

            public CustomStack(int maxSize)
            {
                _maxSize = maxSize;
            }

            public void Push(int x)
            {
                if (_currSize == _maxSize)
                    return;

                var node = new StackNode(x);
                if (_top != null)
                    _top.Next = node;
                if (_bottom == null)
                    _bottom = node;
                node.Previous = _top;

                _top = node;
                _currSize++;
            }

            public int Pop()
            {
                if (_currSize == 0)
                    return -1;

                var res = _top.Value;
                _top = _top.Previous;
                if (_top != null)
                    _top.Next = null;
                else _bottom = null;
                _currSize--;

                return res;
            }

            public void Increment(int k, int val)
            {
                int count = 1;
                var curr = _bottom;
                while (count <= k && count <= _currSize)
                {
                    curr.Value += val;
                    curr = curr.Next;
                    count++;
                }
            }
        }
    }
}