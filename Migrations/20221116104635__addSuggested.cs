using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class _addSuggested : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodeWord",
                table: "NewsItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "NewsItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "NewsItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "D4D5ECAB-327F-48BD-9644-27C4EF9095D0",
                column: "ConcurrencyStamp",
                value: "d6aea8ec-7589-4e0d-9750-671f24062189");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25DC686E-5D5C-45E5-AF8C-64E10600055B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea5a9f10-5327-4ecc-bc18-939005a5cc3a", "AQAAAAEAACcQAAAAEK+azbVsQZwBHqNxDuBLAeKlMZgF+2sn9t8ilk4hCE+gdOaVxANwRcq/ekQwynQhdw==" });

            migrationBuilder.InsertData(
                table: "NewsItems",
                columns: new[] { "Id", "CodeWord", "DateAdded", "Discriminator", "Email", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[] { new Guid("afbac4c6-864c-48ed-984d-f9b23f2b6669"), "Message", new DateTime(2022, 11, 16, 10, 46, 34, 191, DateTimeKind.Utc).AddTicks(3403), "Suggested", null, null, null, null, null, null, "Messages", null });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("210edbb6-7bb7-4314-a13c-be92809fe020"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 16, 10, 46, 34, 190, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("30a389fc-f1e4-4b5d-819a-70d1e50afe92"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 16, 10, 46, 34, 190, DateTimeKind.Utc).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("728727b7-fd56-4d30-b8f8-9dc71e699f8a"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 16, 10, 46, 34, 190, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b4a827b2-189e-4a1a-b033-936607096ba2"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 16, 10, 46, 34, 190, DateTimeKind.Utc).AddTicks(9949));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: new Guid("afbac4c6-864c-48ed-984d-f9b23f2b6669"));

            migrationBuilder.DropColumn(
                name: "CodeWord",
                table: "NewsItems");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "NewsItems");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "NewsItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "D4D5ECAB-327F-48BD-9644-27C4EF9095D0",
                column: "ConcurrencyStamp",
                value: "e86407cd-03d8-4e4c-982b-134244e684d1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25DC686E-5D5C-45E5-AF8C-64E10600055B",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c773ffcf-f063-4dbd-97e3-b568ace25ed8", "AQAAAAEAACcQAAAAEOQBlOooWQq+6owTStjee1kg5T27DqY9CXfqUDRS1xIxAGi8hbRavCCscpgerj1Naw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("210edbb6-7bb7-4314-a13c-be92809fe020"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 18, 43, 31, 377, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("30a389fc-f1e4-4b5d-819a-70d1e50afe92"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 18, 43, 31, 377, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("728727b7-fd56-4d30-b8f8-9dc71e699f8a"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 18, 43, 31, 377, DateTimeKind.Utc).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b4a827b2-189e-4a1a-b033-936607096ba2"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 18, 43, 31, 377, DateTimeKind.Utc).AddTicks(7772));
        }
    }
}
