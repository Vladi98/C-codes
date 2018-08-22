using ClassesIerarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesIerarchy
{
  public class LeutenantGeneral:Private,ILeutenentGeneral
    {
        List<Private> privates;

        public LeutenantGeneral(int id, string firstName, string lastName, decimal salary,List<int> ids) :base( id,  firstName,  lastName,  salary)
        {
            this.privates = new List<Private>();
           
        }

        public List<Private> Privates { get { return this.privates; } set { this.privates = value; } }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Name {FirstName} {LastName} Id {Id} Salary{Salary}")
                .AppendLine("Privates");

            foreach (var item in Privates)
            {
                sb.AppendLine(item.ToString());
            }



            return sb.ToString().TrimEnd();
        }
    }
}
