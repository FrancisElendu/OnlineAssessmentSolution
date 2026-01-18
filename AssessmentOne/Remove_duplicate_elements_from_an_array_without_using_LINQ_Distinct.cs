namespace AssessmentOne
{
    public class Remove_duplicate_elements_from_an_array_without_using_LINQ_Distinct
    {
        public static T[] RemoveDuplicates<T>(T[] array)
        {
            if (array == null || array.Length == 0)
                return array;

            HashSet<T> uniqueElements = new HashSet<T>();
            List<T> result = new List<T>();

            foreach (T item in array)
            {
                if (uniqueElements.Add(item)) // Add returns true if element is new
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
    }
}
