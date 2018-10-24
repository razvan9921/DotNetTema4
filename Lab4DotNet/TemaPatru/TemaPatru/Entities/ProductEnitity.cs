using System;
using System.ComponentModel.DataAnnotations;

namespace TemaPatru.Entities
{
    public class ProductEntity: BaseEntity
    {
        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public double Vat { get; set; }
    }
}
