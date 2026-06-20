namespace AssessmentOne
{
    public class MultiDimArrays
    {
        //int[,] multiDimArray = new int[3, 4]
        //    {
        //        {1, 2, 3, 4},
        //        {5, 6, 7, 8},
        //        {9, 10, 11, 12}
        //    };

        public static void MultiDimArrayExample(int[,] multiDimArray)
        {
            
            for (int i = 0; i < multiDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimArray.GetLength(1); j++)
                {
                    Console.Write(multiDimArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
