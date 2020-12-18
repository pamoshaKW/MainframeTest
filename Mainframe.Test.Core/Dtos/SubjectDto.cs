using System;
using System.Collections.Generic;
using System.Text;

namespace Mainframe.Test.Core.Dtos
{
    public class SubjectDto
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public int Credits { get; set; }
        public string description { get; set; }
        public int OfferedYear { get; set; }
        public int OfferedSemester { get; set; }

        public ICollection<StudentSubjectDto> StudentSubjects { get; set; }
    }
}
