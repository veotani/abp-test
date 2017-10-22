using System.Collections.Generic;
using System.Linq;
using System.Net;
using Abp.Application.Services;
using ABPTest.DTO;
using ABPTest.Entities;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using ABPTest.ApplicationServices.Interfaces;

namespace ABPTest.ApplicationServices
{
    public class StudentAppService: ApplicationService, IStudentAppService
    {
        private readonly IRepository<Student> _studentRepository;
        private readonly IObjectMapper _objectMapper;

        public StudentAppService(IRepository<Student> studentRepository, IObjectMapper objectMapper)
        {
            _studentRepository = studentRepository;
            _objectMapper = objectMapper;
        }

        
        public IEnumerable<StudentOutputDto> GetStudentInformation()
        {
            var students = _studentRepository.GetAll()
                .ToList();

            return students.Select(stEntity => _objectMapper.Map<StudentOutputDto>(stEntity));
        }

        public void InsertStudent(StudentOutputDto student)
        {
            var studentEntity = _objectMapper.Map<Student>(student);
            _studentRepository.Insert(studentEntity);
        }
        public StudentOutputDto GetStudent()
        {
            //ВАРИАНТ ДЛЯ РАБОЧЕЙ БД
            //var student = _studentRepository.Get(0);
            //return _objectMapper.Map<StudentOutputDto>(student);

            //ВАРИАНТ БЕЗ БД
            //return new StudentOutputDto()
            //{
            //    Adress = "ad",
            //    BirthDate = "asd",
            //    EMail = "awe0",
            //    FullName = "asdasd",
            //    INN = "Asdasd",
            //    Sex = "Asdasd",
            //    TelephoneNumber = "asdaswrqew"
            //};

            //ВАРИАНТ С НЕРАБОЧЕЙ БД

            //Закомментил т.к. в БД достаточно студентов
            //var studentEntity = new Student()
            //{
            //    Adress = "ad",
            //    BirthDate = "asd",
            //    EMail = "awe0",
            //    FullName = "asdasd",
            //    INN = "Asdasd",
            //    Sex = "Asdasd",
            //    TelephoneNumber = "asdaswrqew"
            //};
            //_studentRepository.Insert(studentEntity);
            var student = _studentRepository.Get(6);
            return _objectMapper.Map<StudentOutputDto>(student);


        }
    }
}
