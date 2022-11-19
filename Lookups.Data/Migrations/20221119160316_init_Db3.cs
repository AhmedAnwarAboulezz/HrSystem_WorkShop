using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lookups.Data.Migrations
{
    public partial class init_Db3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GenderId",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-80ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 3, 15, 52, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-80ee7300c696"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 3, 15, 53, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "CreatedDate", "IsDelete", "ModifiedDate", "NameFl", "NameSl" },
                values: new object[,]
                {
                    { new Guid("5c60f693-bef5-e011-a485-90ee7300c695"), null, new DateTime(2022, 11, 19, 18, 3, 15, 53, DateTimeKind.Local).AddTicks(9136), false, null, "Ksa", "السعودية" },
                    { new Guid("5c60f693-bef5-e011-a485-82ee7300c695"), null, new DateTime(2022, 11, 19, 18, 3, 15, 53, DateTimeKind.Local).AddTicks(9145), false, null, "UAE", "الأمارات" },
                    { new Guid("5c60f693-bef5-e011-a485-84ee7300c695"), null, new DateTime(2022, 11, 19, 18, 3, 15, 53, DateTimeKind.Local).AddTicks(9151), false, null, "Yamen", "اليمن" },
                    { new Guid("5c60f693-bef5-e011-a485-86ee7300c695"), null, new DateTime(2022, 11, 19, 18, 3, 15, 53, DateTimeKind.Local).AddTicks(9168), false, null, "Jordon", "الأردن" }
                });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("1160f693-bef5-e011-a485-80ee7300c611"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 3, 15, 57, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("2260f693-bef5-e011-a485-80ee7300c693"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 3, 15, 61, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("5160f693-bef5-e011-a485-80ee7300c612"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 3, 15, 61, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CountryId",
                table: "Employees",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_GenderId",
                table: "Employees",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Countries_CountryId",
                table: "Employees",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Gender_GenderId",
                table: "Employees",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Countries_CountryId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Gender_GenderId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CountryId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_GenderId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-82ee7300c695"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-84ee7300c695"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-86ee7300c695"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-90ee7300c695"));

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-80ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 17, 46, 2, 26, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-80ee7300c696"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 17, 46, 2, 28, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("1160f693-bef5-e011-a485-80ee7300c611"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 17, 46, 2, 31, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("2260f693-bef5-e011-a485-80ee7300c693"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 17, 46, 2, 32, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("5160f693-bef5-e011-a485-80ee7300c612"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 17, 46, 2, 32, DateTimeKind.Local).AddTicks(6536));
        }
    }
}
