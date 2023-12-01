namespace LeetCode
{
    internal class LongestCommonPrefix
    {
        public string LongestCommonPrefixMethod(string[] strs)
        {

            int minLength = strs.OrderBy(x => x.Length).First().Length;
            string prefix = string.Empty;

            for (int i = 0; i < minLength; i++)
            {
                if (strs[0].Length == 0) return "";

                char letter = strs[0][i];

                foreach (string str2 in strs)
                {
                    if (str2[i] != letter)
                    {
                        return prefix;
                    }
                }

                prefix = prefix + letter;
            }

            return prefix;
        }
    }
}
