using CompanyG02.Data.Models;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CompanyG02.Data.DataSeed
{
    internal static class CompayDBContextSeed 
    {
        public static void Seed(CompanyDBContext DBContextSeed)
        {
            if (!DBContextSeed.Departments.Any())
            {
                var DepartmentsData = File.ReadAllText("C:\\Users\\moham\\OneDrive\\Desktop\\efcore demo\\efcore demo\\CompanyG02Solution\\CompanyG02\\Data\\DataSeed\\departments.json");
                var Departments = JsonSerializer.Deserialize<List<Department>>(DepartmentsData);
                if (Departments?.Count > 0)
                {
                    foreach (var item in Departments)
                    {
                        DBContextSeed.Add(item);
                    }
                    DBContextSeed.SaveChanges();
                }
            }
            if (!DBContextSeed.Employees.Any())
            {
                var EmployeesData = File.ReadAllText("C:\\Users\\moham\\OneDrive\\Desktop\\efcore demo\\efcore demo\\CompanyG02Solution\\CompanyG02\\Data\\DataSeed\\employees.json");
                var Employees = JsonSerializer.Deserialize<List<Employee>>(EmployeesData);
                if (Employees?.Count > 0)
                {
                    foreach (var item in Employees)
                    {
                        DBContextSeed.Add(item);
                    }
                    DBContextSeed.SaveChanges();
                }
            }

        }
    }
}
