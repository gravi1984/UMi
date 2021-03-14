using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace Umi.API.Dtos
{
    public class LoginDto
    {
        [Required]
        public string email { get; set; }
        
        [Required]
        public string password { get; set; }
        
    }
}