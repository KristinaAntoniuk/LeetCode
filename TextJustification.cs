namespace LeetCode
{
    public class TextJustification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            List<string> result = new List<string>();
            List<int[]> counts = new List<int[]>();
            int currLength = 0;
            int currCount = 0;
            int currWordsLength = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (currLength + words[i].Length <= maxWidth)
                {
                    currLength += words[i].Length;
                    currWordsLength += words[i].Length;
                    currCount++;
                }
                else
                {
                    counts.Add(new int[2] { currCount, currWordsLength });
                    currCount = 0;
                    currLength = 0;
                    currWordsLength = 0;
                    i--;
                    continue;
                }

                if (currLength == maxWidth || i == words.Length - 1)
                {
                    counts.Add(new int[2] { currCount, currWordsLength });
                    currCount = 0;
                    currLength = 0;
                    currWordsLength = 0;
                }
                else
                {
                    currLength++; //Add empty space at the end of the word
                }
            }

            int wordIndex = 0;
            string line = "";
            int amountOfWords = 0;
            int spaces = 0;

            for (int index = 0; index < counts.Count - 1; index++)
            {
                line = "";
                amountOfWords = counts[index][0];
                int emptySpaces = maxWidth - counts[index][1];
                int extraSpaces = 0;

                if (amountOfWords > 1)
                {
                    extraSpaces = emptySpaces % (amountOfWords - 1);
                    spaces = emptySpaces / (amountOfWords - 1);
                }
                else
                {
                    extraSpaces = 0;
                    spaces = emptySpaces;
                }
                
                while (amountOfWords > 0)
                {
                    line += words[wordIndex];

                    if (amountOfWords != 1 || counts[index][0] == 1)
                    {
                        for (int i = 0; i < spaces; i++)
                        {
                            line += " ";
                        }

                        if (extraSpaces > 0)
                        {
                            line += " ";
                            extraSpaces--;
                        }
                    }

                    wordIndex++;
                    amountOfWords--;
                }

                result.Add(line);
            }

            line = "";
            amountOfWords = counts[counts.Count - 1][0];
            spaces = maxWidth - counts[counts.Count - 1][1];
            
            while (amountOfWords > 0)
            {
                line += words[wordIndex];

                if (amountOfWords != 1)
                {
                    line += " ";
                    spaces--;
                }
                else
                {
                    for (int i = 0; i < spaces; i++)
                    {
                        line += " ";
                    }
                }

                wordIndex++;
                amountOfWords--;
            }

            result.Add(line);

            return result;
        }
    }
}
