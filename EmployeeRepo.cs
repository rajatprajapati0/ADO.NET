using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Employee_Payroll
{
    public class EmployeeRepo
    {
        public static string connectstring = @"Data Source=.;Initial Catalog=EMPLOYEE_DATA;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectstring);

        public void GetEmpData()
        {

            EmployeePayroll employeePayroll = new EmployeePayroll();
            using (this.connection)
            {
                string query = @"SELECT EmployeeId ,EmployeeName ,PhoneNumber ,Adrdeess ,Department ,Gender ,BasicPay ,Deductions, TaxablePay , Tax , NetPay , StartTime,  City ,Country FROM EMPLOYEE_PAYROLL ;";

                SqlCommand scomand = new SqlCommand(query, this.connection);

                this.connection.Open();

                SqlDataReader reader = scomand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employeePayroll.EmployeeId = reader.GetInt32(0);
                        employeePayroll.EmployeeName = reader.GetString(1);
                        employeePayroll.PhoneNumber = reader.GetString(2);
                        employeePayroll.Adrdeess = reader.GetString(3);
                        employeePayroll.Department = reader.GetString(4);
                        employeePayroll.Gender= Convert.ToChar(reader.GetString(5));
                        employeePayroll.BasicPay=reader.GetDouble(6);
                        employeePayroll.Deductions = reader.GetDouble(7);
                        employeePayroll.TaxablePay=reader.GetDouble(8);
                        employeePayroll.Tax = reader.GetDouble(9);
                        employeePayroll.NetPay = reader.GetDouble(10);

                       
                        employeePayroll.StartTime = reader.GetDateTime(11);
                        employeePayroll.City = reader.GetString(12);
                        employeePayroll.Country = reader.GetString(13);
                        Console.WriteLine
                        ("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",
                        employeePayroll.EmployeeId,employeePayroll.EmployeeName ,employeePayroll.PhoneNumber,employeePayroll.Adrdeess,employeePayroll.Department,employeePayroll.Gender,employeePayroll.BasicPay,employeePayroll.Deductions,employeePayroll.TaxablePay,employeePayroll.Tax,employeePayroll.NetPay,employeePayroll.StartTime,employeePayroll.City,employeePayroll.Country);
                    }
                }
                else
                {
                    Console.WriteLine("no data found");
                }
                reader.Close();
            }



        }
    }
}
