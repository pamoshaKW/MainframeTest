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

        StudentSubjectDto GetStudentSubjects(int id);

    }
    public class StudentBusinessEntity : IStudentBusinessEntity
    {
        private IStudentDataService studentDataService;

        private IStudentSubjectDataService studentSubjectDataService;

        public StudentBusinessEntity(IStudentDataService studentDataService, IStudentSubjectDataService studentSubjectDataService)
        {
            this.studentDataService = studentDataService;
            this.studentSubjectDataService = studentSubjectDataService;
        }

        public int AddStudent(StudentDto value)
        {
            var student = new Students();
            student.Id = value.Id;
            student.StudentName = value.StudentName;
            student.Grade = value.Grade;
            student.Address = value.Address;
            student.Age = value.Age;


            return this.studentDataService.AddStudent(student);
        }
        public List<StudentDto> GetStudents()
        {
            var studentDtos = studentDataService.GetStudents();
         //   var studentSubjectDtos = studentSubjectDataService.GetStudentSubjects();


            var studentDtoList = studentDtos.Select(p => new StudentDto()
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
        
            /*studentDto.StudentSubjects = studentDataService.GetSubjectByStudent(studentDto.Id).Select(d => new StudentSubjectDto
            {
                Id = d.Id,
                StudentId = student.Id,
                SubjectId=student.SubjectID,
                SubjectName=d.

            }).ToList();

            */

            return studentDto;
        }


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
    }


}
