using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitiesManager.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class RefreshTokenExpiration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("07eed0d4-bba2-441f-9a37-78387abbb339"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("2b4ba6a4-4d4f-4cba-accf-2452e9315cbe"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("3d91542a-58d8-4ac1-a0da-76a455eeeece"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("60fba1b4-9a32-4755-9d5e-b97b52925d76"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("63ec8363-f20d-4f3a-909b-8cf5e9fd7333"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("6fc2a3a3-47fb-41c9-b8c0-47d8422eec1a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("76e74207-9884-4547-bd1d-d47c13205f2c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("aa3ab511-f55f-444a-85d2-6bbba9d20f17"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("c54a0e2f-aef9-45a7-8abb-fdec00f3a241"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("d707805d-fcd1-4376-b3ff-301b1f124c94"));

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpirationDateTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName" },
                values: new object[,]
                {
                    { new Guid("11938cd2-a2ee-4ae4-be1a-82ce9363efc2"), "Chicago" },
                    { new Guid("2378c9e2-431d-45f7-928a-237a98634916"), "San Diego" },
                    { new Guid("504429e8-dc36-46f4-ab85-75f08302b55a"), "San Jose" },
                    { new Guid("6aac5c7e-311b-47ca-a21c-7a2f656af1f1"), "Philadelphia" },
                    { new Guid("6b6020f8-fb3f-44cf-bcc1-1e9d80058958"), "Houston" },
                    { new Guid("7fc6aa95-191f-462f-840f-13746d998340"), "Los Angeles" },
                    { new Guid("885a2951-fd4b-4299-816d-0dd2f5012593"), "Phoenix" },
                    { new Guid("a15374bc-cbd3-4a7f-bd93-3a083bebd877"), "San Antonio" },
                    { new Guid("bc0df87b-b1a0-41a5-af01-0ab3236991b0"), "Dallas" },
                    { new Guid("f02b22a5-a904-4c78-b6b3-db77ec1900d6"), "New York" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("11938cd2-a2ee-4ae4-be1a-82ce9363efc2"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("2378c9e2-431d-45f7-928a-237a98634916"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("504429e8-dc36-46f4-ab85-75f08302b55a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("6aac5c7e-311b-47ca-a21c-7a2f656af1f1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("6b6020f8-fb3f-44cf-bcc1-1e9d80058958"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("7fc6aa95-191f-462f-840f-13746d998340"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("885a2951-fd4b-4299-816d-0dd2f5012593"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("a15374bc-cbd3-4a7f-bd93-3a083bebd877"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("bc0df87b-b1a0-41a5-af01-0ab3236991b0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("f02b22a5-a904-4c78-b6b3-db77ec1900d6"));

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpirationDateTime",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName" },
                values: new object[,]
                {
                    { new Guid("07eed0d4-bba2-441f-9a37-78387abbb339"), "New York" },
                    { new Guid("2b4ba6a4-4d4f-4cba-accf-2452e9315cbe"), "Chicago" },
                    { new Guid("3d91542a-58d8-4ac1-a0da-76a455eeeece"), "Houston" },
                    { new Guid("60fba1b4-9a32-4755-9d5e-b97b52925d76"), "San Antonio" },
                    { new Guid("63ec8363-f20d-4f3a-909b-8cf5e9fd7333"), "Dallas" },
                    { new Guid("6fc2a3a3-47fb-41c9-b8c0-47d8422eec1a"), "Phoenix" },
                    { new Guid("76e74207-9884-4547-bd1d-d47c13205f2c"), "San Diego" },
                    { new Guid("aa3ab511-f55f-444a-85d2-6bbba9d20f17"), "Los Angeles" },
                    { new Guid("c54a0e2f-aef9-45a7-8abb-fdec00f3a241"), "San Jose" },
                    { new Guid("d707805d-fcd1-4376-b3ff-301b1f124c94"), "Philadelphia" }
                });
        }
    }
}
