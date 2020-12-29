using Mainframe.Test.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mainframe.Test.Data.Data_Services
{
    public interface IStudentDataService:IBaseDataService
    {
        int AddStudent(Students students);
        IEnumerable<Students> GetStudents();
        Students GetStudentByID(int id);
        
     
    }
    public class StudentDataService: BaseDataService,IStudentDataService
    {

        private DatabaseContext databaseContext;
        public StudentDataService(DatabaseContext databaseContext): base(databaseContext)
        {
            this.databaseContext = databaseContext;
        }


        public int AddStudent(Students students)
        {
            databaseContext.Students.Add(students);
            databaseContext.SaveChanges();
            return students.Id;

        }

        public IEnumerable<Students> GetStudents()
        {
            var students = (from e in databaseContext.Students
                           select e).ToList();

            return students;
                          
        }

        public Students GetStudentByID(int id)
        {
            var student = from e in databaseContext.Students
                          where e.Id == id
                          select e;

            return student.FirstOrDefault();

        }

      
       

    }

}
