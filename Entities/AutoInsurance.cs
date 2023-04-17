using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingApplication.Entities
{
    public class AutoInsurance
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string VinNo { get; set; }

        [MaxLength(50)]
        public string DriveName { get; set;}

        [MaxLength(50)]
        public string CarMake { get; set; }


        [Column(TypeName = "DateTime2")]
        public DateTime PurchaseDate { get; set; }

        public decimal Price { get; set; }
    }
}
