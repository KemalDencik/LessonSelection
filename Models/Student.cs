using System.ComponentModel.DataAnnotations;

namespace LessonSelection.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Email is required")]
        public String? Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "FirstName is required")]
        public String? FirstName { get; set; } = String.Empty;
        
        [Required(ErrorMessage = "LastName is required")]
        public String? LastName { get; set; } = String.Empty;   
        
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        
        [Required(ErrorMessage = "SelectedCourse is required")]
        public String? SelectedCourse { get; set; } = String.Empty;
        public String? ApplyAt { get; set; }

        //nesne üretilirken değer atanır 
        public Student()
        {
            ApplyAt = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        } 
    }
}