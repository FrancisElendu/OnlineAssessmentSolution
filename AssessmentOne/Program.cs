//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using AssessmentOne;

var teacher = new LanguageTeacher();
teacher.AddLanguage("English");
teacher.AddLanguage("French");

var student = new LanguageStudent();

bool result = teacher.Teach(student, "French"); // true
Console.WriteLine(result);
bool result2 = teacher.Teach(student, "Spanish"); // false
Console.WriteLine(result2);
