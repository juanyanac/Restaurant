using Restaurant.Application.DTO;
using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Application.Interfaces
{
    public interface IDishApp : IAppBase<Dish, DishDTO>
    {

    }
}
