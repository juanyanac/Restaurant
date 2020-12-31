using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Domain.Entities
{
    public class Dish : EntityBase
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
