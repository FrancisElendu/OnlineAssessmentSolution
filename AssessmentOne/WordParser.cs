namespace AssessmentOne
{
    public class WordParser
    {
        public static string ReturnUniqueWordsDelimited(
            Dictionary<string, string> words,
            string delimiter)
        {
            if (words == null || !words.Any())
                return string.Empty;

            return string.Join(
                delimiter,
                words.Keys
                     .Distinct(StringComparer.OrdinalIgnoreCase));
        }

        public static List<string> ReturnWordsWithDuplicatesList(
            Dictionary<string, string> words)
        {
            if (words == null || !words.Any())
                return new List<string>();

            return words.Keys
                        .GroupBy(w => w, StringComparer.OrdinalIgnoreCase)
                        .Where(g => g.Count() > 1)
                        .Select(g => g.Key)
                        .ToList();
        }

        public static DuplicatesDTO[] ReturnDuplicatesDTO(
            Dictionary<string, string> words)
        {
            if (words == null || !words.Any())
                return Array.Empty<DuplicatesDTO>();

            return words.Keys
                        .GroupBy(w => w, StringComparer.OrdinalIgnoreCase)
                        .Where(g => g.Count() > 1)
                        .Select(g => new DuplicatesDTO
                        {
                            Word = g.Key,
                            Count = g.Count()
                        })
                        .ToArray();
        }
    }

    public class DuplicatesDTO
    {
        public string Word { get; set; }
        public int? Count { get; set; }
    }
}
