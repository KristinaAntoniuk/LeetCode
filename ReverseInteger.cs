using System.Xml.Schema;

namespace LeetCode
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            bool negative = x < 0;
            string initialString = negative ? x.ToString().Substring(1) : x.ToString();
            string resultString = String.Empty;
            int? resultInt = null;

            for (int i = initialString.Length - 1; i >= 0; i--)
            {
                resultString += initialString[i];
            }

            try
            {
                resultInt = Convert.ToInt32(resultString);
                if (x < 0)
                {
                    resultInt = 0 - resultInt;
                }
            }
            catch (Exception)
            {
                return 0;
            }

            return resultInt.GetValueOrDefault();
        }
    }
}
