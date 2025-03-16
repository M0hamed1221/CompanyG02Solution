using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyG02.Data.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeViewMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "DetailedAdrress_Country",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DetailedAdrress_blockNo",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailedAdrress_city",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailedAdrress_street",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailedAdrress_Country",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DetailedAdrress_blockNo",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DetailedAdrress_city",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DetailedAdrress_street",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
