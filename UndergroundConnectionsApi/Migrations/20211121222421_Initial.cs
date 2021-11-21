using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UndergroundConnectionsApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Bio = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Seeking = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PastWork = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Classifications",
                columns: table => new
                {
                    ClassificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClassificationName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ClassificationSpecification = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifications", x => x.ClassificationId);
                });

            migrationBuilder.CreateTable(
                name: "ArtistClassifications",
                columns: table => new
                {
                    ArtistClassificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    ClassificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistClassifications", x => x.ArtistClassificationId);
                    table.ForeignKey(
                        name: "FK_ArtistClassifications_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistClassifications_Classifications_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "Classifications",
                        principalColumn: "ClassificationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistClassifications_ArtistId",
                table: "ArtistClassifications",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistClassifications_ClassificationId",
                table: "ArtistClassifications",
                column: "ClassificationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistClassifications");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Classifications");
        }
    }
}
