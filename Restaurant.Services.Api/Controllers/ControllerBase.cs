using Microsoft.AspNetCore.Mvc;
using Restaurant.Application.DTO;
using Restaurant.Application.Interfaces;
using Restaurant.Domain.Entities;
using System;

namespace Restaurant.Services.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ControllerBase<Entity, EntityDTO> : Controller where Entity : EntityBase where EntityDTO : DTOBase
    {
        readonly protected IAppBase<Entity, EntityDTO> app;
        public ControllerBase(IAppBase<Entity, EntityDTO> app)
        {
            this.app = app;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Listar()
        {
            try
            {
                var restaurants = app.SelectAll();
                return new OkObjectResult(restaurants);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult SelectById(int id)
        {
            try
            {
                var restaurants = app.SelectById(id);
                return new OkObjectResult(restaurants);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Add([FromBody] EntityDTO data)
        {
            try
            {
                return new OkObjectResult(app.Add(data));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IActionResult Update([FromBody] EntityDTO data)
        {
            try
            {
                app.Update(data);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                app.Remove(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }            
        }
    }
}
