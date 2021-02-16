using System;
using System.ComponentModel.DataAnnotations;
using Umi.API.ValidationAttributes;

namespace Umi.API.Dtos
{

    public class TouristRouteForUpdateDto : TouristRouteForManipulationDto
    {
        

        [Required(ErrorMessage = "necessary for Update")]
        [MaxLength(1500)]
        public override string Description { get; set; }
        
    }
}