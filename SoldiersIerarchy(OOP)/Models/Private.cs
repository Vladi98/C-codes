using ClassesIerarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesIerarchy
{
  public class Private:Soldier,IPrivate
   {
        private decimal salary;

        public Private(int id,string firstName,string lastName,decimal salary):base(id,firstName,lastName)
        {
            this.salary = salary;
        }

        public decimal Salary { get { return this.salary; } set { this.salary = value; } }

        public override string ToString()
        {

            var sb = new StringBuilder();

            sb.AppendLine($"Name {FirstName} {LastName} Id {Id} Salary{Salary}");
            

            return sb.ToString().TrimEnd();
        }
    }
}
