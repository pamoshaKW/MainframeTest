using Mainframe.Test.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mainframe.Test.Data.Data_Services
{
    public interface IStudentDataService:IBaseDataService
    {
        int AddStudent(Student students);
        List<Student> GetStudents();
        Student GetStudentByID(int id);
        
     
    }
    public class StudentDataService: BaseDataService,IStudentDataService
    {
        private DatabaseContext databaseContext;
        public StudentDataService(DatabaseContext databaseContext): base(databaseContext)
        {
            this.databaseContext = databaseContext;
        }


        public int AddStudent(Student student)
        {
            databaseContext.Students.Add(student);
            databaseContext.SaveChanges();
            return student.Id;

        }

        public List<Student> GetStudents()
        {
            var students = (from e in databaseContext.Students
                           select e).ToList();

            return students;
                          
        }

        public Student GetStudentByID(int id)
        {
            var student = from e in databaseContext.Students
                          where e.Id == id
                          select e;

            return student.FirstOrDefault();

        }

      
       

    }

}
