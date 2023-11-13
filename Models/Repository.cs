using LessonSelection.Models;

namespace LessonSelection
{
    public static class Repository
    {
        private static List<Student> applications = new();
        public static IEnumerable<Student> Applications = applications;

        //formdan gelecek bilgileri eklicek yapı
        public static void Add(Student student)
        {
            applications.Add(student);
        }
    }
}