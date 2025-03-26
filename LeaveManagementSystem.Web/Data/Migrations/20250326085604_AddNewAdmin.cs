using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bdeca61-b213-4a07-9321-d80f8d442ba4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2af3bd28-fdd6-4d4c-8c24-23f170ad58bb", "AQAAAAIAAYagAAAAEC4wutt5r0nibVbELwF3IYxQJ44hVnfEcj/Q/P8cgFx9oOL0KnbV+JxA1qqsZTRFsw==", "5d9a2fb2-b6fb-4b5d-8eeb-e4d66790f87d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8f81b-851a-4c8d-80df-dbb02c481971",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bb96bd8-38b6-4255-a813-85359447685f", "AQAAAAIAAYagAAAAEHiMyPpWk1yn/L7UdNdQlsEfZlks4muX+vnKaTuRHTNl1qzVEtAMsyq2knVmdWk36g==", "58c3e68c-8ce6-4911-b0a6-bd3c6becd3b7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3d03a090-0365-4bd6-a372-0c0cca6b2ec5", 0, "1722fe1d-f460-43f2-9aee-b470b589be49", new DateOnly(2003, 1, 23), "acebojohnrohan@gmail.com", true, "John", "Acebo", false, null, "ACEBOJOHNROHAN@GMAIL.COM", "ACEBOJOHNROHAN@GMAIL.COM", "AQAAAAIAAYagAAAAEL4qqSTHy2FuzO0Z/JoMckHGlrc66ntxWLIjMUL4Au+C2t2an9223VrA2uhtQof+YA==", null, false, "fab85a99-5512-464b-bade-f116a8fc164a", false, "acebojohnrohan@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f7023c71-325f-45af-b159-0437489f5f6f", "3d03a090-0365-4bd6-a372-0c0cca6b2ec5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f7023c71-325f-45af-b159-0437489f5f6f", "3d03a090-0365-4bd6-a372-0c0cca6b2ec5" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d03a090-0365-4bd6-a372-0c0cca6b2ec5");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93ee4c2f-0f59-44a8-a6a9-a146a029dabd", "AQAAAAIAAYagAAAAENLneptxvkRnAeWitcQzr/Pa5vASjnQydWuZiiyisutnXXNKChW/u3ObaCpwSP48oQ==", "414bd45e-0c76-4c73-9a77-8b562a2eb2cb" });
        }
    }
}
