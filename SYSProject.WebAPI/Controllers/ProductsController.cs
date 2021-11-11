using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SYSProject.Business.Abstract;
using SYSProject.Business.Constants;
using SYSProject.Core.Utilities.Results;
using SYSProject.Entities.Concrete;
using SYSProject.Entities.Dtos;
using SYSProject.WebAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SYSProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpPost("CreateProduct")]
        [Authorize()]
        public IActionResult Add([FromBody]ProductDto product)
        {
            var userId = this.User.Identity.GetUserId(); 
            var result = _productService.Add(product, userId);
            if (result)
            {
                return Ok(new SuccessResult(Messages.ProductAdded));
            }

            return BadRequest();
        }

        [HttpGet("GetAllProducts")]
        [Authorize()]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (result.Any())
            {
                return Ok(new SuccessDataResult<List<Product>>(result, Messages.ProductListed));
            }
            return NotFound();
        }

        [HttpGet("GetProduct")]
        [Authorize()]
        public IActionResult Get([FromQuery] long id)
        {
            var result = _productService.Get(id);
            if (result!=null)
            {
                return Ok(new SuccessDataResult<Product>(result, Messages.ProductFound));
            }
            return NotFound();
        }

        [HttpPut("UpdateProduct")]
        [Authorize()]
        public IActionResult Update([FromQuery] long id,[FromBody] ProductDto product)
        {
            var userId = this.User.Identity.GetUserId();
            var result = _productService.Update(id,product, userId);
            if (result)
            {
                return Ok(new SuccessResult(Messages.ProductUpdated));
            }

            return BadRequest();

        }

        [HttpPost("DeleteProduct")]
        [Authorize()]
        public IActionResult Delete([FromQuery] int id)
        {
            var userId = this.User.Identity.GetUserId();
            var result = _productService.Delete(id, userId);
            if (result)
            {
                return Ok(new SuccessResult(Messages.ProductDeleted));
            }

            return BadRequest();

        }
    }
}
