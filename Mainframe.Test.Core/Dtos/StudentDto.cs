using System;
using System.Collections.Generic;
using System.Text;

namespace Mainframe.Test.Core.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int Grade { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

      //  public int SubjectID { get; set; }

      //  public string SubjectName { get; set; }

        public ICollection<StudentSubjectDto> StudentSubjects { get; set; }
    }
}
