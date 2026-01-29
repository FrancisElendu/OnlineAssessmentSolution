using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    public class Find_All_Duplicate_Characters_In_A_String
    {
        //char[] charArray = input.ToCharArray();
        public static Dictionary<char, int> FindDuplicateCharactersInAString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return new Dictionary<char, int> ();
            Dictionary<char, int> charCount = new Dictionary<char, int>();
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
            return charCount;
        }


        //or use LINQ
        //public static Dictionary<char, int> FindDuplicateCharactersInAString_LINQ(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //        return new Dictionary<char, int>();
        //    var charCount = input.GroupBy(c => c)
        //                         .ToDictionary(g => g.Key, g => g.Count());
        //    return charCount;
        //}

        public static string FindDuplicateCharactersInAString_NEW(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            HashSet<char> seenChars = new HashSet<char>();
            foreach (char c in input)
            {
                seenChars.Add(c);
            }
            return new string(seenChars.ToArray());
        }
    }
}
