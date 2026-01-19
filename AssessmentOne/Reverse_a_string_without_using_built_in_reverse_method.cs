namespace AssessmentOne
{
    public class Reverse_a_string_without_using_built_in_reverse_method
    {
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] charArray = input.ToCharArray();
            int start = 0;
            int end = charArray.Length - 1;

            while (start < end)
            {
                // Swap characters
                char temp = charArray[start];
                charArray[start] = charArray[end];
                charArray[end] = temp;

                start++;
                end--;
            }

            return new string(charArray);
        }
    }
}
