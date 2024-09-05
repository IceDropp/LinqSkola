using System.ComponentModel.DataAnnotations;

namespace LinqSkola.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }

        public ICollection<TeacherSubject> TeacherSubjects { get; set; } = [];
    }
}
