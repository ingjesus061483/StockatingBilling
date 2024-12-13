using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "IdentificationTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "", "cedula de ciudadania" },
                    { 2, "", "nit" }
                });

            migrationBuilder.InsertData(
                table: "RegimenTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "", "Simplificado" },
                    { 2, "", "Comun" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "", "Administrador" });

            migrationBuilder.InsertData(
                table: "UnitMeasurement",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "", "Gramo" },
                    { 2, "", "Litro" },
                    { 3, "", "Unidad" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Contact", "Direction", "Email", "Name", "Nit", "Phone", "RegimenTypeId", "TradeCamera", "slogan" },
                values: new object[] { 1, "pepito perez", "b / quilla", "alguien@ejempo.com", "Empresa de prueba", "11111 - 1", "5444555", 1, "0001", "" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Companyid", "Email", "Name", "Password", "RoleId" },
                values: new object[] { 1, 1, "example1@mail.com", "admin", "admin1234.", 1 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "Identification", "IdentificationTypeId", "LastName", "Name", "Phone", "UserId" },
                values: new object[] { 1, "B/quilla", "11111", 1, "admin", "admin", "55555", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IdentificationTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RegimenTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UnitMeasurement",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UnitMeasurement",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UnitMeasurement",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IdentificationTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RegimenTypes",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
