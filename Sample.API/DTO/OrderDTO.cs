using System;
using System.Collections.Generic;

namespace Sample.API.DTO
{
    public partial class OrderDTO
    {
        
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerId { get; set; }

        public virtual CustomerDTO Customer { get; set; } = null!;
        public virtual List<OrderDetailDTO> OrderDetails { get; set; }
    }
}
