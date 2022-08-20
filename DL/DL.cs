using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.NET_HW_DBFirst.EmployeeModel;

namespace ADO.NET_HW_DBFirst.DL
{
    class DL
    {
        public static class Employee
        {
            public static int Add_Empl (EmployeeMod newEmployee)
            {
                using (var DB = new CompanyDBEntities())
                {
                    ObjectParameter new_employee = new ObjectParameter("EmployeeID", 0);
                    DB.stp_EmployeeAdd
                        (firstName: newEmployee.FirstName,
                        lastName: newEmployee.LastName,
                        birthDate: newEmployee.BirthDate,
                        positionID: newEmployee.PositionID,
                        salary: newEmployee.Salary,
                        employeeID: new_employee);
                    return (int)new_employee.Value;

                }
            }

            public static void Delete_Empl(int empl_ID)
            {
                using (var DB = new CompanyDBEntities())
                {
                    DB.stp_EmployeeDelete_1(employeeID: empl_ID);
                }
            }

            public static IEnumerable<EmployeeMod> All()
            {
                using (var DB = new CompanyDBEntities())
                {
                    List<EmployeeMod> employees = new List<EmployeeMod>();
                    var result = DB.stp_EmployeeALL().ToList();
                    foreach (var item in result)
                    {
                        EmployeeMod tmp = new EmployeeMod();
                        tmp.EmployeeID = item.EmployeeID;
                        tmp.LastName = item.LastName;
                        tmp.FirstName = item.FirstName;
                        employees.Add(tmp);
                    }
                    return employees;
                }
            }

            public static void Update_Empl (EmployeeMod empl_update)
            {
                using (var DB = new CompanyDBEntities())
                {
                    ObjectParameter res = new ObjectParameter("Result", 1);
                    DB.stp_EmployeeUpdate
                        (employeeID: empl_update.EmployeeID,
                        firstName: empl_update.FirstName,
                        lastName: empl_update.LastName,
                        birthDate: empl_update.BirthDate,
                        positionID: empl_update.PositionID,
                        salary: empl_update.Salary,
                        result: res);
                }
            }
        }
    }
}
