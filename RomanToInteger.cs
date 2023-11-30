using System.Text;

namespace LeetCode
{
    //Symbol Value
    //I             1
    //V             5
    //X             10
    //L             50
    //C             100
    //D             500
    //M             1000
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int result = map[s.Last()];
            int bigger = result;

            for (int i = s.Length - 2; i >= 0; i--)
            {
                if (map[s[i]] < bigger)
                {
                    result -= map[s[i]];
                }
                else
                {
                    result += map[s[i]];
                    bigger = map[s[i]];
                }
            }

            return result;
        }

        public string IntToRoman(int num)
        {
            Dictionary<int, string> map = new Dictionary<int, string>()
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" }
            };

            StringBuilder result = new StringBuilder();

            foreach(int key in map.Keys)
            {
                if (num % key == num)
                    continue;
                else
                {
                    int amount = num / key;
                    for(int i = 0; i < amount; i++)
                    {
                        result.Append(map[key]);
                    }
                    num = num % key;
                }
            }

            return result.ToString();
        }
    }
}
