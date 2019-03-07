using Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RenaultTest.Models
{
    public class StudentMining
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IEnumerable<StudentDTO> GetStudent(long id, int? term = null) => GetStudents(term).Where(x => x.ID == id).ToList();

        public IEnumerable<StudentDTO> GetStudents(int? term = null)
        {
            List<Grade> grades = new List<Grade>();
            grades = context.Grade.ToList();
            List<Student> students = context.Student.ToList();
            List<Subject> subjects = context.Subject.ToList();
            List<StudentDTO> dtos = new List<StudentDTO>();


            foreach (Student student in students)
            {
                StudentDTO dto = new StudentDTO();
                dto.ID = student.ID;
                dto.Name = student.Name;
                dto.LastName = student.LastName;
                dto.Term = student.Term;
                dto.Scores = new List<Score>();


                for (int i = 1; i <= subjects.Count; i++)
                {
                    Score s = new Score();
                    foreach (Grade grade in grades.Where(x => x.Student_ID == student.ID && x.Subject_ID == i))
                    {
                        s.Subject = subjects.FirstOrDefault(x => x.ID == grade.Subject_ID).Name;
                        switch (grade.Partial)
                        {
                            case 1:
                                s.PartialOne = grade.Score;
                                break;
                            case 2:
                                s.PartialTwo = grade.Score;
                                break;
                            case 3:
                                s.PartialThree = grade.Score;
                                break;
                            default:
                                s.PartialOne = 0;
                                s.PartialTwo = 0;
                                s.PartialThree = 0;
                                break;
                        }
                    }
                    s.TotalScore = (s.PartialOne + s.PartialTwo + s.PartialThree) / 3;
                    dto.Scores.Add(s);
                }


                dtos.Add(dto);
            }

            if (term != null) return dtos.Where(x => x.Term == term).ToList();
            return dtos;
        }

        public bool PostStudent(Student student)
        {
            context.Student.Add(student);
            if (context.SaveChanges() == 0) return false;
            return true;
        }

        public bool PutStudent(Student student)
        {
            Student s = context.Student.Find(student.ID);
            s.Name = student.Name;
            s.LastName = student.LastName;
            s.Subject = student.Subject;
            s.Term = student.Term;
            if (context.SaveChanges() == 0) return false;
            return true;
        }

        public bool DeleteStudent(Student student)
        {
            bool oldValidateOnSaveEnabled = context.Configuration.ValidateOnSaveEnabled;

            try
            {
                context.Configuration.ValidateOnSaveEnabled = false;

                Student sample = new Student { ID = student.ID };

                context.Student.Attach(sample);
                context.Entry(sample).State = EntityState.Deleted;
                context.SaveChanges();
            }
            finally
            {
                context.Configuration.ValidateOnSaveEnabled = oldValidateOnSaveEnabled;
            }
            if (context.SaveChanges() == 0) return false;
            return true;
        }
    }
}