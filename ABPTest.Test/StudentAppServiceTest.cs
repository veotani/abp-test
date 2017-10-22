using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ABPTest.ApplicationServices;

namespace ABPTest.Test
{
    public class StudentAppServiceTest
    {
        [Fact]
        public void GetStudentInformationTest()
        {
            var studentAppService = new StudentAppService();
            var studentInformation = studentAppService.GetStudentInformation();
            Assert.NotEqual(studentInformation, null);
        }
    }
}
