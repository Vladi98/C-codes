using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesIerarchy
{
  public  class Commando:SpecializedSoldier
    {

        public Commando(int id, string firstName, string lastName, decimal salary, CorpType corp) : base(id, firstName, lastName, salary, corp)
        {
        }

        public ICollection<Missions> Missions { get; set; } = new List<Missions>();

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Name {FirstName} {LastName} Id {Id} Salary: {Salary} Corps {Corp}");

            foreach (var item in Missions)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
