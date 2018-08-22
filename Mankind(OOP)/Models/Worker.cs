using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Mankind
{

    public class Worker : Person
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string secondName, double weekSalary, double workHoursPerDay)
            : base(firstName, secondName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value > 12 || value < 1)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHoursPerDay = value;
            }
        }

        public double CalcSalary()
        {
            double salary = this.weekSalary / 5 / this.WorkHoursPerDay;

            return salary;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());

            result.AppendLine(string.Format(
                "Week Salary: {0:F2}", this.WeekSalary));
            result.AppendLine(string.Format(
                "Hours per day: {0:F2}", this.WorkHoursPerDay));
            result.AppendLine(string.Format(
                "Salary per hour: {0:F2}", this.CalcSalary()));

            return result.ToString().Trim();
        }
    }

}
