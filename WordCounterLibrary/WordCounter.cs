namespace WordCounterLibrary
{
    public class WordCounter
    {
        public int wordCount;
        public int charCount;
        public bool countWhiteSpaces;

        public WordCounter()
        {
            wordCount = 0;
            charCount = 0;
            countWhiteSpaces = false;
        }

        public void Count(string text)
        {
            bool lastWhiteSpace = false;

            int textLength = text.Length;

            for (int c = 0; c < textLength; c++)
            {
                // Count character if it isnt considered whitespace
                if (!char.IsWhiteSpace(text[c]))
                {
                    charCount++;

                    // Count word if the current character isn't whitespace
                    // and the last character was
                    if (lastWhiteSpace)
                    {
                        wordCount++;
                    }

                    lastWhiteSpace = false;

                    // Count word if it is the first character entered
                    if (c == 0)
                    {
                        wordCount++;
                    }
                }
                else
                {
                    // Count character if it is a space but not a newline
                    // (or other character considered whitespace) when 
                    // countWhiteSpaces is set to true
                    if (countWhiteSpaces && text[c] == ' ')
                        charCount++;

                    lastWhiteSpace = true;
                }
            }
        }

        public void Reset()
        {
            charCount = 0;
            wordCount = 0;
        }

        public void CountWhiteSpaces()
        {
            countWhiteSpaces = true;
        }
    }
}
