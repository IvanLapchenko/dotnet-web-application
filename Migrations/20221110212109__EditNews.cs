using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class _EditNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewsItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsItems", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "D4D5ECAB-327F-48BD-9644-27C4EF9095D0",
                column: "ConcurrencyStamp",
                value: "8dacdb9f-444e-4709-826d-02e15766e806");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25DC686E-5D5C-45E5-AF8C-64E10600055B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "308a2ef9-70c0-416d-b2ac-70bb6bc757f8", "AQAAAAEAACcQAAAAEFQ45U8doXGGDqOlKY7evVUdCJf3RC1TXkqzRz4ceajSBqEEjjRYOhOYlGLNRwYD/Q==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("210edbb6-7bb7-4314-a13c-be92809fe020"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 21, 21, 8, 526, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("30a389fc-f1e4-4b5d-819a-70d1e50afe92"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 21, 21, 8, 526, DateTimeKind.Utc).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("728727b7-fd56-4d30-b8f8-9dc71e699f8a"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 21, 21, 8, 526, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b4a827b2-189e-4a1a-b033-936607096ba2"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 21, 21, 8, 526, DateTimeKind.Utc).AddTicks(5002));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsItems");

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

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b4a827b2-189e-4a1a-b033-936607096ba2"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 12, 43, 54, 36, DateTimeKind.Utc).AddTicks(774));
        }
    }
}
