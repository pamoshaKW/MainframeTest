﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mainframe.Test.Data.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public int Credits { get; set; }
        public string Description { get; set; }
        public int OfferedYear { get; set; }
        public int OfferedSemester { get; set; }

        public List<StudentSubject> StudentSubjects { get; set; }
    }
}
