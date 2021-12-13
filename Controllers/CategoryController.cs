using System;
using System.Collections.Generic;
using System.Linq;
using Business;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data.Models;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        CategoryBusiness categoryBusiness = new CategoryBusiness();
        [HttpGet("Get")]
        public IActionResult GetAll()
        {
            return Ok(categoryBusiness.GetAll());
        }

        [HttpGet("GetWith")]
        public IActionResult GetAllWithCondiction(string name)
        {
            return Ok(categoryBusiness.GetAll(name));
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok(categoryBusiness.Get(id));
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            return Ok(categoryBusiness.Add(category));
        }
        [HttpPut]
        public IActionResult Update(Category category)
        {
            return Ok(categoryBusiness.Update(category));
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(categoryBusiness.Delete(id));
        }
    }
}
