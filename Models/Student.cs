namespace LessonSelection.Models
{
    public class Student
    {
        public String? Email { get; set; } = String.Empty;
        public String? FirstName { get; set; } = String.Empty;
        public String? LastName { get; set; } = String.Empty;   
        
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public String? ApplyAt { get; set; }

        //nesne üretilirken değer atanır 
        public Student()
        {
            ApplyAt = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        } 
    }

    
}