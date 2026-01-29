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
        public static string[] ReverseWordInASentense(string[] input)
        {
            if (input == null || input.Length == 0)
                return default;

            var stack = new Stack<string>();
            foreach (var c in input)
            {
                stack.Push(c);
            }

            return stack.ToArray();
        }
    }
}
