using System.Text;

namespace LeetCode
{
    //Here are two solutions for the same problem, first one is a bit faster than the second one
    public class ZigzagConversion
    {
        public string ConvertI(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            int initialStep = 2 * numRows - 2;
            StringBuilder result = new StringBuilder();

            int position = 0;
            int row = 0;
            int step = 0;

            while (row < numRows)
            {
                if (position < s.Length)
                {
                    result.Append(s[position]);
                    if (row == 0 || row == numRows - 1)
                    {
                        position += initialStep;
                    }
                    else
                    {
                        step = initialStep - step;
                        position += step;
                    }
                }
                else
                {
                    row++;
                    position = row;
                    step = 2 * row;
                }
            }

            return result.ToString();
        }

        public string ConvertII(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            StringBuilder result = new StringBuilder();

            int period = 2 * numRows - 2;

            for(int row = 0; row < numRows; row++)
            {
                int step = 2 * row;

                for(int i = row; i < s.Length; i += step)
                {
                    result.Append(s[i]);
                    if (step != period)
                    {
                        step = period - step;
                    }
                }
            }

            return result.ToString();
        }
    }
}
