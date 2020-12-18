using System;
using System.Collections.Generic;
using System.Text;

namespace Mainframe.Test.Data.Models
{
    public class StudentSubject
    {
        public int Id { get; set; }
        public Students Students { get; set; }

       // public int SubjectId { get; set; }
        public Subjects Subjects { get; set; }

    }
}
