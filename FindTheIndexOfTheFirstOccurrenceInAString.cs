namespace LeetCode
{
    public class FindTheIndexOfTheFirstOccurrenceInAString
    {
        public int StrStr(string haystack, string needle)
        {
            int index = 0;
            int firstIndex = 0;
            bool exist = false;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[index])
                {
                    exist = true;

                    if (index == 0)
                    {
                        firstIndex = i;
                    }

                    if (index == needle.Length - 1)
                    {
                        return firstIndex;
                    }

                    index++;
                }
                else
                {
                    if (exist)
                    {
                        i = firstIndex;
                        index = 0;
                        exist = false;
                    }

                }
            }

            return -1;
        }
    }
}
