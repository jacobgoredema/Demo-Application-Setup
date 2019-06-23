using MVCAppDb.Data.DataAcess;
using MVCAppDb.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCAppDb.Data.BusinesLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId, string firstName, string lastName, string email,string password)
        {
            EmployeeVm data = new EmployeeVm
            {
                EmployeeID = employeeId,
                Firstname = firstName,
                Lastname = lastName,
                Email = email,
                Password=password
            };

            string sql=@"insert into dbo.Employee(EmployeeId,FirstName,LastName,Email, Password)
                        values(@EmployeeID, @FirstName, @LastName, @Email, @Password);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeVm> LoadEmployees()
        {
            string sql=@"select Id, EmployeeID,FirstName,LastName,Email
                from dbo.Employee;";

            return SqlDataAccess.LoadData<EmployeeVm>(sql);
        }
    }
}
