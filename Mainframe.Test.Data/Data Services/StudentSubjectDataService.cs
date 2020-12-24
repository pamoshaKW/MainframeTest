using Mainframe.Test.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mainframe.Test.Data.Data_Services
{

    public interface IStudentSubjectDataService : IBaseDataService
    {
        StudentSubject GetStudentSubjects(int id);
       
    }

    
    public class StudentSubjectDataService:BaseDataService,IStudentSubjectDataService
    {
        private DatabaseContext databaseContext;

        public StudentSubjectDataService(DatabaseContext databaseContext) : base(databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public StudentSubject GetStudentSubjects(int id)
        {
           //     var innerJoinQuery =
             //     from student in Students
               //   join subject in Students on student.SubjectID equals subject.Id
                 // select new { Id = student.Id, Id = subject.Id };

      

            var results = (from s in databaseContext.StudentSubject
                           where s.StudentsId == id
                           select s);
                           //.ToList();
            return results.FirstOrDefault();
            
        }

       /* public void GetDetails(StudentSubject studentSubject)
        {
            throw new NotImplementedException();
        }
       */
    }
}
