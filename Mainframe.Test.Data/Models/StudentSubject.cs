﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mainframe.Test.Data.Models
{
    public class StudentSubject
    {
        //Seperate Id for StudentSubject model
        public int Id { get; set; }
        public int StudentsId { get; set; }
        public int SubjectsId { get; set; }
     
        public virtual Student Students { get; set; }

        public Subject Subjects { get; set; }

       

        // public ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
