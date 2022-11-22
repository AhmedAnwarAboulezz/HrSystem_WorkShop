using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lookups.Data.Migrations
{
    public partial class init_EmployeeLog_Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-80ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 17, 10, 36, 892, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-80ee7300c696"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 17, 10, 36, 893, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-82ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 17, 10, 36, 893, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-84ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 17, 10, 36, 893, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-86ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 17, 10, 36, 893, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-90ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 17, 10, 36, 893, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("1160f693-bef5-e011-a485-80ee7300c611"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 17, 10, 36, 895, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("2260f693-bef5-e011-a485-80ee7300c693"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 17, 10, 36, 896, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("5160f693-bef5-e011-a485-80ee7300c612"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 22, 17, 10, 36, 896, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLogs_EmployeeId",
                table: "EmployeeLogs",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeLogs_Employees_EmployeeId",
                table: "EmployeeLogs",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeLogs_Employees_EmployeeId",
                table: "EmployeeLogs");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeLogs_EmployeeId",
                table: "EmployeeLogs");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-80ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 54, 50, 917, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-80ee7300c696"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 54, 50, 919, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-82ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 54, 50, 919, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-84ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 54, 50, 919, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-86ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 54, 50, 919, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-90ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 54, 50, 919, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("1160f693-bef5-e011-a485-80ee7300c611"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 54, 50, 922, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("2260f693-bef5-e011-a485-80ee7300c693"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 54, 50, 925, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("5160f693-bef5-e011-a485-80ee7300c612"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 54, 50, 924, DateTimeKind.Local).AddTicks(9354));
        }
    }
}
