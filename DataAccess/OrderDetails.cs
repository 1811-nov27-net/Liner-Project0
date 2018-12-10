using System;
using System.Collections.Generic;

namespace DataAccess
{
    public partial class OrderDetails
    {
        public int OrderId { get; set; }
        public int LocationId { get; set; }
        public int UserId { get; set; }
    }
}
