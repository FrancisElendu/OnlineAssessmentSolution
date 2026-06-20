namespace AssessmentOne
{
    public class Convert_A_Sentence_To_Pig_Latin
    {
        public async Task<string> PigLatin(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return string.Empty;
            }

            string[] words = sentence.Split(
                ' ',
                StringSplitOptions.RemoveEmptyEntries);

            Task<string>[] tasks = words.Select(word =>
            {
                return Task.FromResult(word)

                    // Step 1: Lowercase
                    .ContinueWith(t =>
                    {
                        return t.Result.ToLowerInvariant();
                    })

                    // Step 2: Move first character to end
                    .ContinueWith(t =>
                    {
                        string lowerWord = t.Result;

                        if (lowerWord.Length <= 1)
                        {
                            return lowerWord;
                        }

                        return lowerWord.Substring(1) + lowerWord[0];
                    })

                    // Step 3: Append "ay"
                    .ContinueWith(t =>
                    {
                        return t.Result + "ay";
                    });

            }).ToArray();

            string[] result = await Task.WhenAll(tasks);

            return string.Join(" ", result);
        }

        //Solution without using LINQ
        public async Task<string> PigLatinWithoutUsingLINQ(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return string.Empty;
            }

            string[] words = sentence.Split(
                ' ',
                StringSplitOptions.RemoveEmptyEntries);

            Task<string>[] tasks = new Task<string>[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                tasks[i] = Task.FromResult(word)

                    // Step 1: Lowercase
                    .ContinueWith(t =>
                    {
                        return t.Result.ToLowerInvariant();
                    })

                    // Step 2: Move first character to end
                    .ContinueWith(t =>
                    {
                        string lowerWord = t.Result;

                        if (lowerWord.Length <= 1)
                        {
                            return lowerWord;
                        }

                        return lowerWord.Substring(1) + lowerWord[0];
                    })

                    // Step 3: Add "ay"
                    .ContinueWith(t =>
                    {
                        return t.Result + "ay";
                    });
            }

            string[] results = await Task.WhenAll(tasks);

            return string.Join(" ", results);
        }
    }
}
