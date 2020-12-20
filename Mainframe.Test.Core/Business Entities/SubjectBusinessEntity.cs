using Mainframe.Test.Core.Dtos;
using Mainframe.Test.Data.Data_Services;
using Mainframe.Test.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Mainframe.Test.Core.Business_Entities
{
    public interface ISubjectBusinessEntity
    {
        public int AddSubject(SubjectDto subjectDto);
        public List<SubjectDto> GetSubjects();
        public SubjectDto GetSubjectById(int Id);
    }

    
    public class SubjectBusinessEntity:ISubjectBusinessEntity
    {

        private ISubjectDataService subjectDataService;
        public SubjectBusinessEntity(ISubjectDataService subjectDataService)
        {
            this.subjectDataService = subjectDataService;
        }

        public int AddSubject(SubjectDto subjectDto)
        {
            var subject = new Subjects();

            subject.SubjectName = subjectDto.SubjectName;
            subject.description = subjectDto.description;
            subject.Credits = subjectDto.Credits;
            subject.OfferedSemester = subjectDto.OfferedSemester;
            subject.OfferedYear = subjectDto.OfferedYear;

            return subjectDataService.AddSubject(subject);
            
        }

        public List<SubjectDto> GetSubjects()
        {
            var subjects = subjectDataService.GetSubjects();

            var subjectListDto = subjects.Select(p => new SubjectDto
            {
                Id = p.Id,
                SubjectName = p.SubjectName,
                description = p.description,
                Credits = p.Credits,
                OfferedYear = p.OfferedYear,
                OfferedSemester = p.OfferedSemester

            }).ToList();
            

            return subjectListDto;
    }

  

        public SubjectDto GetSubjectById(int id)
        {
            var subject = subjectDataService.GetSubjectById(id);

            SubjectDto subjectDto = new SubjectDto();

            subjectDto.Id = subject.Id;
            subjectDto.SubjectName = subject.SubjectName;
            subjectDto.Credits = subject.Credits;
            subjectDto.description = subject.description;
            subjectDto.OfferedYear = subject.OfferedYear;
            subjectDto.OfferedSemester = subject.OfferedSemester;

            return subjectDto;
        }
    }
}
