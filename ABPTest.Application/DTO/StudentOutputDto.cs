using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ABPTest.Entities;

namespace ABPTest.DTO
{
    [AutoMapFrom(typeof(Student))]
    [AutoMapTo(typeof(Student))]
    public class StudentOutputDto
    {
        public virtual string FullName { get; set; }
        public virtual string Sex { get; set; }
        public virtual string BirthDate { get; set; }
        public virtual string INN { get; set; }
        public virtual string EMail { get; set; }
        public virtual string TelephoneNumber { get; set; }
        public virtual string Adress { get; set; }
    }
}
