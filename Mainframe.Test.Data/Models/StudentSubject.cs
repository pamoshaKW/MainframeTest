using System;
using System.Collections.Generic;
using System.Text;

namespace Mainframe.Test.Data.Models
{
    public class StudentSubject
    {
        //Is this is Id needed?yes. Seperate Id for StudentSubject model
        public int Id { get; set; }
        public int StudentsId { get; set; }

        public int SubjectsId { get; set; }

        public string SubjectName { get; set; }
        public int Credits { get; set; }
        public string description { get; set; }
        public int OfferedYear { get; set; }
        public int OfferedSemester { get; set; }



        //To connect with Subjects model
        public Subjects Subjects { get; set; }

        //To connect with Students model
        public Students Students { get; set; }

        //public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
