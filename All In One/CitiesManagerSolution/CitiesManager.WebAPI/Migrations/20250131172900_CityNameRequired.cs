using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitiesManager.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class CityNameRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("1a672668-ef24-4a31-bd0f-2bcff92a3cca"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("270abbdd-3d39-442c-add2-6cb0523a109d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("3b66aa9d-c90b-4388-8304-0b53d84ec88b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("417942f9-0522-4d1f-b986-18a1d5a732d9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("4bd0883f-7bb9-4be6-b77a-888c730313fb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("612ce742-88aa-4947-9c0e-c1fd90f098d5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("803f07dc-a072-4c4d-ad0a-da9c2e397575"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("be8b8228-13a7-4dfc-b1d9-2edaf32a1b06"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("d3676f25-23b4-456c-b12a-0341ed4416b3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("e1d798ff-2dd7-4e30-a95e-57c5b85d2b09"));

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName" },
                values: new object[,]
                {
                    { new Guid("199af6c4-3945-4038-b642-60402632afe9"), "San Jose" },
                    { new Guid("23a91d2d-6d76-4f5d-afbd-22f6f6e524d0"), "Houston" },
                    { new Guid("4c3b926a-e4f2-4b8a-975e-450dc8c6a05a"), "New York" },
                    { new Guid("4f41ee7b-0b81-4892-8106-6dd848f87172"), "Philadelphia" },
                    { new Guid("7bce0658-134d-45d3-92c6-d5851ceb5f71"), "Dallas" },
                    { new Guid("93c49eb2-47dd-47bd-b873-ea4aa9f18506"), "San Diego" },
                    { new Guid("948ea9c6-5cc2-463e-a58e-b08387556fe9"), "San Antonio" },
                    { new Guid("a16b099c-6de8-4983-87ef-d23a3aade4dd"), "Chicago" },
                    { new Guid("bce7df34-6967-4ce3-bc7a-b93e46276851"), "Los Angeles" },
                    { new Guid("de0fe150-bd1f-4532-a8d1-f069470d5467"), "Phoenix" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("199af6c4-3945-4038-b642-60402632afe9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("23a91d2d-6d76-4f5d-afbd-22f6f6e524d0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("4c3b926a-e4f2-4b8a-975e-450dc8c6a05a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("4f41ee7b-0b81-4892-8106-6dd848f87172"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("7bce0658-134d-45d3-92c6-d5851ceb5f71"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("93c49eb2-47dd-47bd-b873-ea4aa9f18506"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("948ea9c6-5cc2-463e-a58e-b08387556fe9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("a16b099c-6de8-4983-87ef-d23a3aade4dd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("bce7df34-6967-4ce3-bc7a-b93e46276851"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: new Guid("de0fe150-bd1f-4532-a8d1-f069470d5467"));

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName" },
                values: new object[,]
                {
                    { new Guid("1a672668-ef24-4a31-bd0f-2bcff92a3cca"), "Dallas" },
                    { new Guid("270abbdd-3d39-442c-add2-6cb0523a109d"), "Houston" },
                    { new Guid("3b66aa9d-c90b-4388-8304-0b53d84ec88b"), "San Jose" },
                    { new Guid("417942f9-0522-4d1f-b986-18a1d5a732d9"), "Chicago" },
                    { new Guid("4bd0883f-7bb9-4be6-b77a-888c730313fb"), "Los Angeles" },
                    { new Guid("612ce742-88aa-4947-9c0e-c1fd90f098d5"), "Philadelphia" },
                    { new Guid("803f07dc-a072-4c4d-ad0a-da9c2e397575"), "San Diego" },
                    { new Guid("be8b8228-13a7-4dfc-b1d9-2edaf32a1b06"), "Phoenix" },
                    { new Guid("d3676f25-23b4-456c-b12a-0341ed4416b3"), "San Antonio" },
                    { new Guid("e1d798ff-2dd7-4e30-a95e-57c5b85d2b09"), "New York" }
                });
        }
    }
}
