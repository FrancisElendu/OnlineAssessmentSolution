using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    public class FizzBuzz_Solution
    {
        public static string[] FizzBuzz(int n)
        {
            if (n <= 0)
                throw new ArgumentOutOfRangeException(nameof(n), "n must be greater than zero.");

            var rules = new (int Divisor, string Text)[]
            {
                    (3, "Fizz"),
                    (5, "Buzz")
            };

            var results = new string[n];

            for (int i = 1; i <= n; i++)
            {
                var sb = new StringBuilder();

                foreach (var rule in rules)
                {
                    if (i % rule.Divisor == 0)
                    {
                        sb.Append(rule.Text);
                    }
                }

                results[i - 1] = sb.Length > 0
                    ? sb.ToString()
                    : i.ToString();
            }

            return results;
        }

        //public static void FizzBuzz(int n)
        //{
        //    for (int i = 1; i <= n; i++)
        //    {
        //        if (i % 3 == 0 && i % 5 == 0)
        //        {
        //            Console.WriteLine("FizzBuzz");
        //        }
        //        else if (i % 3 == 0)
        //        {
        //            Console.WriteLine("Fizz");
        //        }
        //        else if (i % 5 == 0)
        //        {
        //            Console.WriteLine("Buzz");
        //        }
        //        else
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}

        //public static string[] FizzBuzz2(int n)
        //{
        //    ////create array to store the results

        //    string[] answer = new string[n];
        //    for (int i = 1; i <= n; i++)
        //    {
        //        if (i % 3 == 0 && i % 5 == 0)
        //        {
        //            answer[i - 1] = "FizzBuzz";
        //        }
        //        else if (i % 3 == 0)
        //        {
        //            answer[i - 1] = "Fizz";
        //        }
        //        else if (i % 5 == 0)
        //        {
        //            answer[i - 1] = "Buzz";
        //        }
        //        else
        //        {
        //            answer[i - 1] = i.ToString();
        //        }
        //    }

        //    return answer;
        //}
    }
}
    




