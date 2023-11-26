﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9
{
    class Employee
    {
        protected string name;
        protected int age;
        protected double salary;

        public Employee(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}");
        }

        public virtual double CalculateAnnualSalary()
        {
            return salary * 12;
        }
    }
}
