using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaveAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveAllocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PeriodId = table.Column<int>(type: "int", nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveAllocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveAllocations_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaveAllocations_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_EmployeeId",
                table: "LeaveAllocations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_PeriodId",
                table: "LeaveAllocations",
                column: "PeriodId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveAllocations");

            migrationBuilder.DropTable(
                name: "Periods");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bdeca61-b213-4a07-9321-d80f8d442ba4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2af3bd28-fdd6-4d4c-8c24-23f170ad58bb", "AQAAAAIAAYagAAAAEC4wutt5r0nibVbELwF3IYxQJ44hVnfEcj/Q/P8cgFx9oOL0KnbV+JxA1qqsZTRFsw==", "5d9a2fb2-b6fb-4b5d-8eeb-e4d66790f87d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d03a090-0365-4bd6-a372-0c0cca6b2ec5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1722fe1d-f460-43f2-9aee-b470b589be49", "AQAAAAIAAYagAAAAEL4qqSTHy2FuzO0Z/JoMckHGlrc66ntxWLIjMUL4Au+C2t2an9223VrA2uhtQof+YA==", "fab85a99-5512-464b-bade-f116a8fc164a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8f81b-851a-4c8d-80df-dbb02c481971",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bb96bd8-38b6-4255-a813-85359447685f", "AQAAAAIAAYagAAAAEHiMyPpWk1yn/L7UdNdQlsEfZlks4muX+vnKaTuRHTNl1qzVEtAMsyq2knVmdWk36g==", "58c3e68c-8ce6-4911-b0a6-bd3c6becd3b7" });
        }
    }
}
