namespace LeetCode
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower().Trim();
            int rightIndex = s.Length - 1;
            int leftIndex = 0; 

            while (leftIndex < s.Length && rightIndex >= 0)
            {
                if (!Char.IsLetter(s[leftIndex]))
                {
                    if (!Char.IsDigit(s[leftIndex]))
                    {
                        leftIndex++;
                        continue;

                    }
                }

                if (!Char.IsLetter(s[rightIndex]))
                {
                    if (!Char.IsDigit(s[rightIndex]))
                    {
                        rightIndex--;
                        continue;
                    }
                }

                if (s[leftIndex] != s[rightIndex])
                {
                    return false;
                }
                else
                {
                    leftIndex++;
                    rightIndex--;
                }

            }

            return true;
        }
    }
}
