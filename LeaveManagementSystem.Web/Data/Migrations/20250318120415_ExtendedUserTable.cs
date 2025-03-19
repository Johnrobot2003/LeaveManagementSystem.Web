using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bdeca61-b213-4a07-9321-d80f8d442ba4",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb81172d-6652-480c-aa50-53ca94c142bc", new DateOnly(2003, 1, 23), "Default", "Admin", "AQAAAAIAAYagAAAAEJnIbnONkR8AKfDQRy+fJOkAnVMChpkRS27Ai+YzRgIb3bPKIW6DfbmSu8qM0FdDbw==", "cee9a3ed-fd78-4929-8252-b0d0999f5c4c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bdeca61-b213-4a07-9321-d80f8d442ba4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2756d680-12db-49b5-8456-d8e0ed1044df", "AQAAAAIAAYagAAAAEClBs/fAjelfjleN8XmymmzPHaF65JeJuAKtX2Hu2hcqDOajO4jxOxz8BOfiLwnZtw==", "0e4393ed-a72c-4d56-8a36-d05fe771bb18" });
        }
    }
}
