using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace ABPTest.Entities
{
    public class Document: IEntity
    {
        public virtual string Number { get; set; }
        public virtual string Name { get; set; }
        public bool IsTransient()
        {
            throw new NotImplementedException();
        }

        public int Id { get; set; }
    }
}
