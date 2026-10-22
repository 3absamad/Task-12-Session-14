using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12_Session_14.Entities
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<Product> Products { get; set; }
    }
}
