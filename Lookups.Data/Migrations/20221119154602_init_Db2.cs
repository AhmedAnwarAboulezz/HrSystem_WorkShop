using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lookups.Data.Migrations
{
    public partial class init_Db2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NameFl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NameSl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SignInTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    SignOutTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    WorkingMinutes = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NameFl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NameSl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenderNameFl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GenderNameSl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsShown = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "CreatedDate", "IsDelete", "ModifiedDate", "NameFl", "NameSl" },
                values: new object[,]
                {
                    { new Guid("5c60f693-bef5-e011-a485-80ee7300c695"), null, new DateTime(2022, 11, 19, 17, 46, 2, 26, DateTimeKind.Local).AddTicks(5527), false, null, "Egypt", "مصر" },
                    { new Guid("5c60f693-bef5-e011-a485-80ee7300c696"), null, new DateTime(2022, 11, 19, 17, 46, 2, 28, DateTimeKind.Local).AddTicks(1458), false, null, "Kuwait", "الكويت" }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "CreatedDate", "GenderNameFl", "GenderNameSl", "IsDelete", "IsShown", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("1160f693-bef5-e011-a485-80ee7300c611"), new DateTime(2022, 11, 19, 17, 46, 2, 31, DateTimeKind.Local).AddTicks(492), "Male", "ذكر", false, true, null },
                    { new Guid("5160f693-bef5-e011-a485-80ee7300c612"), new DateTime(2022, 11, 19, 17, 46, 2, 32, DateTimeKind.Local).AddTicks(6536), "Female", "أنثي", false, true, null },
                    { new Guid("2260f693-bef5-e011-a485-80ee7300c693"), new DateTime(2022, 11, 19, 17, 46, 2, 32, DateTimeKind.Local).AddTicks(7338), "Both", "كلاهما", false, false, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ManagerId",
                table: "Employees",
                column: "ManagerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "EmployeeLogs");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Gender");
        }
    }
}
