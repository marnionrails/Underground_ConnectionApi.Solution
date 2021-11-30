using Microsoft.EntityFrameworkCore.Migrations;

namespace UndergroundConnectionsApi.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Classifications",
                columns: new[] { "ClassificationId", "ClassificationName", "ClassificationSpecification" },
                values: new object[] { 1, "Singer", "Country" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classifications",
                keyColumn: "ClassificationId",
                keyValue: 1);
        }
    }
}
