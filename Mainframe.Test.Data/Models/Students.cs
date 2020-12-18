using System;
using System.Collections.Generic;
using System.Text;

namespace Mainframe.Test.Data.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int Grade { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public ICollection<StudentSubject>StudentSubjects { get; set; }
    }


}
