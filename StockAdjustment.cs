using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AddSomeShopWeb.Models
{
	public class StockAdjustment
	{
		[Key]
		public int Id { get; set; }

		//information
		[Required]
		[MaxLength(50)]
		[DisplayName("Inventory Location")]
		public string inventoryloc { get; set; }

		[Required]
		[MaxLength(50)]
		[DisplayName("Reason")]
		public string reason { get; set; }

		[Required]
		[MaxLength(150)]
		[DisplayName("Remarks")]
		public string remarks { get; set; }

		//product/s to adjust stock
		[Required]
		[MaxLength(80)]
		[DisplayName("Product Name")]
		public string prodname { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("Quantity to add/remove")]
		public int qtyaddorremove { get; set; }
	}
}
