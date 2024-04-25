using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee_CRUD.Migrations
{
    /// <inheritdoc />
    public partial class DeletePhoneRow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Employees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Phone",
                table: "Employees",
                type: "bigint",
                maxLength: 10,
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phone",
                value: 9845474900L);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phone",
                value: 9876543210L);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Phone",
                value: 9807645321L);
        }
    }
}
