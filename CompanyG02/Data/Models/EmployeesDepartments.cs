using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyG02.Data.Models
{
    public class EmployeesDepartments
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public int? EmployeeId { get; set; }

        public string? EmployeeName { get; set; }

    }
}
