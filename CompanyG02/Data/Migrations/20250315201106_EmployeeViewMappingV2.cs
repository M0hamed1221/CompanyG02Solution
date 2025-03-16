using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyG02.Data.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeViewMappingV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create view epmloyeedepartmentview 
with encryption , schemabinding
as
select d.[Dname], e.[Fname], e.[Lname]
from 
dbo.Employee as e 
left outer join [dbo].[Departments] as d on e.[Dno]= d.[Dnum]
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Drpp view epmloyeedepartmentview");
        }
    }
}
