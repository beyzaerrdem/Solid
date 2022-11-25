using System;

namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculate salaryCalculate = new SalaryCalculate(new FullTimeEmployee()); //iş yapılan classta değişiklik yapmamak için kullanıldı.
            salaryCalculate.CalculaterSalary();
        }
    }


    interface IEmployee //iş yapılan classta değişiklik yapmamak için kullanıldı.
    {
        void CalculaterSalary();
    }

    class FullTimeEmployee:IEmployee
    {
        public void CalculaterSalary()
        {
            Console.WriteLine("Full");
        }
    }

    class PartTimeEmployee:IEmployee
    {
        public void CalculaterSalary() 
        {
            Console.WriteLine("Part");
        }
    }

    class SupportEmployee:IEmployee
    {
        public void CalculaterSalary()
        {
            Console.WriteLine("Support");
        }
    }

    //Burada yeni bi seçenek eklersek SalaryCalculate i de güncellemek zorunda kalırız.
    //yeni bir durum eklediğimizde iş yapan classımızı değiştirmek zorunda kalıyorsak open-closed' ı ezmiş oluruz.

    class SalaryCalculate
    {
        //public void CalculaterSalary(string employeeType)
        //{
        //    if (employeeType == "Full")
        //    {
        //        new FullTimeEmployee().CalculaterSalary();
        //    }
        //    else
        //    {
        //        new PartTimeEmployee().CalculaterSalary();
        //    }
        //    //supportu eklemek zorunda kalırız.
        //}
        private readonly IEmployee employee;
        public SalaryCalculate(IEmployee employee) //constructor 
        {
            this.employee = employee;
        }

        public void CalculaterSalary()
        {
            this.employee.CalculaterSalary();   //iş yapılan classta değişiklik yapmamak için kullanıldı.
        }
    }
}
