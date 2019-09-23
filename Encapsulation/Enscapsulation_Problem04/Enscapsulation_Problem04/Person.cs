﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Enscapsulation_Problem04
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva");
                }
                this.salary = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or negative integer");
                }
                this.age = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"Last name cannot be less than 3 symbols");
                }
                this.lastName = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"First name cannot be less than 3 symbols");
                }
                this.firstName = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age <= 30)
            {
                this.Salary += this.Salary * percentage / 200;
            }
            else
            {
                this.Salary += this.Salary * percentage / 100;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} get {this.Salary:F2} leva";
        }
    }
}
