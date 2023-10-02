using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AddSomeShopWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

		[Required]
		[MaxLength(100)]
		[DisplayName("Description")]
		public string description { get; set; }

		[Required]
		[MaxLength(100)]
		[DisplayName("Sub-category Name")]
		public string subcategName { get; set; }

		[MaxLength(100)]
		[DisplayName("Sub-category Description")]
		public string subcategDescription { get; set; }

		[DisplayName("Display Order")]
        [Range(1,100, ErrorMessage = "Display Order must be between 1-100")]
		public int DisplayOrder { get; set; }
    }
}
