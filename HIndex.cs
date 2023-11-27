namespace LeetCode
{
    public class HIndex
    {
        public int HIndexMethod(int[] citations)
        {
            Array.Sort(citations, (x, y) => -x.CompareTo(y));

            int index = 0;

            while(index < citations.Length && index + 1 <= citations[index])
            {
                index++;
            }

            return index;
        }
    }
}
