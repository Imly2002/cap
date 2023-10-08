using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABC.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addWarehouseSettingToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ContactNum = table.Column<long>(type: "bigint", maxLength: 11, nullable: false),
                    TelephoneNum = table.Column<long>(type: "bigint", maxLength: 8, nullable: false),
                    buildingname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    street = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    brgyorneighborhood = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    city = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    province = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    zipcode = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "ContactNum", "Name", "TelephoneNum", "brgyorneighborhood", "buildingname", "city", "province", "street", "zipcode" },
                values: new object[] { 1, 12345678921L, "Pasig Warehouse", 12345678L, "Greenhills", "Unit V-303, 3/F V-Mall", "San Juan", "Metro Manila", "Ortigas Avenue", 1870 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Warehouses");
        }
    }
}
