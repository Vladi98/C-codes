using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesIerarchy
{
   public class Repair
    {
        private string partName;
        private int hoursWorked;

        public Repair(string partName,int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public string PartName
        {
            get { return this.partName; }
            set { this.partName = value; }
        }

        public int HoursWorked
        {
            get { return this.hoursWorked; }
            set { this.hoursWorked = value; }
        }

        public override string ToString()
        {
            return $"Part Name{this.PartName} Hours Worked {this.HoursWorked}";
        }
    }
}
