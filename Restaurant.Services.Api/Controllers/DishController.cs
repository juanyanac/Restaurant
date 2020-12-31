using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Application.DTO;
using Restaurant.Application.Interfaces;
using Restaurant.Domain.Entities;

namespace Restaurant.Services.Api.Controllers
{
    public class DishController : ControllerBase<Dish, DishDTO>
    {
        public DishController(IDishApp app) : base(app)
        {

        }
    }
}
