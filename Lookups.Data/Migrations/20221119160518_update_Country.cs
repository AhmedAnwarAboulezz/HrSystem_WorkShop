using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lookups.Data.Migrations
{
    public partial class update_Country : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Countries");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Countries",
                type: "nvarchar(10)",
                maxLength: 10,
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

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-82ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 3, 15, 53, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-84ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 3, 15, 53, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-86ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 3, 15, 53, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c60f693-bef5-e011-a485-90ee7300c695"),
                column: "CreatedDate",
                value: new DateTime(2022, 11, 19, 18, 3, 15, 53, DateTimeKind.Local).AddTicks(9136));

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
        }
    }
}
