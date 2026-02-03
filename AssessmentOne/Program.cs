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


string str1 = "astronomerorr ";
//string str2 = "moon starer";

//var result = Check_If_Two_Strings_Are_Anagrams.AreAnagrams(str1, str2);
//string resultStr = result ? "The two strings are Anagrams" : "The two strings are NOT Anagrams";
//Console.WriteLine($"{resultStr}");

var result = Find_All_Duplicate_Characters_In_A_String.FindDuplicateCharactersInAString(str1);
Console.WriteLine($"Original string: {str1}");
Console.WriteLine("Duplicate characters and their counts:");
foreach (var kvp in result)
{
    Console.WriteLine($"Word: '{kvp.Key}' - Occurrences: {kvp.Value}");
}

//int[] numbers = { 1, 2, 3, 2, 4, 1, 5, 3, 6 };
//int[] uniqueNumbers = Remove_duplicate_elements_from_an_array_without_using_LINQ_Distinct.RemoveDuplicates(numbers);
//string[] words = { "orange", "apple", "banana", "apple", "banana", "grape" };
//string[] palindromeWords = { "radar", "racecar", "level", "kayak", "civic", "madam", "noon", "refer", "rotor", "tenet", "Able was I ere I saw Elba", "Rats live on no evil star", "Never odd or even" };
//string sentence = "the quick brown fox jumps over the lazy dog";
//var longestWordInASentence = Find_The_Longest_Word_In_A_Given_Sentence.FindLongestWordInASentence(sentence);
//Console.WriteLine($"\nAll max value entries ({longestWordInASentence.Count}):");
//foreach (var entry in longestWordInASentence)
//{
//    Console.WriteLine($"  {entry.Key}: {entry.Value}");
//}
//var wordCounts = Count_The_Occurence_Of_Each_Word_In_A_Sentence.CountWordOccurrences(sentence);
//foreach (var kvp in wordCounts)
//{
//    Console.WriteLine($"Word: '{kvp.Key}' - Occurrences: {kvp.Value}");
//}

//var charCounts = Count_The_Occurence_Of_Each_Character_In_A_Word.CountCharacterOccurrences("astronomerorr");
//foreach (var kvp in charCounts)
//{
//    Console.WriteLine($"Character: '{kvp.Key}' - Occurrences: {kvp.Value}");
//}



//foreach (string word in palindromeWords)
//{
//    var result = Reverse_a_string_without_using_built_in_reverse_method.ReverseString(word.ToLower());
//    if (word.ToLower() == result)
//        Console.WriteLine($"The string: {word} is a Palindrome");
//    else
//        Console.WriteLine($"The string: {word} is NOT a Palindrome");
//}

//var reversedWords = Reverse_Words_In_A_Sentense.ReverseEachWordAndItsPositionInASentense(words);
//int i = words.Length-1;
//foreach (var word in reversedWords)
//{
//    //Console.WriteLine(word);
//    if(i <= 0) break;
//    Console.WriteLine($"The word - {words[i]} is reversed to {word}");
//    i--;
//}

//var reversPositionOfWords = Reverse_Words_In_A_Sentense.ReversePositionOfEachWordInASentense(words);
//Console.WriteLine($"Original list of words: {words}");
//Console.Write($"The word reversed position is now - ");
//foreach (var word in reversPositionOfWords)
//{
//    Console.Write(word +" ");
//}
//string firstRepeatingElement = Find_First_Repeating_Element_In_An_Array.FindFirstRepeatingElementInAnArray(words);
//int? firstRepeatingElement = Find_First_Repeating_Element_In_An_Array.FindFirstRepeatingElementInAnArray(numbers);
//Console.WriteLine("First repeating element: " + (firstRepeatingElement));


//string[] uniqueWords = Remove_duplicate_elements_from_an_array_without_using_LINQ_Distinct.RemoveDuplicates(words);

//string uniqueCharacters = Remove_Duplicate_Characters_from_a_String.RemoveDuplicates(words[0]);

//Console.WriteLine("Original array: " + string.Join(", ", words));
//Console.WriteLine("String without duplicates: " +  uniqueCharacters);
//Console.WriteLine("Array without duplicates: " + string.Join(", ", uniqueWords));

//Console.WriteLine("First Non-Repeating Character Finder");
//Console.WriteLine("====================================\n");
////string[] testCases = { "aabbcc" };
//string[] testCases = { "swiss", "hello", "aabbcc", "programming", "", "a" };

//foreach (string test in testCases)
//{
//    char? result = Find_the_first_non_repeating_character_in_a_string.FirstNonRepeatingCharacter(test);
//    Console.WriteLine($"Input: '{test}' -> First non-repeating: {(result.HasValue ? result.ToString() : "None")}");
//}
//Console.WriteLine("First Repeating Character Finder");
//Console.WriteLine("====================================\n");
//foreach (string test in testCases)
//{
//    char? result = First_Repeating_Character_In_A_String.FirstRepeatingCharacterInAString(test);
//    Console.WriteLine($"Input: '{test}' -> First repeating: {(result.HasValue ? result.ToString() : "None")}");
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

