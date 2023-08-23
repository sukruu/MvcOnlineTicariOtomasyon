using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Sehir
    {
        [Key]
        public int Sehirid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string SehirAd { get; set; }
    }
}