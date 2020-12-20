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
    [Route("api/subjects")]
    public class SubjectController : Controller
    {
        private ISubjectBusinessEntity SubjectBusinessEntity;
        public SubjectController(ISubjectBusinessEntity subjectBusinessEntity)
        {
            this.SubjectBusinessEntity = subjectBusinessEntity;
        }


        // GET: SubjectController
        [HttpGet]
        public IEnumerable<SubjectDto> GetSubjects()
        {
            return SubjectBusinessEntity.GetSubjects();
        }

        // GET: SubjectController/Details/5
        [HttpGet("{id}")]
        public SubjectDto GetSubject(int id)
        {
            return SubjectBusinessEntity.GetSubjectById(id);
        }

      

        // POST: SubjectController/Create
        [HttpPost]
        
        //why from body is used
        public int AddSubject([FromBody]SubjectDto values)
        {

            return SubjectBusinessEntity.AddSubject(values);
            
        }

       

        // POST: SubjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SubjectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

       
        
    }
}
