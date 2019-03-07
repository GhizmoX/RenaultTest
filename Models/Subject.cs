using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Subject
    {
        public Subject()
        {
            Student = new HashSet<Student>();
        }

        [Key]
        public long ID { get; set; }
        [MaxLength(120)]
        public string Name { get; set; }

        public ICollection<Student> Student { get; set; }
    }
}
