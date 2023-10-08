using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ABC.Models
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }


        [DisplayName("Contact Number")]
        public long ContactNumber { get; set; }
    }
}
