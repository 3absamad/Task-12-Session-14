using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Task_12_Session_14.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category {  get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
