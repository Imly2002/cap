using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace AddSomeShopWeb.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }

		//Product Information
		[MaxLength(30)]
		[DisplayName("Barcode")]
		public string barcode { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("SKU")]
		public string SKU { get; set; }

		[Required]
		[MaxLength(50)]
		[DisplayName("Product Name")]
		public string Name { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("Category")]
		public string Category { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("Sub-category")]
		public string subCateg { get; set; }

		[Required]
		[MaxLength(50)]
		[DisplayName("Supplier")]
		public string Supplier { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("Brand")]
		public string Brand { get; set; }

		[Required]
		[MaxLength(50)]
		[DisplayName("Warehouse")]
		public string Warehouse { get; set; }

		[Required]
		[MaxLength(100)]
		[DisplayName("Description")]
		public string Description { get; set; }

		//Pricing
		[Required]
		[MaxLength(30)]
		[DisplayName("Cost Price")]
		public float costprice { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("Retail Price")]
		public float retailprice { get; set; }

		//Inventory
		[Required]
		[MaxLength(30)]
		[DisplayName("Stock Quantity")]
		public int stckqty { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("Min. Stock Quantity")]
		public int minstckqty { get; set; }

		//warranty type
		[Required]
		[MaxLength(30)]
		[DisplayName("Warranty Type")]
		public string warrantyType { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("Warranty Duration")]
		public string warrantyDuration { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("Warranty Provider")]
		public string warrantyProvider { get; set; }

		//Availability
		[Required]
		[MaxLength(50)]
		[DisplayName("Available to store")]
		public string availableStore { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("Enlist on the website?")]
		public Boolean enlistprod { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("Allow delivery?")]
		public Boolean allowdelivery { get; set; }

		//Specification
		[Required]
		[MaxLength(100)]
		[DisplayName("Product Specifications")]
		public string Specifications { get; set; }

		//Notes
		[MaxLength(150)]
		[DisplayName("Additional Notes")]
		public string addnote { get; set; }

	}
}
