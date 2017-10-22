using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPTest.Entities
{
    public class Student: IEntity
    {
        //полное имя, пол, дата рождения, инн, e-mail, телефон, адрес
        public virtual string FullName { get; set; }
        public virtual string Sex { get; set; }
        public virtual string BirthDate{ get; set; }
        public virtual string INN { get; set; }
        public virtual string EMail { get; set; }
        public virtual string TelephoneNumber { get; set; }
        public virtual string Adress { get; set; }
        public bool IsTransient()
        {
            throw new NotImplementedException();
        }

        public int Id { get; set; }
    }
}
