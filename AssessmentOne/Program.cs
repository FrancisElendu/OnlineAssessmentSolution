//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using AssessmentOne;

//var teacher = new LanguageTeacher();
//teacher.AddLanguage("English");
//teacher.AddLanguage("French");

//var student = new LanguageStudent();

//bool result = teacher.Teach(student, "French"); // true
//Console.WriteLine(result);
//bool result2 = teacher.Teach(student, "Spanish"); // false
//Console.WriteLine(result2);



//MainBox box = new MainBox();
//for (int i = 0; i < 1_000_000; i++)
//{
//    box = new MainBox(box);
//}
//Console.WriteLine(box.NumberOfSmallerBoxes); // Works fine

//var box3 = new MainBox();
//var box2 = new MainBox(box3);
//var box1 = new MainBox(box2);

//Console.WriteLine(box1.NumberOfSmallerBoxes); // Output: 2


//✅ True Anagrams:
//• "listen" and "silent"
//• "debit card" and "bad credit"
//• "astronomer" and "moon starer"
//• "dormitory" and "dirty room"
//• "eleven plus two" and "twelve plus one"

//❌ Not Anagrams:
//• "hello" and "world"          ← Different characters
//• "book" and "books"           ← Different lengths
//• "pool" and "polo"            ← Different frequencies (two 'o's vs one 'o')
//• "apple" and "apples"         ← Different lengths


string str1 = "hello";
string str2 = "world";

var result = Check_If_Two_Strings_Are_Anagrams.AreAnagrams(str1, str2);
string resultStr = result ? "The two strings are Anagrams" : "The two strings are NOT Anagrams";
Console.WriteLine($"{resultStr}");

//int[] numbers = { 1, 2, 3, 2, 4, 1, 5, 3, 6 };
//int[] uniqueNumbers = Remove_duplicate_elements_from_an_array_without_using_LINQ_Distinct.RemoveDuplicates(numbers);
//string[] words = { "apple", "banana", "apple", "orange", "banana", "grape" };
//string[] uniqueWords = Remove_duplicate_elements_from_an_array_without_using_LINQ_Distinct.RemoveDuplicates(words);

//string uniqueCharacters = Remove_Duplicate_Characters_from_a_String.RemoveDuplicates(words[0]);

//Console.WriteLine("Original array: " + string.Join(", ", words));
//Console.WriteLine("Array without duplicates: " + string.Join(", ", uniqueWords));

//Console.WriteLine("First Non-Repeating Character Finder");
//Console.WriteLine("====================================\n");
//string[] testCases = { "swiss", "hello", "aabbcc", "programming", "", "a" };

//foreach (string test in testCases)
//{
//    char? result = Find_the_first_non_repeating_character_in_a_string.FirstNonRepeatingCharacter(test);
//    Console.WriteLine($"Input: '{test}' -> First non-repeating: {(result.HasValue ? result.ToString() : "None")}");
//}

//OR use this more comprehensive test cases

//var testCases = new Dictionary<string, string>
//        {
//            { "swiss", "w" },
//            { "hello", "h" },
//            { "aabbcc", "None" },
//            { "programming", "p" },
//            { "a", "a" },
//            { "aa", "None" },
//            { "abacabad", "c" },
//            { "", "None" },
//            { "stress", "t" },
//            { "GeeksforGeeks", "f" }
//        };

//foreach (var testCase in testCases)
//{
//    char? result = Find_the_first_non_repeating_character_in_a_string.FirstNonRepeatingCharacter(testCase.Key);
//    string resultStr = result.HasValue ? result.Value.ToString() : "None";
//    string expected = testCase.Value;
//    string status = resultStr == expected ? "✓" : "✗";

//    Console.WriteLine($"{status} Input: '{testCase.Key,-15}' Output: '{resultStr,-5}' Expected: '{expected}'");
//}

