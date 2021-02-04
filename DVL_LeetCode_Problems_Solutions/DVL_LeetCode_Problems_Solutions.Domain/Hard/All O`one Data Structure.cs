using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// All O`one Data Structure (Not Mine, but mine was the same with some bug)
        /// </summary>
        public class AllOne
        {
            public class Node
            {
                public Node prev;
                public Node next;
                public string key;
                public int val;
                public Node(string k, int v)
                {
                    this.key = k;
                    this.val = v;
                }
            }
            public Dictionary<string, Node> cache;
            public Node head;
            public Node tail;

            /** Initialize your data structure here. */
            public AllOne()
            {
                cache = new Dictionary<string, Node>();
                head = new Node("", 0);
                tail = new Node("", 0);
                head.next = tail;
                tail.prev = head;
            }

            /** Inserts a new key <Key> with value 1. Or increments an existing key by 1. */
            public void Inc(string key)
            {
                Node newNode;
                if (!cache.ContainsKey(key))
                {
                    newNode = new Node(key, 1);
                    cache[key] = newNode;
                    newNode.next = head.next;
                    head.next.prev = newNode;
                    newNode.prev = head;
                    head.next = newNode;
                }
                else
                {
                    newNode = cache[key];
                    newNode.val += 1;
                    Node curr = newNode;
                    while (curr.next != null && curr.next.val != 0)
                    {
                        if (curr.next.val < curr.val)
                        {
                            int tempval = curr.next.val;
                            string tempstr = curr.next.key;
                            curr.next.val = curr.val;
                            curr.val = tempval;
                            curr.next.key = curr.key;
                            curr.key = tempstr;
                            cache[curr.key] = curr;
                            cache[curr.next.key] = curr.next;
                            curr = curr.next;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            /** Decrements an existing key by 1. If Key's value is 1, remove it from the data structure. */
            public void Dec(string key)
            {
                if (!cache.ContainsKey(key))
                {
                    return;
                }
                else
                {
                    Node theNode = cache[key];
                    if (theNode.val == 1)
                    {
                        cache.Remove(key);
                        theNode.prev.next = theNode.next;
                        theNode.next.prev = theNode.prev;
                    }
                    else
                    {
                        theNode.val -= 1;
                        Node curr = theNode;
                        while (curr.prev != null && curr.prev.val != 0)
                        {
                            if (curr.prev.val > curr.val)
                            {
                                int tempval = curr.prev.val;
                                string tempstr = curr.prev.key;
                                curr.prev.val = curr.val;
                                curr.val = tempval;
                                curr.prev.key = curr.key;
                                curr.key = tempstr;
                                cache[curr.key] = curr;
                                cache[curr.prev.key] = curr.prev;
                                curr = curr.prev;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

            /** Returns one of the keys with maximal value. */
            public string GetMaxKey()
            {
                if (tail.prev.val == 0)
                    return "";
                return tail.prev.key;
            }

            /** Returns one of the keys with Minimal value. */
            public string GetMinKey()
            {
                if (head.next.val == 0)
                    return "";
                return head.next.key;
            }
        }
    }
}
