using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Application.DTO
{
    public class DishDTO : DTOBase
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
