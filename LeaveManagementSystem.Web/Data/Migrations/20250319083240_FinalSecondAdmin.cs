using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class FinalSecondAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bdeca61-b213-4a07-9321-d80f8d442ba4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a66a5b0-ba2f-49d3-9279-d58946898fe6", "AQAAAAIAAYagAAAAEJS17TnpLeclskHQb54Rkm84av1KqkD0xv4U5EG1n6mpAWiPUBE5AKOVMdiKBSLn2A==", "9824c849-3cf5-4f78-a109-2d24a45b1119" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8f81b-851a-4c8d-80df-dbb02c481971",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "93ee4c2f-0f59-44a8-a6a9-a146a029dabd", "John", "Admin3", "SECONDADMIN@USER.COM", "AQAAAAIAAYagAAAAENLneptxvkRnAeWitcQzr/Pa5vASjnQydWuZiiyisutnXXNKChW/u3ObaCpwSP48oQ==", "414bd45e-0c76-4c73-9a77-8b562a2eb2cb", "secondadmin@user.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bdeca61-b213-4a07-9321-d80f8d442ba4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf4e472a-ba72-467b-8bad-9354406687fb", "AQAAAAIAAYagAAAAEJ4Ckvpn9hKlQTcFb7q7IMsq45q1nTpMzEsh11qKxW73aDuZ/DDCDUcXXKYHXGkpjA==", "a5fb9b71-97d5-474a-853c-6f83c65cee36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8f81b-851a-4c8d-80df-dbb02c481971",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1b058f6f-5769-4c60-b7b6-8773554c71e2", "Default", "Admin2", "JOHNROHAN", "AQAAAAIAAYagAAAAEEmqLpYod5OUL13rZ9gNNyUT6fzIrivrXD3f33XRoDZCufKDTMFeMrEWT4PLOihxfQ==", "8bb8402b-a989-4907-837d-16b8f1607372", "JohnRohan" });
        }
    }
}
