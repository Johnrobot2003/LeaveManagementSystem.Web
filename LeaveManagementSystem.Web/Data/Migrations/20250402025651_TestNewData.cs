using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class TestNewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bdeca61-b213-4a07-9321-d80f8d442ba4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d444487f-b506-4c84-bd51-44b46d878ea2", "AQAAAAIAAYagAAAAENMxw8jR/OWdOf1o8wfpYqRu2Qn0+RllVojCwlGnILJ/DN2gWa0UpEzMonNCGa7nBA==", "c38d067a-a8ab-416c-9580-a32bfa909df8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d03a090-0365-4bd6-a372-0c0cca6b2ec5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a3c7de1-e25e-48ca-b1db-49e55198115c", "AQAAAAIAAYagAAAAEHm9RMXKtOoSQCQ9QZ+P469GcBmQG1am0qpi/NJ89IiB7dKApzMHcCqvBsy8jK3bLQ==", "2c0b9372-efb1-4d67-adfe-cfdfcb230d41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8f81b-851a-4c8d-80df-dbb02c481971",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91b86bd9-ba4f-49da-8f6e-71863e2458e8", "AQAAAAIAAYagAAAAEEFDJC1dQ9FBv5IdN2djV1w4spoaL5oETMlInLnQfX1ZWsvleJnY/jAmu/UtD03lLQ==", "475f8ecb-d937-486f-90ec-86b9e8fc7f63" });
        }
    }
}
