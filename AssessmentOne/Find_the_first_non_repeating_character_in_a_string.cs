namespace AssessmentOne
{
    public class Find_the_first_non_repeating_character_in_a_string
    {
        //public static char? FirstNonRepeatingCharacter(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //        return null;

        //    Dictionary<char, int> charCount = new Dictionary<char, int>();

        //    // Count occurrences of each character
        //    foreach (char c in input)
        //    {
        //        if (charCount.ContainsKey(c))
        //        {
        //            charCount[c]++;
        //        }
        //        else
        //        {
        //            charCount[c] = 1;
        //        }
        //    }

        //    // Find the first non-repeating character
        //    foreach (char c in input)
        //    {
        //        if (charCount[c] == 1)
        //        {
        //            return c;
        //        }
        //    }
        //    return null; // No non-repeating character found
        //}


        //Or use this
        public static char? FirstNonRepeatingCharacter(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;

            Dictionary<char, int> NonDuplicateChar = new Dictionary<char, int>();
            var uniqueChars = new HashSet<char>();
            foreach (char c in input)
            {
                if (uniqueChars.Add(c))
                {
                    NonDuplicateChar[c] = 1;
                }
                else if (NonDuplicateChar.ContainsKey(c))
                {
                    NonDuplicateChar.Remove(c);
                }
            }
            //if (NonDuplicateChar.Count == 0)
            //    return null;
            //return NonDuplicateChar.ToArray().FirstOrDefault().Key;
            char result = NonDuplicateChar.Count == 0 ? '\0' : NonDuplicateChar.First().Key;
            return result;
        }
    }
}
