using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class MakeRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bdeca61-b213-4a07-9321-d80f8d442ba4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30b19c6a-f967-4eb5-a797-b053bb6daf7d", "AQAAAAIAAYagAAAAED8x1ux+QL5tSh6DgLCGh12YZfYZaEN2/0d/4Bc51BMuHYKd5I5CHDmqukSxtH02ig==", "9ac6cdac-b8c7-4441-a1b9-2edad8c0562c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d03a090-0365-4bd6-a372-0c0cca6b2ec5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1279c13c-e48b-43c9-a906-4d4b0072120b", "AQAAAAIAAYagAAAAEJRXUEqv2dEuYMhn94MH0KjWVCqrWnGX1/Qi50DNELs3el9OYGZG62P8W13kx6gnew==", "43cb3335-d349-4646-bebc-2029d071ee15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8f81b-851a-4c8d-80df-dbb02c481971",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1c116ad-6d2c-47ea-888f-1b2cc0ae5e2a", "AQAAAAIAAYagAAAAED9FuC6VgqoQfb1oSNtYOuazMYT2KTIX13+TCnA38euwmge6bLD0BnYoGLE+XCxL5g==", "84cd4e52-7472-400a-925e-bf198846d4cc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bdeca61-b213-4a07-9321-d80f8d442ba4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35543c6f-c5ff-47f4-9307-b7ce61a930e6", "AQAAAAIAAYagAAAAEDNDctn4/NtmQBbQOxpD5GsjxOP73LRlCrp7CrF8xiOwTdmwkYRUWHd6zobRT07mfA==", "cb435a78-49a6-4474-9632-db35fc674105" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d03a090-0365-4bd6-a372-0c0cca6b2ec5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63f77a97-4307-423d-8d3f-48f7be965963", "AQAAAAIAAYagAAAAEAJQmE8zyQbjRx20+mHDcjQImoovTyIqB2N3k1Jrj4d94UB1RSfcQXXUq9n35WAL7g==", "fb8c8d57-7611-4bec-ac1c-4bc2289553c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8f81b-851a-4c8d-80df-dbb02c481971",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f5cdee7-566a-474d-9e0b-e861ee0e3687", "AQAAAAIAAYagAAAAEGLd9ElNLo5D6hsoinKSJOX03kSLOeqcz0sJdaHehzKsRW+KDmpxm7yQrERQm622mg==", "4330506b-b588-4778-92c6-ed6e27276382" });
        }
    }
}
