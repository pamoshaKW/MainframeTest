using System;
using System.Collections.Generic;
using System.Text;



namespace Mainframe.Test.Core.Dtos

{
    public class StudentSubjectDto
    {
        //seperate Id for StudentSubjectDto
        public int Id { get; set; }
        public int StudentsId { get; set; }
        
        public int SubjectsId { get; set; }

        //why subjectName
        public String SubjectName { get; set; }
        
        public int Credits { get; set; }
        public String description { get; set; }
        public int OfferedYear { get; set; }
        public int OfferedSemester { get; set; }
        



        //to connect with the studentDto
        public StudentDto StudentDto{ get; set; }

        //to connect with the subjectDto
        public SubjectDto SubjectDto { get; set; }


       // public ICollection<StudentSubjectDto> StudentSubjects { get; set; }
    }
}
