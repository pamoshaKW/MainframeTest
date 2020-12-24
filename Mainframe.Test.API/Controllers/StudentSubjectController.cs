using Mainframe.Test.Core.Business_Entities;
using Mainframe.Test.Core.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mainframe.Test.API.Controllers
{

    [Produces("application/json")]
    [Route("api/Students/click")]
    public class StudentSubjectController : Controller
    {
        private IStudentBusinessEntity studentBusinessEntity;

        public StudentSubjectController(IStudentBusinessEntity studentBusinessEntity)
        {
            this.studentBusinessEntity = studentBusinessEntity;
        }

        // GET: SubjectController/Details/5
        [HttpGet("{id}")]

        public StudentSubjectDto GetSubject(int id)
        {
            return studentBusinessEntity.GetStudentSubjects(id);
        }


    






    }
}
