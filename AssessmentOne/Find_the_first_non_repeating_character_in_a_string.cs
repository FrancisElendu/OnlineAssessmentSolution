using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    public class Find_the_first_non_repeating_character_in_a_string
    {
        public static char? FirstNonRepeatingCharacter(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;

            Dictionary<char, int> charCount = new Dictionary<char, int>();
            
            // Count occurrences of each character
            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            
            // Find the first non-repeating character
            foreach (char c in input)
            {
                if (charCount[c] == 1)
                {
                    return c;
                }
            }
            return null; // No non-repeating character found
        }
    }
}
