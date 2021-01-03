using Mainframe.Test.Core.Business_Entities;
using Mainframe.Test.Core.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Mainframe.Test.API.Controllers
{

    [Produces("application/json")]
    [Route("api/StudentSubject")]
    public class StudentSubjectController : Controller
    {
        private IStudentSubjectBusinessEntity studentSubjectBusinessEntity;
        private ISubjectBusinessEntity subjectBusinessEntity;

        public StudentSubjectController(IStudentSubjectBusinessEntity studentSubjectBusinessEntity, ISubjectBusinessEntity subjectBusinessEntity)
        {
            this.studentSubjectBusinessEntity = studentSubjectBusinessEntity;
            this.subjectBusinessEntity = subjectBusinessEntity;
        }
       
        
        /*
        [HttpGet]
        public string GetStudents()
        {
            return "Hello";
        }

        */

        // GET: SubjectController/Details/5
        [HttpGet("{id}")]
        public IEnumerable<StudentSubjectDto> GetSubjectByStudent(int id)
        {
            IEnumerable<StudentSubjectDto> list = studentSubjectBusinessEntity.GetSubjectByStudent(id);

            return list;
        }

        [HttpPost]
        public int AssignSubject([FromBody] StudentSubjectDto value)
        {
            return studentSubjectBusinessEntity.AssignSubject(value);
        }

        
        [HttpGet]
            public SubjectDto GetResultingSubject(int subjectId)
        {
            var subjectIDs = this.subjectBusinessEntity.GetSubjectById(subjectId);

            return subjectIDs;
        }

             
                        
          
    }

}
