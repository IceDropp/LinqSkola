using System.ComponentModel.DataAnnotations;

namespace LinqSkola.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
