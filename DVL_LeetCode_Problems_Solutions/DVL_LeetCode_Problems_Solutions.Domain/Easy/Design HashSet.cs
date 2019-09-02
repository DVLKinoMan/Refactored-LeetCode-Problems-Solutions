namespace DVL_LeetCode_Problems_Solutions.Domain
{
    /// <summary>
    /// Design Hashset (Mine)
    /// </summary>
    public class MyHashSet
    {
        int[] structure;
        /** Initialize your data structure here. */
        public MyHashSet()
        {
            structure = new int[1000001];
        }

        public void Add(int key)
        {
            structure[key] = 1;
        }

        public void Remove(int key)
        {
            structure[key] = 0;
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            return structure[key] != 0;
        }
    }

}
