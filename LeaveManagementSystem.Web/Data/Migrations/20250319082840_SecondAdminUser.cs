using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SecondAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1b058f6f-5769-4c60-b7b6-8773554c71e2", "JOHNROHAN", "AQAAAAIAAYagAAAAEEmqLpYod5OUL13rZ9gNNyUT6fzIrivrXD3f33XRoDZCufKDTMFeMrEWT4PLOihxfQ==", "8bb8402b-a989-4907-837d-16b8f1607372", "JohnRohan" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bdeca61-b213-4a07-9321-d80f8d442ba4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e2f87da-dff7-44de-b93b-cbbe99b80392", "AQAAAAIAAYagAAAAEEoiwnvrykFiFYgBYlpjZS3wsOcf7ca6BDsHUx0z7KDJCUF1Kyi/dHpiN/AI4BzmKA==", "75ef8ee7-1f16-467f-bbdd-a3a50b9f9633" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8f81b-851a-4c8d-80df-dbb02c481971",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7803f0dd-6774-4b00-9538-ed94aeb4fe12", "JOHN ROHAN", "AQAAAAIAAYagAAAAEI7VCLZzWYyTHY2518ESVn4eTSIrPcVn8180MxceD9j0MclFolJfbfun3rbeabB5UQ==", "d5d1de2e-0911-4afe-9f5b-24940a62b3f7", "John Rohan" });
        }
    }
}
