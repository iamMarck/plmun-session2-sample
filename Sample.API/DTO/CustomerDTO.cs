using System;
using System.Collections.Generic;

namespace Sample.API.DTO
{
    public partial class CustomerDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public virtual List<OrderDTO> Orders { get; set; }
    }
}
