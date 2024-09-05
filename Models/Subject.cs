using System.ComponentModel.DataAnnotations;

namespace LinqSkola.Models
{
    public class Subject
    {
        
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public ICollection<TeacherSubject> TeacherSubjects { get; set; } = [];
        public ICollection<StudentSubject> StudentSubjects { get; set; } = [];
    }
}
