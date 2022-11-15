using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class _createMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactUsItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsItems", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "D4D5ECAB-327F-48BD-9644-27C4EF9095D0",
                column: "ConcurrencyStamp",
                value: "b972188c-e61b-4bc9-a44b-6e79d168914b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25DC686E-5D5C-45E5-AF8C-64E10600055B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0b6a8d8c-e4de-45f5-9485-4e8c144c59c4", "AQAAAAEAACcQAAAAECdRLw1xfb5bYipGiKmkkQo86QbbDxzF86pnLLuat7YRlB8bAXmeZPAn6GQR6nn6Iw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("210edbb6-7bb7-4314-a13c-be92809fe020"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 11, 36, 4, 439, DateTimeKind.Utc).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("30a389fc-f1e4-4b5d-819a-70d1e50afe92"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 11, 36, 4, 438, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("728727b7-fd56-4d30-b8f8-9dc71e699f8a"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 11, 36, 4, 439, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b4a827b2-189e-4a1a-b033-936607096ba2"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 11, 36, 4, 439, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[] { new Guid("afbac4c6-864c-48ed-984d-f9b23f2b6869"), "ContactUs", new DateTime(2022, 11, 15, 11, 36, 4, 439, DateTimeKind.Utc).AddTicks(2527), null, null, null, null, "Content is filling by administrator", "Contact us", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUsItems");

            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("afbac4c6-864c-48ed-984d-f9b23f2b6869"));

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
    }
}
