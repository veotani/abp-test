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
    public interface IDocumentAppService : IApplicationService
    {
        [HttpPost]
        void PostDocument(DocumentDto documentDto);
        [HttpPost]
        void PostDocumentCollection(IQueryable<DocumentDto> documentDtoCollection);
        [HttpGet]
        DocumentDto GetDocumentById(int id);
        [HttpGet]
        IQueryable<DocumentDto> GetAllDocuments();
    }
}
