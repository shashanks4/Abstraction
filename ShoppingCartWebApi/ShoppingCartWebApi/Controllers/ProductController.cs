using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartWebApi.Models;
using ShoppingCartWebApi.Services;

namespace ShoppingCartWebApi.Controllers
{
	[ApiController]
	[Route("api/product")]
	public class ProductController : ControllerBase
	{
		IProductService productData;
		public ProductController(IProductService _productData)
		{
			productData = _productData;
		}
		[HttpGet]
		public IActionResult Gets()
		{
			var list = productData.GetList();
			if (list.Count == 0)
			{
				return NotFound("no items");
			}
			else
			{
				return Ok(list);
			}
		}
		[HttpGet("{name}", Name = "GetProduct")]
		public IActionResult Get(string name)
		{
			var product = productData.GetProductByName(name);
			if (product == null)
			{
				return NotFound("No customer found with the given name");
			}
			return Ok(product);
		}
		[HttpPost]
		public IActionResult AddProducts([FromBody] Product product)
		{
			if (product == null)
			{
				return BadRequest();
			}
			productData.AddItem(product);
			return Ok();
		}

	}
}
