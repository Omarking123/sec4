using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec4Demo
{
    internal class Employee :ICloneable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public Employee()
        {
            
        }
        public Employee(Employee employeeCopy)
        {
            this.Id = employeeCopy.Id;
            this.Name = employeeCopy.Name;  
            this.Salary = employeeCopy.Salary;
            this.department = (department?)employeeCopy?.department?.clone();
        }
        public object Clone()
        {
            return new Employee()
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary
            };
        }

        public override string ToString()
        {
            return $"id {Id }name {Name} , salary : {Salary :c}";

        }
    }   
}
