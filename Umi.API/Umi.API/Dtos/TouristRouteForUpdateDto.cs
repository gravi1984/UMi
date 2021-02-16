using System;
using System.ComponentModel.DataAnnotations;

namespace Umi.API.Dtos
{
    public class TouristRouteForUpdateDto
    {
        [Required(ErrorMessage = "title cannot be empty")]
        [MaxLength(100)]
        public string Title { get; set; }
        
        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }
  
        // Data transfer: hide/transfer data to FE
        // public decimal OriginalPrice { get; set; }
        // public double? DiscountPresent { get; set; }
        public decimal Price { get; set; }
        
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DepartureTime { get; set; }

        public string Features { get; set; }
        public string Fees { get; set; }
        public string Notes { get; set; }
        
        // enrich Model
        public double? Rating { get; set; }
        public string TravelDays { get; set; }
        public string TripType { get; set; }
        public string DepartureCity { get; set; }
    }
}