namespace LeetCode
{
    public class StringtoIntegerAtoi
    {
        public int MyAtoi(string s)
        {
            bool? negative = null;
            string digits = String.Empty;

            int i = 0;
            bool continueLoop = true;

            while (i < s.Length && continueLoop)
            {
                switch (s[i])
                {
                    case '-':
                        if (negative == null)
                        {
                            negative = true;
                            continueLoop = true;
                        }
                        else
                        {
                            continueLoop = false;
                        }
                        break;
                    case '+':
                        if (negative == null)
                        {
                            negative = false;
                            continueLoop = true;
                        }
                        else
                        {
                            continueLoop = false;
                        }
                        break;
                    case ' ':
                        if (negative == null)
                        {
                            continueLoop = true;
                        }
                        else
                        {
                            continueLoop = false;
                        }
                        break;
                    default:
                        if (Char.IsDigit(s[i]))
                        {
                            if (negative == null)
                            {
                                negative = false;
                            }
                            digits += s[i];
                            continueLoop = true;
                        }
                        else
                        {
                            continueLoop = false;
                        }
                        break;
                }

                i++;
            }

            try
            {
                int result = Convert.ToInt32(digits);
                if (negative == true)
                {
                    result = 0 - result;
                }
                return result;
            }
            catch (FormatException formatEx)
            {
                return 0;
            }
            catch (OverflowException overwlowEx)
            {
                if (negative == true)
                    return Int32.MinValue; 
                else return Int32.MaxValue;
            }
            
        }
    }
}
