using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Abp.Application.Services;
using ABPTest.DTO;

namespace ABPTest.ApplicationServices.Interfaces
{
    public interface IStudentAppService: IApplicationService
    {
        [HttpPost]
        void InsertStudent(StudentOutputDto student);
        [HttpGet]
        IEnumerable<StudentOutputDto> GetStudentInformation();
        [HttpGet]
        StudentOutputDto GetStudent();
    }
}
