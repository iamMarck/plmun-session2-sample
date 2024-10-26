using System;
using System.Collections.Generic;

namespace Sample.API.DTO
{
    public partial class ProductDTO
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }

        public virtual List<OrderDetailDTO> OrderDetails { get; set; }
    }
}
