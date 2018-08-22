using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _03. Mankind
{
    public class Student : Person
    {
        private string facultyNumber;

        public Student(string firstName, string secondName, string facultyNumber)
            : base(firstName, secondName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (IsNumberInvalid(value))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public override string FirstName
        {
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }

                base.FirstName = value;
            }
        }

        private bool IsNumberInvalid(string value)
        {
            bool isNumberInvalid = false;

            string numberPattern = @"^([0-9a-zA-Z]{5,10})$";

            var regex = new Regex(numberPattern);

            var match = regex.Match(value);

            if (match.Success)
            {
                return isNumberInvalid;
            }

            return !isNumberInvalid;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());

            result.AppendLine(string.Format(
                "Faculty number: {0}", this.FacultyNumber));

            return result.ToString().Trim();
        }
    }

}
