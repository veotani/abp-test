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
    [AutoMapFrom(typeof(Document))]
    [AutoMapTo(typeof(Document))]

    public class DocumentDto: EntityDto
    {

        public virtual string Number { get; set; }
        public virtual string Name { get; set; }
    }
}
