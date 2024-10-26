using System;
using System.Collections.Generic;

namespace Sample.API.DTO
{
    public partial class OrderDetailDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public virtual OrderDTO Order { get; set; } = null!;
        public virtual ProductDTO Product { get; set; } = null!;
    }
}