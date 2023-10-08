using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Models
{
	public class WarehouseSetting
	{
		[Key]
		public int Id { get; set; }


		[Required]
		[MaxLength(30)]
		[DisplayName("Warehouse Name")]
		public string Name { get; set; }

		[Required]
		[MaxLength(11)]
		[DisplayName("Contact #")]
		public long ContactNum { get; set; }

		[Required]
		[MaxLength(8)]
		[DisplayName("Telephone #")]
		public long TelephoneNum { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("Unit/Apt./Floor # & Building Name")]
		public string buildingname { get; set; }

		[Required]
		[MaxLength(20)]
		[DisplayName("Street")]
		public string street { get; set; }

		[Required]
		[MaxLength(50)]
		[DisplayName("Barangay/Neighborhood")]
		public string brgyorneighborhood { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("City")]
		public string city { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("Province")]
		public string province { get; set; }

		[Required]
		[MaxLength(4)]
		[DisplayName("Zip Code")]
		public int zipcode { get; set; }
	}
}
