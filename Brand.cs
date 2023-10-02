using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AddSomeShopWeb.Models
{
	public class Brand
	{
		[Key] 
		public int Id { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("Brand Name")]
		public string brandName { get; set; }

		[Required]
		[MaxLength(100)]
		[DisplayName("Description")]
		public string description { get; set; }
	}
}
