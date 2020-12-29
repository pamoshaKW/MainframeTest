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

     
        public StudentDto StudentDto{ get; set; }

        public SubjectDto SubjectDto { get; set; }


       // public ICollection<StudentSubjectDto> StudentSubjects { get; set; }
    }
}
