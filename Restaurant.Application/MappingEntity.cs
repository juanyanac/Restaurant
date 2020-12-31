using AutoMapper;
using Restaurant.Application.DTO;
using Restaurant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Application
{
    public class MappingEntity : Profile
    {
        public MappingEntity()
        {
           CreateMap<Dish, DishDTO>();
           CreateMap<DishDTO, Dish>();
        }
    }
}
