 using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ABC.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Supplier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostPrice = table.Column<float>(type: "real", nullable: false),
                    RetailPrice = table.Column<float>(type: "real", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    MinimumStockQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CostPrice", "Description", "MinimumStockQuantity", "Name", "RetailPrice", "SKU", "StockQuantity", "Supplier" },
                values: new object[,]
                {
                    { 1, "Xiaomi", 1000f, "128GB can record 16 days of video", 3, "V380 P2 HD 1080 IP Camera Wifi Wireless Output", 1700f, "cctv-P2-Wireless-1080P", 20, "business corp" },
                    { 2, "Samsung", 1200f, "Panoramic view with motion detection", 4, "SmartCam 360 Security Camera", 1999f, "cctv-SmartCam-360", 15, "Tech Solutions Ltd." },
                    { 3, "Google Nest", 1500f, "Weatherproof, 4K UHD video recording", 5, "Nest Cam Outdoor 4K Security Camera", 2499f, "cctv-NestCam-Outdoor-4K", 25, "Smart Home Innovations" },
                    { 4, "Hikvision", 900f, "High-resolution dome camera with night vision", 2, "Hikvision DS-2CE56H0T-ITPF 5MP Dome Camera", 1499f, "cctv-Hikvision-5MP-Dome", 18, "Security World" },
                    { 5, "Arlo", 1100f, "Wire-free, 2K HDR video with integrated spotlight", 4, "Arlo Pro 4 Spotlight Camera", 1799f, "cctv-Arlo-Pro-4", 22, "Home Security Plus" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
