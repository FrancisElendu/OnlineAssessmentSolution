namespace AssessmentOne
{
    public class Find_All_Duplicate_Characters_In_A_String
    {
        //char[] charArray = input.ToCharArray();
        //public static Dictionary<char, int> FindDuplicateCharactersInAString(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //        return new Dictionary<char, int>();

        //    Dictionary<char, int> charCount = new Dictionary<char, int>();
        //    Dictionary<char, int> DuplicateChar = new Dictionary<char, int>();
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
        //    foreach (var kvp in charCount)
        //    {
        //        if (kvp.Value > 1)
        //        {
        //            DuplicateChar[kvp.Key] = kvp.Value;
        //        }
        //    }
        //    return DuplicateChar;
        //}
        /// <summary>
        /// Step 1: Create a method that takes a string as input.
        /// Step 2: Initialize a dictionary to store character counts.
        /// Step 3: Initialize a HashSet to track unique characters.
        /// Step 4: Loop through each character in the string.
        /// Step 5: For each character, check if it is already in the HashSet.
        /// Step 6: If it is, increment its count in the dictionary.
        /// Step 7: If it is not, add it to the HashSet.
        /// Step 8: After the loop, return the dictionary containing duplicate characters and their counts.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Dictionary<char, int> FindDuplicateCharactersInAString(string input)
        {
            //input = "ronomerorr ";
            if (string.IsNullOrEmpty(input))
                return new Dictionary<char, int>();

            Dictionary<char, int> DuplicateChar = new Dictionary<char, int>();
            var uniqueChars = new HashSet<char>();
            foreach (char c in input)
            {
                if (!uniqueChars.Add(c))
                {
                    if (DuplicateChar.ContainsKey(c))
                    {
                        DuplicateChar[c]++;
                    }
                    else
                    {
                        DuplicateChar[c] = 2; // Since it's the second occurrence
                    }
                }

            }
            return DuplicateChar;
            //foreach (char c in input)
            //{
            //    if (DuplicateChar.ContainsKey(c))
            //    {
            //        DuplicateChar[c]++;
            //    }
            //    else
            //    {
            //        DuplicateChar[c] = 1;
            //    }
            //}
            //foreach (var kvp in DuplicateChar)
            //{
            //    if (kvp.Value > 1)
            //    {
            //        DuplicateChar[kvp.Key] = kvp.Value;
            //    }
            //}
            //return DuplicateChar;
        }

        //=====================================================
        //or use LINQ
        //public static Dictionary<char, int> FindDuplicateCharactersInAString_LINQ(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //        return new Dictionary<char, int>();
        //    var charCount = input.GroupBy(c => c)
        //                         .ToDictionary(g => g.Key, g => g.Count());
        //    return charCount;
        //}


        //=====================================================
        //or to just get the duplicate characters without counts
        //public static HashSet<char> FindDuplicateChars(string input)
        //{
        //    var seen = new HashSet<char>();
        //    var duplicates = new HashSet<char>();

        //    foreach (char c in input)
        //    {
        //        if (!seen.Add(c))  // Add returns false if already present
        //            duplicates.Add(c);
        //    }

        //    return duplicates;
        //}
    }
}
