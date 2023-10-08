using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }


		[Required]
		public string Name { get; set; }
		public string Description { get; set; }


		[Required]
		public string SKU { get; set; }
		public string Supplier { get; set; }
		public string Brand { get; set; }

		[Required]
		[DisplayName("Cost Price")]
		public float CostPrice { get; set; }

		[Required]
		[DisplayName("Retail Price")]
		public float RetailPrice { get; set; }

		[Required]
		[DisplayName("Stock Quantity")]
		public int StockQuantity { get; set; } = 0;


		[DisplayName("Min. Stock Quantity")]
		public int MinimumStockQuantity { get; set; }

	}
}

