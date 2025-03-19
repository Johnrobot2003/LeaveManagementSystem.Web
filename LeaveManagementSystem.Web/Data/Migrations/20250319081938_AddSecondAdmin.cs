using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSecondAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bdeca61-b213-4a07-9321-d80f8d442ba4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e2f87da-dff7-44de-b93b-cbbe99b80392", "AQAAAAIAAYagAAAAEEoiwnvrykFiFYgBYlpjZS3wsOcf7ca6BDsHUx0z7KDJCUF1Kyi/dHpiN/AI4BzmKA==", "75ef8ee7-1f16-467f-bbdd-a3a50b9f9633" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e6a8f81b-851a-4c8d-80df-dbb02c481971", 0, "7803f0dd-6774-4b00-9538-ed94aeb4fe12", new DateOnly(2003, 1, 23), "secondadmin@user.com", true, "Default", "Admin2", false, null, "SECONDADMIN@USER.COM", "JOHN ROHAN", "AQAAAAIAAYagAAAAEI7VCLZzWYyTHY2518ESVn4eTSIrPcVn8180MxceD9j0MclFolJfbfun3rbeabB5UQ==", null, false, "d5d1de2e-0911-4afe-9f5b-24940a62b3f7", false, "John Rohan" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f7023c71-325f-45af-b159-0437489f5f6f", "e6a8f81b-851a-4c8d-80df-dbb02c481971" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f7023c71-325f-45af-b159-0437489f5f6f", "e6a8f81b-851a-4c8d-80df-dbb02c481971" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8f81b-851a-4c8d-80df-dbb02c481971");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bdeca61-b213-4a07-9321-d80f8d442ba4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb81172d-6652-480c-aa50-53ca94c142bc", "AQAAAAIAAYagAAAAEJnIbnONkR8AKfDQRy+fJOkAnVMChpkRS27Ai+YzRgIb3bPKIW6DfbmSu8qM0FdDbw==", "cee9a3ed-fd78-4929-8252-b0d0999f5c4c" });
        }
    }
}
