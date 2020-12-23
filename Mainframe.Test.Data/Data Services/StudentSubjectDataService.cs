using Mainframe.Test.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mainframe.Test.Data.Data_Services
{

    public interface IStudentSubjectDataService : IBaseDataService
    {
        IEnumerable<StudentSubject> GetStudentSubjects(); 
    }

    
    public class StudentSubjectDataService:BaseDataService,IStudentSubjectDataService
    {
        private DatabaseContext databaseContext;

        public StudentSubjectDataService(DatabaseContext databaseContext) : base(databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public IEnumerable<StudentSubject> GetStudentSubjects()
        {
            var results = (from s in databaseContext.StudentSubject
                           select s).ToList();
            return results;
        }

        public void GetDetails(StudentSubject studentSubject)
        {
            throw new NotImplementedException();
        }
    }
}
