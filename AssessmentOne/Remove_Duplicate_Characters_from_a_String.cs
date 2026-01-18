using System.Text;

namespace AssessmentOne
{
    public class Remove_Duplicate_Characters_from_a_String
    {
        public static string RemoveDuplicates(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            HashSet<char> seenChars = new HashSet<char>();
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                if (seenChars.Add(c)) // Add returns true if character is new
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
    }
}
