using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Otras_correcciones_de_facturacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WarehouseId",
                table: "BillDetail",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Entregado");

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Pagado");

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 4, "", "En mora" });

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_WarehouseId",
                table: "BillDetail",
                column: "WarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_Warehouse_WarehouseId",
                table: "BillDetail",
                column: "WarehouseId",
                principalTable: "Warehouse",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_Warehouse_WarehouseId",
                table: "BillDetail");

            migrationBuilder.DropIndex(
                name: "IX_BillDetail_WarehouseId",
                table: "BillDetail");

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "WarehouseId",
                table: "BillDetail");

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Pagado");

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "En mora");
        }
    }
}
