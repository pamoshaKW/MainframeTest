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
    [Route("api/Students")]
    public class StudentController : Controller
    {
        private IStudentBusinessEntity studentBusinessEntity;
        public StudentController(IStudentBusinessEntity studentBusinessEntity)
        {
            this.studentBusinessEntity = studentBusinessEntity;
        }



        [HttpGet]
        public IEnumerable<StudentDto> GetStudents()
        {
            return this.studentBusinessEntity.GetStudents();
        }

        [HttpPost]
        public int AddStudent([FromBody] StudentDto value)
        {
            return studentBusinessEntity.AddStudent(value);
        }

        // GET: StudentController/Edit/5
        [HttpGet("{id}")]
        public StudentDto GetUser(int id)
        {
            return studentBusinessEntity.GetStudentById(id);
        }



    }
}
