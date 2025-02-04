using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitiesManager.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
