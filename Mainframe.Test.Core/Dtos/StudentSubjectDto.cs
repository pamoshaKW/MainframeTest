using System;
using System.Collections.Generic;
using System.Text;

namespace Mainframe.Test.Core.Dtos
{
    public class StudentSubjectDto
    {
        public StudentDto Students { get; set; }

        public SubjectDto Subjects { get; set; }
    }
}
