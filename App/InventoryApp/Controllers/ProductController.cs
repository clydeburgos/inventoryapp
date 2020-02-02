using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Model;
using Inventory.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryApp.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService productService;
        public ProductController(IProductService productService) {
            this.productService = productService;
        }

        [HttpGet]
        [Route("api/product/get/{id}")]
        public async Task<IActionResult> Get(int id) {
            var data = await productService.Get(id);
            return Ok(data);
        }

        [HttpGet]
        [Route("api/product/get")]
        public async Task<IActionResult> GetProducts()
        {
            var data = await productService.GetProducts();
            return Ok(data);
        }

        [HttpPost]
        [Route("api/product")]
        public async Task<IActionResult> Save([FromBody]ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var data = await productService.SaveProduct(model);
                return Ok(data);
            }
            else {
                return BadRequest(ModelState);
            }
            
        }
    }
}