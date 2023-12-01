namespace LeetCode
{
    public class LengthOfLastWord
    {
        public int LengthOfLastWordMethod(string s)
        {
            int lastWordLength = 0;
            bool lastWord = false;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (Char.IsWhiteSpace(s[i]))
                {
                    if (lastWord)
                    {
                        break;
                    }
                }
                else
                {
                    if (lastWord == false)
                    {
                        lastWord = true;
                    }

                    lastWordLength += 1;
                }
            }

            return lastWordLength;
        }
    }
}
