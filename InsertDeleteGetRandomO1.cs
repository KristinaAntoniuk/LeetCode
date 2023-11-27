namespace LeetCode
{
    public class InsertDeleteGetRandomO1
    {
        public class RandomizedSet
        {
            private HashSet<int> set;
            private Random rand;

            public RandomizedSet()
            {
                set = new HashSet<int>();
                rand = new Random();
            }

            public bool Insert(int val)
            {
                return set.Add(val);
            }

            public bool Remove(int val)
            {
                return set.Remove(val);
            }

            public int GetRandom()
            {
                int index = rand.Next(0, set.Count);
                return set.ToArray()[index];
            }
        }


        /**
         * Your RandomizedSet object will be instantiated and called as such:
         * RandomizedSet obj = new RandomizedSet();
         * bool param_1 = obj.Insert(val);
         * bool param_2 = obj.Remove(val);
         * int param_3 = obj.GetRandom();
         */
    }
}
