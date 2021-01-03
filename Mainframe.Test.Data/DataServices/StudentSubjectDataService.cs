using Mainframe.Test.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mainframe.Test.Data.Data_Services
{

    public interface IStudentSubjectDataService : IBaseDataService
    {
        List<StudentSubject> GetSubjectByStudent(int studentId);
        int AssignSubject(StudentSubject value);

      // public IEnumerable<StudentSubject> GetSubjectByStudentId(int studentId);

    }
   public  class StudentSubjectDataService :BaseDataService,IStudentSubjectDataService
    {
        private DatabaseContext databaseContext;

        public StudentSubjectDataService(DatabaseContext databaseContext):base(databaseContext)
        {
            this.databaseContext = databaseContext;  
        }


        public List<StudentSubject> GetSubjectByStudent(int studentId)
        {
       
            var subjectDetails = (from ss in databaseContext.StudentSubjects
                                      where ss.StudentsId == studentId
                                      select ss).ToList();
            return subjectDetails;
      
   
        }


      

        public int AssignSubject(StudentSubject value)
        {
            databaseContext.StudentSubjects.Add(value);
            databaseContext.SaveChanges();
            return value.Id;
        }




        /*My 
        public IEnumerable<StudentSubject> GetSubjectsByStudentId(int studentId)
        {
            var subjects = (from x in databaseContext.StudentSubject
                            where x.StudentsId == studentId
                            select x).ToList();
            return subjects;
        }




        public void insertSubject(StudentSubject ss)
        {
            databaseContext.StudentSubject.Add(ss);
            databaseContext.SaveChanges();
           
        }
*/

    }
}



