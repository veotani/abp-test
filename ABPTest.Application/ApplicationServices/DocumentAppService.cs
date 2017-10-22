using System;
using System.Collections.Generic;
using System.Linq;
using ABPTest.ApplicationServices.Interfaces;
using ABPTest.DTO;
using ABPTest.Entities;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;

namespace ABPTest.ApplicationServices
{
    class DocumentAppService: IDocumentAppService
    {
        private readonly IRepository<Document> _documentRepository;
        private readonly IObjectMapper _objectMapper;

        public DocumentAppService(IRepository<Document> documentRepository,  IObjectMapper objectMapper)
        {
            _documentRepository = documentRepository;
            _objectMapper = objectMapper;           
        }

        public void PostDocument(DocumentDto documentDto)
        {
            _documentRepository.Insert(_objectMapper.Map<Document>(documentDto));
        }

        public void PostDocumentCollection(IQueryable<DocumentDto> documentDtoCollection)
        {
            foreach (var document in documentDtoCollection)
            {
                _documentRepository.Insert(_objectMapper.Map<Document>(document));
            }
        }

        public DocumentDto GetDocumentById(int id)
        {
            try
            {
                var documentEntity = _documentRepository.Get(id);
                return _objectMapper.Map<DocumentDto>(documentEntity);
            }
            catch (Exception)
            {
                return new DocumentDto() {Id = 0, Name = "", Number = ""};
            }
        }

        public IQueryable<DocumentDto> GetAllDocuments()
        {
            List<DocumentDto> documentDtos = new List<DocumentDto>();
            var documentEntities = _documentRepository.GetAll();
            foreach (var document in documentEntities)
            {
                documentDtos.Add(_objectMapper.Map<DocumentDto>(document));
            }
            return documentDtos.AsQueryable();
        }
    }
}
