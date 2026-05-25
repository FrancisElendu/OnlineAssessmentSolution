namespace AssessmentOne
{
    public class RemoveDuplicateCharacters_Solution
    {
        public static string RemoveDuplicateCharacters(string input)
        {
            //string input = "remove";
            List<char> result = new List<char>();
            List<char> seen = new List<char>();

            foreach (char c in input)
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    result.Add(c);
                }
                else
                {
                    result.Remove(c);
                }
            }

            return new string(result.ToArray());
        }


        ////using LINQ
        //public static string RemoveDuplicateCharactersUsingLINQ(string input)
        //{
        //    string[] words = input.Split(' ');
        //    string result = string.Empty;
        //    string cleanedString = string.Empty;
        //    var groupedCharacters = input.GroupBy(c => c)
        //                                 .Where(g => g.Count() == 1)
        //                                 .Select(g => g.Key);
        //    var res = string.Concat(groupedCharacters);

        //    return res;
        //}
    }
}
