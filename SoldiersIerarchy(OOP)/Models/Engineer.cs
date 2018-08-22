using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesIerarchy
{
  public  class Engineer:SpecializedSoldier
    {
       
        public Engineer(int id, string firstName, string lastName, decimal salary, CorpType corp):base( id,  firstName,  lastName,  salary,  corp)
        {
            this.Repairs = new HashSet<Repair>();
        }

        public ICollection<Repair> Repairs { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Name{FirstName} {LastName} Id {Id} Salary {this.Salary:F2}")
                .AppendLine($"Corps {Corp}")
                .AppendLine($"Repairs");

            foreach (var item in Repairs)
            {
                sb.AppendLine(item.ToString());
               
            }
            return sb.ToString();
        }
    }
}
