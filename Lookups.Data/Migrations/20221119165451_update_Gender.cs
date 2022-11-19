using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lookups.Data.Migrations
{
    public partial class update_Gender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenderNameSl",
                table: "Gender",
                newName: "NameSl");

            migrationBuilder.RenameColumn(
                name: "GenderNameFl",
                table: "Gender",
                newName: "NameFl");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameSl",
                table: "Gender",
                newName: "GenderNameSl");

            migrationBuilder.RenameColumn(
                name: "NameFl",
                table: "Gender",
                newName: "GenderNameFl");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-80ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 5, 17, 317, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-80ee7300c696"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 5, 17, 319, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-82ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 5, 17, 319, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-84ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 5, 17, 319, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-86ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 5, 17, 319, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-90ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 5, 17, 319, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("1160f693-bef5-e011-a485-80ee7300c611"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 5, 17, 322, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("2260f693-bef5-e011-a485-80ee7300c693"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 5, 17, 325, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: new Guid("5160f693-bef5-e011-a485-80ee7300c612"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 5, 17, 325, DateTimeKind.Local).AddTicks(3260));
        }
    }
}
