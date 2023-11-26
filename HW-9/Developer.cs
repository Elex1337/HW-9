﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9
{
    class Developer : Employee
    {
        private int linesOfCodePerDay;

        public Developer(string name, int age, double salary, int linesOfCodePerDay) : base(name, age, salary)
        {
            this.linesOfCodePerDay = linesOfCodePerDay;
        }

        public override double CalculateAnnualSalary()
        {
            double codePayment = linesOfCodePerDay * 0.1; 

            return base.CalculateAnnualSalary() + codePayment;
        }
    }
}
