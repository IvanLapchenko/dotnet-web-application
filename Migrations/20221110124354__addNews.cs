using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class _addNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "D4D5ECAB-327F-48BD-9644-27C4EF9095D0",
                column: "ConcurrencyStamp",
                value: "9b06f611-d3af-4eec-8c6e-9c4a14bba017");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25DC686E-5D5C-45E5-AF8C-64E10600055B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fcda6a18-980c-4e02-ac92-11d2d571d13d", "AQAAAAEAACcQAAAAEHUDvXDJAKuvDUHBGRIM4r6NVqQaOhelmp83L/RuU95Wfq4PIOzPbLODaOY2TdT6xQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("210edbb6-7bb7-4314-a13c-be92809fe020"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 12, 43, 54, 36, DateTimeKind.Utc).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("30a389fc-f1e4-4b5d-819a-70d1e50afe92"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 12, 43, 54, 35, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("728727b7-fd56-4d30-b8f8-9dc71e699f8a"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 12, 43, 54, 36, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[] { new Guid("b4a827b2-189e-4a1a-b033-936607096ba2"), "PageNews", new DateTime(2022, 11, 10, 12, 43, 54, 36, DateTimeKind.Utc).AddTicks(774), null, null, null, null, "Content is filling by administrator", "Our News", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b4a827b2-189e-4a1a-b033-936607096ba2"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "D4D5ECAB-327F-48BD-9644-27C4EF9095D0",
                column: "ConcurrencyStamp",
                value: "a3cd0d9c-1aab-4635-bab6-82e8078057e6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25DC686E-5D5C-45E5-AF8C-64E10600055B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c90aace6-c501-4a72-9add-50b4a4ee9337", "AQAAAAEAACcQAAAAEHtq4iEyzE/jXG/U1/IN2I767zMCRt1z7O2gBLRYLv+/58TfTQM7CLX8YY372w9vyw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("210edbb6-7bb7-4314-a13c-be92809fe020"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 3, 22, 16, 39, 172, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("30a389fc-f1e4-4b5d-819a-70d1e50afe92"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 3, 22, 16, 39, 172, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("728727b7-fd56-4d30-b8f8-9dc71e699f8a"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 3, 22, 16, 39, 172, DateTimeKind.Utc).AddTicks(3376));
        }
    }
}
