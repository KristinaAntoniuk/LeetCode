using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LongestCommonPrefix
    {
        public string LongestCommonPrefixMethod(string[] strs)
        {
            if (strs.Length == 0) { return ""; }

            int minLength = strs[0].Length;
            string prefix = string.Empty;

            foreach (string str in strs)
            {
                if (str.Length < minLength)
                {
                    minLength = str.Length;
                }
            }


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
