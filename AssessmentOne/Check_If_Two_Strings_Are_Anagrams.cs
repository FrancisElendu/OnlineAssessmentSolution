namespace AssessmentOne
{
    public class Check_If_Two_Strings_Are_Anagrams
    {
        public static bool AreAnagrams(string s1, string s2)
        {
            if (s1 == null || s2 == null)
                return false;

            if (s1.Length != s2.Length)
                return false;

            Span<int> charCount = stackalloc int[26];

            // Count characters in first string
            foreach (char c in s1)
            {
                if (char.IsLetter(c))
                {
                    charCount[char.ToLower(c) - 'a']++;
                }
            }

            // Subtract counts using second string
            foreach (char c in s2)
            {
                if (char.IsLetter(c))
                {
                    int index = char.ToLower(c) - 'a';
                    charCount[index]--;

                    // Early exit if count goes negative
                    if (charCount[index] < 0)
                        return false;
                }
            }

            // Verify all counts are zero
            for (int i = 0; i < 26; i++)
            {
                if (charCount[i] != 0)
                    return false;
            }

            return true;
        }
    }
}
