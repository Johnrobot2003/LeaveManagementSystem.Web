using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7d92f11f-4d87-4ba7-9b1e-918906386c78", null, "Employee", "EMPLOYEE" },
                    { "f7023c71-325f-45af-b159-0437489f5f6f", null, "Administrator", "ADMINISTRATOR" },
                    { "f9fa948a-5780-4cfd-bb53-8b3d326014af", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1bdeca61-b213-4a07-9321-d80f8d442ba4", 0, "2756d680-12db-49b5-8456-d8e0ed1044df", "adminemail@user.com", true, false, null, "ADMINEMAIL@USER.COM", "ADMINEMAIL@USER.COM", "AQAAAAIAAYagAAAAEClBs/fAjelfjleN8XmymmzPHaF65JeJuAKtX2Hu2hcqDOajO4jxOxz8BOfiLwnZtw==", null, false, "0e4393ed-a72c-4d56-8a36-d05fe771bb18", false, "adminemail@user.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f7023c71-325f-45af-b159-0437489f5f6f", "1bdeca61-b213-4a07-9321-d80f8d442ba4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d92f11f-4d87-4ba7-9b1e-918906386c78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9fa948a-5780-4cfd-bb53-8b3d326014af");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f7023c71-325f-45af-b159-0437489f5f6f", "1bdeca61-b213-4a07-9321-d80f8d442ba4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7023c71-325f-45af-b159-0437489f5f6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bdeca61-b213-4a07-9321-d80f8d442ba4");
        }
    }
}
