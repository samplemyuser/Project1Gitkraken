using Project1Console.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Console.AClasses
{
    public abstract class AClassPleaseTestMe : ITestMePlease
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public DateTime BirthDate { get; set; }

        protected AClassPleaseTestMe(int id, string name,DateTime birthDate)
        {
            this.Id = id;
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public int ReturnId()
        {
            return this.Id;
        }

        public string ReturnName()
        {
            return this.Name;
        }

        public string ReturnIdAndName()
        {
            return $"Id : is {this.Id} , Name is {this.Name}";
        }
    }
}
