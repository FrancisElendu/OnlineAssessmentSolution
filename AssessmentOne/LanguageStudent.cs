using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    public class LanguageStudent
    {
        // Returns all languages the student knows
        public List<string> Languages { get; } = new List<string>();

        // Adds a new language to the list
        public void AddLanguage(string language)
        {
            if (string.IsNullOrWhiteSpace(language))
                return;

            if (!Languages.Contains(language, StringComparer.OrdinalIgnoreCase))
            {
                Languages.Add(language);
            }
        }
    }
}
