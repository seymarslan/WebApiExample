using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        
        ProductBusiness productBusiness = new ProductBusiness();
        [HttpGet("Get")]
        public IActionResult GetAll()
        {
            return Ok(productBusiness.GetAll());
        }

        [HttpGet("GetWith")]
        public IActionResult GetAllWithCondiction(string name)
        {
            return Ok(productBusiness.GetAll(name));
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok(productBusiness.Get(id));
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            return Ok(productBusiness.Add(product));
        }
        [HttpPut]
        public IActionResult Update(Product product)
        {
            return Ok(productBusiness.Update(product));
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(productBusiness.Delete(id));
        }
    }
}
