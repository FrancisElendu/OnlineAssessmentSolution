using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    public class Find_First_Repeating_Element_In_An_Array
    {
        // Generic method that works for both value and reference types
        //public static T? FindFirstRepeatingElementInAnArray<T>(T[] array)
        //{
        //    if (array == null || array.Length == 0)
        //        return default;

        //    HashSet<T> seen = new HashSet<T>();

        //    foreach (T item in array)
        //    {
        //        if (seen.Contains(item))
        //        {
        //            return item;
        //        }
        //        seen.Add(item);
        //    }

        //    return default;
        //}

        //or use this


        //use this array string[] words = { "orange", "apple", "banana", "apple", "banana", "grape" };
        public static T? FindFirstRepeatingElementInAnArray<T>(T[] array)
        {
            if (array == null || array.Length == 0)
                return default;

            HashSet<T> seen = new HashSet<T>();

            foreach (T item in array)
            {
                if (!seen.Add(item))
                {
                    return item;
                }
            } 
            return default;
        }
    }
}
