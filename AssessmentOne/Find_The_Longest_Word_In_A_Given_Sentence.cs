namespace AssessmentOne
{
    public class Find_The_Longest_Word_In_A_Given_Sentence
    {
        //public static Dictionary<string, int> FindLongestWordInASentence(string sentence)
        //{
        //    if (string.IsNullOrWhiteSpace(sentence))
        //        return null;

        //    // Split the sentence into words based on spaces and punctuation
        //    char[] delimiters = new char[] { ' ', ',', '.', ';', '!', '?', '-', '\n', '\r', '\t' };
        //    string[] words = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        //    Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        //    foreach (string word in words)
        //    {
        //        string trimmedWord = word.Trim().ToLower();
        //        wordCount[trimmedWord] = trimmedWord.Length;
        //    }

        //    int maxValue = wordCount.Values.Max();
        //    return wordCount.Where(kvp => kvp.Value == maxValue).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        //}

        //Or use this method
        /// <summary>
        /// Step 1: Create a method that takes a sentence as input.
        /// Step 2: Check if the input sentence is null or empty; if so, return null.
        /// Step 3: Split the sentence into words using spaces and punctuation as delimiters.
        /// Step 4: Initialize a dictionary to store the longest words and their lengths.
        /// Step 5: Initialize a variable to keep track of the maximum length found so far.
        /// Step 6: Loop through each word in the split words.
        /// Step 7: For each word, trim whitespace and convert it to lowercase.
        /// Step 8: Compare the length of the current word with the maximum length found so far.
        /// Step 9: If the current word's length is greater than the maximum length, update the maximum length, clear the dictionary, and add the current word to the dictionary.
        /// Step 10: If the current word's length is equal to the maximum length, add the current word to the dictionary.
        /// Step 11: After looping through all words, return the dictionary containing the longest words and their lengths.
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static Dictionary<string, int> FindLongestWordInASentence(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return null;

            // Split the sentence into words based on spaces and punctuation
            char[] delimiters = new char[] { ' ', ',', '.', ';', '!', '?', '-', '\n', '\r', '\t' };
            string[] words = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> longestWords = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            int maxLength = 0;

            foreach (string word in words)
            {
                string trimmedWord = word.Trim().ToLower();
                if (trimmedWord.Length > maxLength)
                {
                    maxLength = trimmedWord.Length;
                    longestWords.Clear();
                    longestWords[trimmedWord] = trimmedWord.Length;
                }
                else if (trimmedWord.Length == maxLength)
                {
                    longestWords[trimmedWord] = trimmedWord.Length;
                }
            }
            return longestWords;
        }
    }
}
