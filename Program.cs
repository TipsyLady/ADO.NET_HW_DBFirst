using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.NET_HW_DBFirst.EmployeeModel;
using ADO.NET_HW_DBFirst.DL;
using static System.Console;

namespace ADO.NET_HW_DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //Добавление
            //    EmployeeMod employee = new EmployeeMod()
            //    {
            //        FirstName = "Fill",
            //        LastName = "Uvarov",
            //        BirthDate = new DateTime(2000, 10, 10),
            //        EmployeeID = 24,
            //        PositionID = 2,
            //        Salary = 9000
            //    };
            //    DL.DL.Employee.Add_Empl(employee);

            //Удаление
            //DL.DL.Employee.Delete_Empl(1019);

            //Обновить
            EmployeeMod employee = new EmployeeMod()
            {
                FirstName = "Алия",
                LastName = "Кротова",
                BirthDate = new DateTime(2000, 10, 10),
                EmployeeID = 23,
                PositionID = 2,
                Salary = 6000
            };
            DL.DL.Employee.Update_Empl(employee);

            //Просмотр всех сотрудников
            //IEnumerable<EmployeeMod> employees = DL.DL.Employee.All();
            //foreach (var item in employees)
            //{
            //    WriteLine($"{item.EmployeeID} {item.FirstName}  {item.LastName}");
            //}

        }


    }
}
