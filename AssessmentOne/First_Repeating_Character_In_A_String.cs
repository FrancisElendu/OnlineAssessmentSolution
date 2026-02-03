namespace AssessmentOne
{
    public class First_Repeating_Character_In_A_String
    {
        public static char? FirstRepeatingCharacterInAString(string input)
        {
            //input = "ronomerorr ";
            if (string.IsNullOrEmpty(input))
                return null;

            var uniqueChars = new HashSet<char>();
            foreach (char c in input)
            {
                if (!uniqueChars.Add(c))
                {
                    return c;
                }
            }
            return default;
        }
    }
}
