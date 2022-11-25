using System;

namespace LiskovSubstitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new FullTimeEmployee();
        }
    }

    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
        //public decimal Wage { get; set; }
    }

    class FullTimeEmployee:Employee
    {
        public decimal FullWage { get; set; }
    }

    class PartTimeEmployee:Employee
    {
        public decimal PartWage { get; set; }
    }
}
