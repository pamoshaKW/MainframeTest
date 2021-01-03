using System;
using System.Collections.Generic;
using System.Text;
using Mainframe.Test.Core.Dtos;
using Mainframe.Test.Data.Data_Services;
using Mainframe.Test.Data.Models;
using System.Linq;


namespace Mainframe.Test.Core.Business_Entities
{
    public interface IStudentBusinessEntity
    {
        int AddStudent(StudentDto value);
        List<StudentDto> GetStudents();
        StudentDto GetStudentById(int id);

       // List<StudentSubject> GetSubjectByStudent(int studentId);

    }
    public class StudentBusinessEntity : IStudentBusinessEntity
    {
        private IStudentDataService studentDataService;

  //      private IStudentSubjectDataService studentSubjectDataService;

        public StudentBusinessEntity(IStudentDataService studentDataService
            //, IStudentSubjectDataService studentSubjectDataService
            )
        {
            this.studentDataService = studentDataService;
 //           this.studentSubjectDataService = studentSubjectDataService;
        }

        public int AddStudent(StudentDto value)
        {
            var student = new Student();
            student.Id = value.Id;
            student.StudentName = value.StudentName;
            student.Grade = value.Grade;
            student.Address = value.Address;
            student.Age = value.Age;


            return this.studentDataService.AddStudent(student);
        }


        public List<StudentDto> GetStudents()
        {
            var students = studentDataService.GetStudents();
         //   var studentSubjectDtos = studentSubjectDataService.GetStudentSubjects();


            var studentDtoList = students.Select(p => new StudentDto()
            {
                Id = p.Id,
                StudentName = p.StudentName,
                Age = p.Age,
                Address = p.Address,
                Grade = p.Grade,
               // SubjectID = p.SubjectID
            }).ToList();

       


            //studentDtoList.ForEach(p => {
            //   var subject = studentSubjectDtos.FirstOrDefault(s => s.Su == p.SubjectID);

            //   if (supplierBase != null)
            //  {
            //      p.DefaultSupplierBaseName = supplierBase.SupplierBaseName;
            //  }

            // });

            return studentDtoList;

        }

        public StudentDto GetStudentById(int id)
        {
            var student = this.studentDataService.GetStudentByID(id);
            var studentDto = new StudentDto();

            studentDto.Id = student.Id;
            studentDto.StudentName = student.StudentName;
            studentDto.Age = student.Age;
            studentDto.Address = student.Address;
            studentDto.Grade = student.Grade;
        
          

            return studentDto;
        }


        /*
        public List<Subjects> GetSubjectByStudent(int studentId)
        {

            StudentSubjectDto studentSubjectDto = new StudentSubjectDto();

            var StudentSubjects = studentDataService.GetSubjectByStudent(studentSubjectDto.Id);
            var StudentSubjectsList = StudentSubjects.Select(d => new StudentSubjectDto
            {
                Id = d.Id,
                StudentsId = d.Id,
                SubjectsId = d.SubjectsId,


            }).ToList();
            

            return StudentSubjectsList;
        }

        */

            
    /*
    public  StudentSubjectDto GetStudentSubjects(int id)
    {
       // var selectedStudent = studentDataService.GetStudentByID(id);
        var subjectDetails = this.studentSubjectDataService.GetStudentSubjects(id);


        var subjectOfaStudent= new StudentSubjectDto();

        subjectOfaStudent.Id = subjectDetails.Id;
        subjectOfaStudent.StudentsId = subjectDetails.StudentsId;
        subjectOfaStudent.SubjectsId = subjectDetails.SubjectsId;
        subjectOfaStudent.SubjectName = subjectDetails.SubjectName;
        subjectOfaStudent.Credits = subjectDetails.Credits;
        subjectOfaStudent.description = subjectDetails.description;
        subjectOfaStudent.OfferedYear = subjectDetails.OfferedYear;
        subjectOfaStudent.OfferedSemester = subjectDetails.OfferedSemester;




        return subjectOfaStudent;
    }

    */
}



}
