using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RenaultTest.Models
{
    public class StudentDTO
    {
        [Key]
        public long ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Term { get; set; }
        public ICollection<Score> Scores { get; set; }
    }

    public class Score
    {
        public long ID { get; set; }
        public string Subject { get; set; }
        public short PartialOne { get; set; }
        public short PartialTwo { get; set; }
        public short PartialThree { get; set; }
        public float TotalScore { get; set; }
    }
}