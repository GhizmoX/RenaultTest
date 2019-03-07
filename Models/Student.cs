using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Student
    {
        public Student()
        {
            Subject = new HashSet<Subject>();
        }

        [Key]
        public long ID { get; set; }
        [MaxLength(33)]
        public string Name { get; set; }
        [MaxLength(66)]
        public string LastName { get; set; }
        public int Term { get; set; }

        public ICollection<Subject> Subject { get; set; }
    }
}
