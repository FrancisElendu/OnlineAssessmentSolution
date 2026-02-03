using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    public class Count_The_Occurence_Of_Each_Character_In_A_Word
    {
        public static Dictionary<char, int> CountCharacterOccurrences(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return new Dictionary<char, int>();

            // Split the sentence into words based on spaces and punctuation
            //char[] delimiters = new char[] { ' ', ',', '.', ';', '!', '?', '-', '\n', '\r', '\t' };
            //string[] words = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char character in word)
            {
                //string trimmedWord = word.Trim().ToLower();
                //if (wordCount.ContainsKey(trimmedWord))
                //{
                //    wordCount[trimmedWord]++;
                //}
                //else
                //{
                //    wordCount[trimmedWord] = 1;
                //}
                //this should remove the if statement
                charCount[character] = charCount.ContainsKey(character) ? charCount[character] + 1 : 1;
            }
            return charCount;
        }
    }
}
