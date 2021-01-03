using Mainframe.Test.Core.Dtos;
using Mainframe.Test.Data.Data_Services;
using Mainframe.Test.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mainframe.Test.Core.Business_Entities
{

    public interface IStudentSubjectBusinessEntity
    {
        List<StudentSubjectDto> GetSubjectByStudent(int studentId);
        //  List<SubjectDto> GetResultingSubjects(int subjectId);
        int AssignSubject(StudentSubjectDto value);

       
    }
    public class StudentSubjectBusinessEntity :IStudentSubjectBusinessEntity
    {

        private IStudentSubjectDataService  studentSubjectDataService;
        private ISubjectDataService subjectDataService;
        private ISubjectBusinessEntity subjectBusinessEntity;


        public StudentSubjectBusinessEntity(IStudentSubjectDataService studentSubject,ISubjectBusinessEntity subjectBusinessEntity, ISubjectDataService subjectDataService)     
        {
            this.studentSubjectDataService = studentSubject;
            this.subjectDataService = subjectDataService;
            this.subjectBusinessEntity = subjectBusinessEntity;


        }



        public List<StudentSubjectDto> GetSubjectByStudent(int studentId)
        {

          //  StudentSubjectDto studentSubjectDto = new StudentSubjectDto();

            var StudentSubjects = studentSubjectDataService.GetSubjectByStudent(studentId);

            var StudentSubjectsList = StudentSubjects.Select(p => new StudentSubjectDto()
            {

                StudentsId = p.StudentsId,
                SubjectsId = p.SubjectsId,
                 SubjectDto = GetResultingSubject(p.SubjectsId)
                
            }).ToList();

          

            return StudentSubjectsList;
         
           
        }


        public SubjectDto GetResultingSubject(int subjectId)
        {

                var subjectIDs = this.subjectBusinessEntity.GetSubjectById(subjectId);
    
                return subjectIDs;

            //var subjectIDs = this.subjectDataService.GetSubjectById(subjectId);

            /*      var result = subjectDataService.GetSubjectById(subjectId);
                    var subject = new SubjectDto();

                    subject.Id = result.Id;
                    subject.SubjectName = result.SubjectName;
                    subject.Credits = result.Credits;
                    subject.description = result.description;
                    subject.OfferedYear = result.OfferedYear;
                    subject.OfferedSemester = result.OfferedSemester;


                    return subject;


              */
        }



        public int AssignSubject(StudentSubjectDto value)
        {
            var studentsubject = new StudentSubject();
            studentsubject.Id = value.Id;
            studentsubject.StudentsId = value.StudentsId;
            studentsubject.SubjectsId = value.SubjectsId;
           

            return studentSubjectDataService.AssignSubject(studentsubject);
        }


        








    }
}





