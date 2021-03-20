using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1_CristhianSoto.Models
{
    public class Product
    {
        [Key]
        [Range(1,99999)]
        public int ProductId { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Ingresar nombres entre 3 a 30 caracteres")]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime LastBuy { get; set; }
    }
}