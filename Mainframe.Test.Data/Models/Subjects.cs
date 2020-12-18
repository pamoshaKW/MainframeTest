using System;
using System.Collections.Generic;
using System.Text;

namespace Mainframe.Test.Data.Models
{
    public class Subjects
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public int Credits { get; set; }
        public string description { get; set; }
        public int OfferedYear { get; set; }
        public int OfferedSemester { get; set; }

        public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
