using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace TrainingApplication.Entities
{
    public class HomeInsurance : BaseEntity
    {
        [MaxLength(50)]
        public string HomeType { get; set; }

        [MaxLength(5)]
        public string NumberOfStories { get; set; }

        public int NumberOfGarage { get; set; }

        public int HouseAge { get; set; }

        public decimal Price { get; set; }
    }
}
