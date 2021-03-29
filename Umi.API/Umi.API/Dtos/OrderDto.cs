using System;
using System.Collections.Generic;
using Stateless;
using Umi.API.Models;

namespace Umi.API.Dtos
{
    public class OrderDto
    {
        
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public ICollection<LineItemDto> OrderItems { get; set; }
        public string State { get; set; }
        public DateTime CreateDateUTC { get; set; }
        // 3rd payment callback response, give to FE
        public string TransactionMetadata { get; set; }
        
    }
}