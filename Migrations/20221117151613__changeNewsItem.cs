using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class _changeNewsItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "NewsItems");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "NewsItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "NewsItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "D4D5ECAB-327F-48BD-9644-27C4EF9095D0",
                column: "ConcurrencyStamp",
                value: "0a2e37bc-e39e-486c-8cef-93fbecba2672");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25DC686E-5D5C-45E5-AF8C-64E10600055B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62a2fd0e-5d5e-4344-9186-05fe8dff9a28", "AQAAAAEAACcQAAAAENPFUfANMXfiIAtPrIyixtmuEur+h0G2FOtGuJSE1uiBS5dhV3JbGjzAkDOiED1ciA==" });

            migrationBuilder.UpdateData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: new Guid("b4a827b2-189e-4a1a-b033-936607096ba2"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 17, 15, 16, 12, 690, DateTimeKind.Utc).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("210edbb6-7bb7-4314-a13c-be92809fe020"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 17, 15, 16, 12, 690, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("30a389fc-f1e4-4b5d-819a-70d1e50afe92"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 17, 15, 16, 12, 690, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("728727b7-fd56-4d30-b8f8-9dc71e699f8a"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 17, 15, 16, 12, 690, DateTimeKind.Utc).AddTicks(8164));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: new Guid("b4a827b2-189e-4a1a-b033-936607096ba2"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "NewsItems");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "NewsItems");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "NewsItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "D4D5ECAB-327F-48BD-9644-27C4EF9095D0",
                column: "ConcurrencyStamp",
                value: "f50f07e0-d0e8-45fb-aa63-ab720230f8cb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25DC686E-5D5C-45E5-AF8C-64E10600055B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "07e8ccc3-cfbf-4408-86ca-7138782f15f6", "AQAAAAEAACcQAAAAEPo2JVf98rmQMElzh86VSd7uzFP5iIrwzlO1QUztlo5stQoTuD4hWmM7F+PqHAwf8w==" });

            migrationBuilder.InsertData(
                table: "NewsItems",
                columns: new[] { "Id", "CodeWord", "DateAdded", "Discriminator", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[] { new Guid("b4a827b2-189e-4a1a-b033-936607096ba2"), "PageNews", new DateTime(2022, 11, 17, 13, 46, 53, 245, DateTimeKind.Utc).AddTicks(1936), "NewsItem", null, null, null, null, null, "Our News", null });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("210edbb6-7bb7-4314-a13c-be92809fe020"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 17, 13, 46, 53, 245, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("30a389fc-f1e4-4b5d-819a-70d1e50afe92"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 17, 13, 46, 53, 244, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("728727b7-fd56-4d30-b8f8-9dc71e699f8a"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 17, 13, 46, 53, 245, DateTimeKind.Utc).AddTicks(1147));
        }
    }
}
