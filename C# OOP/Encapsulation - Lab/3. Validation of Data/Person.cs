using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName
        {
            get { return firstName; }

           private set 
            {
                if (value.Length <3)
                {
                    throw new ArgumentException ("First name cannot contain fewer than 3 symbols!");
                }
                else
                {
                   firstName = value; 
                }
            }
        }

        public string LastName
        {
            get { return lastName; }

            set 
            {
                if (value.Length <3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                else
                {
                    lastName = value;
                }
            }
        }

        public int Age
        {
            get { return age; }

            set
            {
                if (value > 0)
                {
                    age = value; 
                }
                else
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
            }
        }


        public decimal Salary
        {
            get { return salary; }

            set 
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
                else
                {
                    salary = value; 
                }
            }
        }


        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                decimal prcntage = percentage / 2;
                this.Salary += Salary * prcntage / 100;
            }
            else
            {
                this.Salary += Salary * percentage / 100;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
    }
}
