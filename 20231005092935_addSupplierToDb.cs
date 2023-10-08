using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ABC.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addSupplierToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ContactNumber = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "ContactNumber", "Name" },
                values: new object[,]
                {
                    { 1, 15221446512L, "CCTV" },
                    { 2, 15221446512L, "Printers" },
                    { 3, 15221446512L, "Computer Accesories" },
                    { 4, 15221446512L, "Cables & Tools" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
