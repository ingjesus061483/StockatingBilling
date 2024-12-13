using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UnitMeasurement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitMeasurementId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UnitMeasurement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitMeasurement", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitMeasurementId",
                table: "Products",
                column: "UnitMeasurementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_UnitMeasurement_UnitMeasurementId",
                table: "Products",
                column: "UnitMeasurementId",
                principalTable: "UnitMeasurement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_UnitMeasurement_UnitMeasurementId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "UnitMeasurement");

            migrationBuilder.DropIndex(
                name: "IX_Products_UnitMeasurementId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UnitMeasurementId",
                table: "Products");
        }
    }
}
