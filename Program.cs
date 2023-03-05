using System;

namespace Employee_Payroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome Employee Paroll");
            EmployeeRepo repo = new EmployeeRepo();
            repo.GetEmpData();
        }
    }
}
