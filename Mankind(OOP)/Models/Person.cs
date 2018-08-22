namespace _03.Mankind
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Person
    {
        private string firstName;
        private string secondName;

        public Person(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }

        public virtual string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }

                this.firstName = value;
            }
        }

        public string SecondName
        {
            get
            {
                return this.secondName;
            }

            set
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }

                this.secondName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format(
                "First Name: {0}", this.FirstName));
            result.AppendLine(string.Format(
                "Last Name: {0}", this.SecondName));

            return result.ToString();
        }
    }

}