using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_HW_DBFirst.EmployeeModel
{
    class EmployeeMod
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<int> PositionID { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}
