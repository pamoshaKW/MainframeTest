using Mainframe.Test.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mainframe.Test.Data.Data_Services
{
    public interface ISubjectDataService : IBaseDataService
    {
        public int AddSubject(Subjects subject);
        public IEnumerable<Subjects> GetSubjects();
        public Subjects GetSubjectById(int id);

    }

    public class SubjectDataService : BaseDataService, ISubjectDataService
    {
        private DatabaseContext databaseContext;
        public SubjectDataService(DatabaseContext databaseContext):base(databaseContext)
        {
            this.databaseContext = databaseContext;

        }

        public int AddSubject(Subjects subject)
        {
            databaseContext.Subjects.Add(subject);
            databaseContext.SaveChanges();
            return subject.Id;
        }

        public IEnumerable<Subjects> GetSubjects()
        {
            var subjects = (from s in databaseContext.Subjects
                            select s).ToList();
            return subjects;
        }

        public Subjects GetSubjectById(int id)
        {
            var subject = (from s in databaseContext.Subjects
                           where s.Id == id
                           select s);

            return subject.FirstOrDefault();
        }
    }
}
