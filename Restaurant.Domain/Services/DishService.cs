using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Domain.Interfaces.Services;
using Restaurant.Domain.Interfaces.Repositories;

namespace Restaurant.Domain.Services
{
    public class DishService : ServiceBase<Dish>, IDishService
    {
        public DishService(IDishRepository repository) : base(repository)
        {

        }
    }
}
