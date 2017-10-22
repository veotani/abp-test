using Abp.Domain.Repositories;
using ABPTest.Entities;
using Xunit;

namespace ABPTest.Test
{
    public class RepositoryTest
    {
        //[Fact]
        //public void GetStudentTest()
        //{
        //    var repository = new FakeRepository<Student>();
        //    var student = repository.GetEntity();
        //    Assert.NotEqual(student, null);
        //}

        //[Fact]
        //public void GetDocumentTest()
        //{
        //    var repository = new FakeRepository<Document>();
        //    var document = repository.GetEntity();
        //    Assert.NotEqual(document, null);
        //}

        //[Fact]
        //public void GetDocumentsTest()
        //{
        //    var repository = new FakeRepository<Document>();
        //    var documents = repository.GetAllEntities();
        //    Assert.NotEqual(documents, null);
        //}
        //[Fact]
        //public void GetStudentsTest()
        //{
        //    var repository = new FakeRepository<Student>();
        //    var students = repository.GetAllEntities();
        //    Assert.NotEqual(students, null);
        //}
        private readonly IRepository<Student> _studentRepository;

        public RepositoryTest(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [Fact]
        public void AddStudent()
        {
            var student = new Student()
            {
                Adress = "adres",
                BirthDate = "bdate",
                EMail = "mail",
                FullName = "name",
                Id = 0,
                INN = "inn",
                TelephoneNumber = "num",
                Sex = "sex"
            };

            _studentRepository.Insert(student);
        }
        public void GetStudentTest()
        {
            
        }
    }
}
