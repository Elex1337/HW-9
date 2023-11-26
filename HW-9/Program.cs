using System;
using HW_9;
class Program
   
{
     
    static void Main()
    {
        Manager manager = new Manager("John Manager", 35, 60000, 5000);

        manager.GetInfo();
        Console.WriteLine($"Annual Salary: {manager.CalculateAnnualSalary()}");

        Console.WriteLine();

        Developer developer = new Developer("Alice Developer", 28, 70000, 1000);

        developer.GetInfo();
        Console.WriteLine($"Annual Salary: {developer.CalculateAnnualSalary()}");
    }
}
