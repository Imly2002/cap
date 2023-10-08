using ABC.Models;
using Microsoft.EntityFrameworkCore;

namespace ABC.DataAccess.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) 
            : base(options) 
        {
            
        }

        //Create Category Database
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
		public DbSet<storeSetting> Stores { get; set; }
		public DbSet<WarehouseSetting> Warehouses { get; set; }



		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Pushed Data into Category Database
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name="CCTV", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Printers", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Computer Accesories", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Cables & Tools", DisplayOrder = 4 }
                );

            //Pushed Data into Product Database
            modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Name = "V380 P2 HD 1080 IP Camera Wifi Wireless Output",
					Description = "128GB can record 16 days of video",
					SKU = "cctv-P2-Wireless-1080P",
					Supplier = "business corp",
					Brand = "Xiaomi",
					CostPrice = 1000,
					RetailPrice = 1700,
					StockQuantity = 20,
					MinimumStockQuantity = 3
				},
				new Product
				{
					Id = 2,
					Name = "SmartCam 360 Security Camera",
					Description = "Panoramic view with motion detection",
					SKU = "cctv-SmartCam-360",
					Supplier = "Tech Solutions Ltd.",
					Brand = "Samsung",
					CostPrice = 1200,
					RetailPrice = 1999,
					StockQuantity = 15,
					MinimumStockQuantity = 4
				},
				new Product
				{
					Id = 3,
					Name = "Nest Cam Outdoor 4K Security Camera",
					Description = "Weatherproof, 4K UHD video recording",
					SKU = "cctv-NestCam-Outdoor-4K",
					Supplier = "Smart Home Innovations",
					Brand = "Google Nest",
					CostPrice = 1500,
					RetailPrice = 2499,
					StockQuantity = 25,
					MinimumStockQuantity = 5
				},
				new Product
				{
					Id = 4,
					Name = "Hikvision DS-2CE56H0T-ITPF 5MP Dome Camera",
					Description = "High-resolution dome camera with night vision",
					SKU = "cctv-Hikvision-5MP-Dome",
					Supplier = "Security World",
					Brand = "Hikvision",
					CostPrice = 900,
					RetailPrice = 1499,
					StockQuantity = 18,
					MinimumStockQuantity = 2
				},
				new Product
				{
					Id = 5,
					Name = "Arlo Pro 4 Spotlight Camera",
					Description = "Wire-free, 2K HDR video with integrated spotlight",
					SKU = "cctv-Arlo-Pro-4",
					Supplier = "Home Security Plus",
					Brand = "Arlo",
					CostPrice = 1100,
					RetailPrice = 1799,
					StockQuantity = 22,
					MinimumStockQuantity = 4
				});

            //Pushed Data into Category Database
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { Id = 1, Name = "CCTV", ContactNumber = 15221446512 },
                new Supplier { Id = 2, Name = "Printers", ContactNumber = 15221446512 },
                new Supplier { Id = 3, Name = "Computer Accesories", ContactNumber = 15221446512 },
                new Supplier { Id = 4, Name = "Cables & Tools", ContactNumber = 15221446512 }
                );

			modelBuilder.Entity<storeSetting>().HasData(
				new storeSetting { 
					Id = 1, 
					Name = "Addsome Business Corporation", 
					ContactNum = 12345678921, 
					TelephoneNum = 12345678,  
					emailadd = "email@gmail.com",
					fburl = "https://fburl",
					buildingname = "Unit V-303, 3/F V-Mall",
					street = "Ortigas Avenue",
					brgyorneighborhood = "Greenhills",
					city = "San Juan",
					province = "Metro Manila",
					zipcode = 1870
				});

			modelBuilder.Entity<WarehouseSetting>().HasData(
				new WarehouseSetting
				{
					Id = 1,
					Name = "Pasig Warehouse",
					ContactNum = 12345678921,
					TelephoneNum = 12345678,
					buildingname = "Unit V-303, 3/F V-Mall",
					street = "Ortigas Avenue",
					brgyorneighborhood = "Greenhills",
					city = "San Juan",
					province = "Metro Manila",
					zipcode = 1870
				});
		}
	}
}
