using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12_Session_14.Entities
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
