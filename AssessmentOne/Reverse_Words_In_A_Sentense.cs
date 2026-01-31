using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssessmentOne
{
    public class Reverse_Words_In_A_Sentense
    {
        public static string[] ReversePositionOfEachWordInASentense(string[] input)
        {
            if (input == null || input.Length == 0)
                return default;

            //use Stack<char> implemenatation. It follows the LIFO (Last In, First Out) principle.
            var stack = new Stack<string>();
            foreach (var c in input)
            {
                stack.Push(c);
            }

            return stack.ToArray();
        }

        //Or use this to reverse each word as well as position from last to first:
        //public static string[] ReverseEachWordAndItsPositionInASentense(string[] input)
        //{
        //    if (input == null || input.Length == 0)
        //        return default;

        //    //use Stack<char> implemenatation. It follows the LIFO (Last In, First Out) principle.
        //    var stack = new Stack<string>();
        //    string result = string.Empty;
        //    foreach (string c in input)
        //    {
        //        Stack<char> stack1 = new(c);

        //        result = string.Concat(stack1);
        //        stack.Push(result);
        //    }

        //    return stack.ToArray();
        //}
    }
}
