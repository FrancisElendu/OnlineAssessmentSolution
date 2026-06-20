using System.Text;

namespace AssessmentOne
{
    public class WordParser_Without_Linq_Solution
    {
        //public string ReturnUniqueWordsDelimited(
        //Dictionary<string, string> words,
        //string delimiter)
        //{
        //    if (words == null || words.Count == 0)
        //    {
        //        return string.Empty;
        //    }

        //    string result = string.Empty;
        //    bool first = true;

        //    foreach (KeyValuePair<string, string> item in words)
        //    {
        //        if (!first)
        //        {
        //            result += delimiter;
        //        }

        //        result += item.Key;
        //        first = false;
        //    }

        //    return result;
        //}

        public static string ReturnUniqueWordsDelimited(
    Dictionary<string, string> words,
    string delimiter)
        {
            if (words == null || words.Count == 0)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            bool first = true;

            foreach (KeyValuePair<string, string> item in words)
            
            {
                if (!first)
                {
                    sb.Append(delimiter);
                }

                sb.Append(item.Key);
                first = false;
            }

            return sb.ToString();
        }

        public static List<string> ReturnWordsWithDuplicatesList(
            Dictionary<string, string> words)
        {
            List<string> duplicates = new List<string>();

            if (words == null || words.Count == 0)
            {
                return duplicates;
            }

            Dictionary<string, int> counts =
                new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (KeyValuePair<string, string> item in words)
            {
                string word = item.Key;

                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            foreach (KeyValuePair<string, int> item in counts)
            {
                if (item.Value > 1)
                {
                    duplicates.Add(item.Key);
                }
            }

            return duplicates;
        }

        public static DuplicatesDTO[] ReturnDuplicatesDTO(
            Dictionary<string, string> words)
        {
            if (words == null || words.Count == 0)
            {
                return new DuplicatesDTO[0];
            }

            Dictionary<string, int> counts =
                new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (KeyValuePair<string, string> item in words)
            {
                string word = item.Key;

                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            List<DuplicatesDTO> results = new List<DuplicatesDTO>();

            foreach (KeyValuePair<string, int> item in counts)
            {
                if (item.Value > 1)
                {
                    results.Add(new DuplicatesDTO
                    {
                        Word = item.Key,
                        Count = item.Value
                    });
                }
            }

            return results.ToArray();
        }
    }
}
