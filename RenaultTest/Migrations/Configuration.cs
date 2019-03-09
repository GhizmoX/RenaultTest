namespace RenaultTest.Migrations
{
    using global::Models;
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.Subject.AddOrUpdate(x => x.ID,
                new Subject() { ID = 1, Name = "Matemáticas" },
                new Subject() { ID = 1, Name = "Historia" },
                new Subject() { ID = 1, Name = "Español" },
                new Subject() { ID = 1, Name = "Derecho" }
                );
            context.Student.AddOrUpdate(x => x.ID,
                new Student() { ID = 1, Name = "John", LastName = "Doe" },
                new Student() { ID = 1, Name = "Mary", LastName = "Ditt" }
                );
            context.Grade.AddOrUpdate(x => x.ID,
                new Grade() { ID = 1, Subject_ID = 1, Student_ID = 1, Score = 7, Partial = 1 },
                new Grade() { ID = 2, Subject_ID = 1, Student_ID = 1, Score = 10, Partial = 2 },
                new Grade() { ID = 3, Subject_ID = 1, Student_ID = 1, Score = 8, Partial = 3 },
                new Grade() { ID = 4, Subject_ID = 2, Student_ID = 1, Score = 6, Partial = 1 },
                new Grade() { ID = 5, Subject_ID = 2, Student_ID = 1, Score = 8, Partial = 2 },
                new Grade() { ID = 6, Subject_ID = 2, Student_ID = 1, Score = 9, Partial = 3 },
                new Grade() { ID = 7, Subject_ID = 3, Student_ID = 1, Score = 7, Partial = 1 },
                new Grade() { ID = 8, Subject_ID = 3, Student_ID = 1, Score = 10, Partial = 2 },
                new Grade() { ID = 9, Subject_ID = 3, Student_ID = 1, Score = 8, Partial = 3 },
                new Grade() { ID = 10, Subject_ID = 4, Student_ID = 1, Score = 9, Partial = 1 },
                new Grade() { ID = 11, Subject_ID = 4, Student_ID = 1, Score = 8, Partial = 2 },
                new Grade() { ID = 12, Subject_ID = 4, Student_ID = 1, Score = 8, Partial = 3 },
                new Grade() { ID = 1, Subject_ID = 1, Student_ID = 2, Score = 7, Partial = 1 },
                new Grade() { ID = 2, Subject_ID = 1, Student_ID = 2, Score = 10, Partial = 2 },
                new Grade() { ID = 3, Subject_ID = 1, Student_ID = 2, Score = 8, Partial = 3 },
                new Grade() { ID = 4, Subject_ID = 2, Student_ID = 2, Score = 6, Partial = 1 },
                new Grade() { ID = 5, Subject_ID = 2, Student_ID = 2, Score = 8, Partial = 2 },
                new Grade() { ID = 6, Subject_ID = 2, Student_ID = 2, Score = 9, Partial = 3 },
                new Grade() { ID = 7, Subject_ID = 3, Student_ID = 2, Score = 7, Partial = 1 },
                new Grade() { ID = 8, Subject_ID = 3, Student_ID = 2, Score = 10, Partial = 2 },
                new Grade() { ID = 9, Subject_ID = 3, Student_ID = 2, Score = 8, Partial = 3 },
                new Grade() { ID = 10, Subject_ID = 4, Student_ID = 2, Score = 9, Partial = 1 },
                new Grade() { ID = 11, Subject_ID = 4, Student_ID = 2, Score = 8, Partial = 2 },
                new Grade() { ID = 12, Subject_ID = 4, Student_ID = 2, Score = 8, Partial = 3 }
                );
        }
    }
}
