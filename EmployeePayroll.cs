using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Payroll
{
    public class EmployeePayroll
    {  
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public string Adrdeess { get; set; }
        public string Department{ get; set; }
        public char Gender { get; set; }
        public double BasicPay { get; set; }
        public double Deductions{ get; set; }
        public double  TaxablePay{ get; set; }
        public double Tax{ get; set; }
        public double NetPay{ get; set; }
        public DateTime StartTime{ get; set; }
        public string City{ get; set; }
        public string Country { get; set; }

    }
}
