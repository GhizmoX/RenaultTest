using Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RenaultTest.Models
{
    public class SubjectMining
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public IEnumerable<Subject> GetSubjects => context.Subject.ToList();

        public Subject GetSubject(long id) => context.Subject.FirstOrDefault(x => x.ID == id);

        public bool PostSubject(Subject subject)
        {
            context.Subject.Add(subject);
            if (context.SaveChanges() == 0) return false;
            return true;
        }

        public bool PutSubject(Subject subject)
        {
            Subject s = context.Subject.FirstOrDefault(x => x.ID == subject.ID);
            s.Name = subject.Name;
            if (context.SaveChanges() == 0) return false;
            return true;
        }

        public bool DeleteSubject(Subject subject)
        {
            bool oldValidateOnSaveEnabled = context.Configuration.ValidateOnSaveEnabled;

            try
            {
                context.Configuration.ValidateOnSaveEnabled = false;

                Subject sample = new Subject { ID = subject.ID };

                context.Subject.Attach(sample);
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