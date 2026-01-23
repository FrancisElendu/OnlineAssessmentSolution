using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    public class Check_If_Two_Strings_Are_Anagrams
    {
        public static bool AreAnagrams(string s1, string s2)
        {
            if (s1 == null || s2 == null)
                return false;

            if (s1.Length != s2.Length)
                return false;

            Span<int> counts = stackalloc int[26];

            for (int i = 0; i < s1.Length; i++)
            {
                counts[char.ToLowerInvariant(s1[i]) - 'a']++;
                counts[char.ToLowerInvariant(s2[i]) - 'a']--;
            }

            for (int i = 0; i < 26; i++)
            {
                if (counts[i] != 0)
                    return false;
            }

            return true;
        }
    }
}
