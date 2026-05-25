namespace AssessmentOne
{
    public class MergeTwoArrays_Solution
    {
        //public static int[] MergeTwoArrays(int[] arr1, int[] arr2)
        //{
        //    var mergedArray = arr1.Concat(arr2).ToArray();
        //    Array.Sort(mergedArray);
        //    return mergedArray;
        //}

        //generic version
        public static T[] MergeTwoArrays<T>(T[] arr1, T[] arr2) where T : IComparable<T>
        {
            var mergedArray = arr1.Concat(arr2).ToArray();
            Array.Sort(mergedArray);
            return mergedArray;
        }
    }
}
