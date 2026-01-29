namespace AssessmentOne
{
    public class Count_The_Occurence_Of_Each_Word_In_A_Sentence
    {
        public static Dictionary<string, int> CountWordOccurrences(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return new Dictionary<string, int>();

            // Split the sentence into words based on spaces and punctuation
            char[] delimiters = new char[] { ' ', ',', '.', ';', '!', '?', '-', '\n', '\r', '\t' };
            string[] words = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            foreach (string word in words)
            {
                string trimmedWord = word.Trim().ToLower();
                if (wordCount.ContainsKey(trimmedWord))
                {
                    wordCount[trimmedWord]++;
                }
                else
                {
                    wordCount[trimmedWord] = 1;
                }
            }
            return wordCount;
        }

        //Or use LINQ
        //public static Dictionary<string, int> CountWordOccurrences_LINQ(string sentence)
        //{
        //    if (string.IsNullOrWhiteSpace(sentence))
        //        return new Dictionary<string, int>();
        //    char[] delimiters = new char[] { ' ', ',', '.', ';', '!', '?', '-', '\n', '\r', '\t' };
        //    var wordCount = sentence
        //        .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
        //        .Select(word => word.Trim().ToLower())
        //        .GroupBy(word => word)
        //        .ToDictionary(g => g.Key, g => g.Count(), StringComparer.OrdinalIgnoreCase);
        //    return wordCount;
        //}
    }
}
