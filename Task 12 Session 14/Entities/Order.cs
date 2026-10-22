using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12_Session_14.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
