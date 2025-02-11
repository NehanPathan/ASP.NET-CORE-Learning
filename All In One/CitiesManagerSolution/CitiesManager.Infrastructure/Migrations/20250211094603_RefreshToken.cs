using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitiesManager.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class RefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("0350defa-4696-4d60-8931-41396cf66019"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("05e5666b-2969-4f6b-9489-260adacbf3c9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("1a7f7dc0-a133-4bf5-8af7-641749345506"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("1abee750-2aef-4055-b4a7-7d48e823600f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("31aadde2-f9db-418e-89fd-4881d3988755"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("ac0b7c5e-2cf2-47fa-b71b-e9a42ac00290"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("b7dda563-dee2-44b0-b391-5011629d2d38"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("c3f390f5-c7fb-4545-9e35-a71197ca8cf7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("ebe63897-8e5d-4297-bffb-31c9037a650a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("f453e187-ef29-4ef7-b9c0-30cbd8dbd9f3"));

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName" },
                values: new object[,]
                {
                    { new Guid("0350defa-4696-4d60-8931-41396cf66019"), "Phoenix" },
                    { new Guid("05e5666b-2969-4f6b-9489-260adacbf3c9"), "San Jose" },
                    { new Guid("1a7f7dc0-a133-4bf5-8af7-641749345506"), "Houston" },
                    { new Guid("1abee750-2aef-4055-b4a7-7d48e823600f"), "Dallas" },
                    { new Guid("31aadde2-f9db-418e-89fd-4881d3988755"), "San Antonio" },
                    { new Guid("ac0b7c5e-2cf2-47fa-b71b-e9a42ac00290"), "Philadelphia" },
                    { new Guid("b7dda563-dee2-44b0-b391-5011629d2d38"), "New York" },
                    { new Guid("c3f390f5-c7fb-4545-9e35-a71197ca8cf7"), "Chicago" },
                    { new Guid("ebe63897-8e5d-4297-bffb-31c9037a650a"), "Los Angeles" },
                    { new Guid("f453e187-ef29-4ef7-b9c0-30cbd8dbd9f3"), "San Diego" }
                });
        }
    }
}
