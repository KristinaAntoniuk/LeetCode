using System.Text;

namespace LeetCode
{
    public class ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {
            StringBuilder result = new StringBuilder();
            int endIndex = 0;
            bool isWord = false;

            for(int i = s.Length - 1; i >= 0; i--)
            {
                if (isWord)
                {
                    if (Char.IsWhiteSpace(s[i]))
                    {
                        string word = s.Substring(i + 1, endIndex - i);
                        result.Append(word);
                        result.Append(s[i]);
                        isWord = false;
                    }
                    else if (i == 0)
                    {
                        string word = s.Substring(i, endIndex - i + 1);
                        result.Append(word);
                        isWord = false;
                    }
                }
                else
                {
                    if (!Char.IsWhiteSpace(s[i]))
                    {
                        if (i == 0)
                        {
                            result.Append(s[i]);
                            break;
                        }

                        isWord = true;
                        endIndex = i;
                    }
                }
            }

            return result.ToString().Trim();
        }
    }
}
