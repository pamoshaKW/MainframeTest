using System;
using System.Collections.Generic;
using System.Text;

namespace Mainframe.Test.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int Grade { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

     // public int SubjectID { get; set; }
        public List<StudentSubject>StudentSubjects { get; set; }
    }


}
