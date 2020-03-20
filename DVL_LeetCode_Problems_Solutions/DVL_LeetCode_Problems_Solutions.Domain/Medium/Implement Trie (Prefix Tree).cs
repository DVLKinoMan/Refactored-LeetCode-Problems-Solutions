using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Implement Trie (Prefix Tree) (Mine)
        /// </summary>
        public class Trie {
            private class TrieNode
            {
                public char? Val;
                public int Index;
                public bool IsWord = false;

                public TrieNode(char? val, int index = -1)
                {
                    this.Val = val;
                    this.Index = index;
                } 
                
                public List<TrieNode> Children = new List<TrieNode>();

                public TrieNode GetChild(string pref, int index = 0)
                {
                    if (index >= pref.Length)
                        return this;
                    
                    foreach (var child in Children)
                        if (child.Val == pref[index])
                            return child.GetChild(pref, index + 1);

                    return this;
                }

                public void AddChild(string val, int index = 0)
                {
                    if (index >= val.Length)
                    {
                        IsWord = true;
                        return;
                    }
                    var newNode = new TrieNode(val[index], this.Index + 1);
                    newNode.AddChild(val, index + 1);
                    Children.Add(newNode);
                }

                public bool Search(string val, bool startsWith = false, int index = 0)
                {
                    if (index >= val.Length)
                        return startsWith || IsWord;
                    
                    foreach (var child in Children)
                        if (child.Val == val[index])
                            return child.Search(val, startsWith, index + 1);
                    return false;
                }
            }

            private TrieNode _root;
            
            /** Initialize your data structure here. */
            public Trie()
            {
                _root = new TrieNode(null);
            }
    
            /** Inserts a word into the trie. */
            public void Insert(string word)
            {
                var node = _root.GetChild(word);
                node.AddChild(word.Substring(node.Index+1));
            }
    
            /** Returns if the word is in the trie. */
            public bool Search(string word)
            {
                return _root.Search(word);
            }
    
            /** Returns if there is any word in the trie that starts with the given prefix. */
            public bool StartsWith(string prefix)
            {
                return _root.Search(prefix, true);
            }
        }

    }
}