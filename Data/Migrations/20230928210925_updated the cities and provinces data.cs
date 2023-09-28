using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommunityApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedthecitiesandprovincesdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Kelowna", 132000 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Tsawassen", 220000 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "New Westminster", 71000 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 5,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Red Deer", 103000 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 6,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Banff", 7800 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 7,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Brampton", 234320 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 8,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Ottawa", 500000 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 9,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Toronto", 800000 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Richmond", 250000 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Vancouver", 650000 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Burnaby", 250000 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 5,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Edmondton", 250000 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 6,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Bonnieville", 150000 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 7,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Mississauga", 450000 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 8,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Toronto", 1250000 });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 9,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Oakville", 238000 });
        }
    }
}
