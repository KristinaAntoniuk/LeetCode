using System.Data.SqlTypes;

namespace LeetCode
{
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            string result = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                string substring = s[i].ToString();

                if (result.Length == 0)
                    result = substring;

                for (int j = i + 1; j < s.Length; j++)
                {
                    bool palindromic = true;
                    substring = substring + s[j].ToString();
                    int length = substring.Length;

                    for (int k = 0; k < length / 2; k++)
                    {
                        if (substring[k] != substring[length - 1 - k])
                        {
                            palindromic = false;
                            break;
                        }
                    }

                    if (palindromic && result.Length < length)
                    {
                        result = substring;
                    }
                }
            }

            return result;
        }
    }
}
