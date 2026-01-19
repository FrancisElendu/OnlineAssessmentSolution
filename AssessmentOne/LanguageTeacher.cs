namespace AssessmentOne
{
    public class LanguageTeacher : LanguageStudent
    {
        // Teaches a language to a student if the teacher knows it
        public bool Teach(LanguageStudent student, string languageToLearn)
        {
            if (student == null || string.IsNullOrWhiteSpace(languageToLearn))
                return false;

            if (Languages.Contains(languageToLearn, StringComparer.OrdinalIgnoreCase))
            {
                student.AddLanguage(languageToLearn);
                return true;
            }

            return false;
        }
    }
}
