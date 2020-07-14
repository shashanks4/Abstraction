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
	[Route("api/customer")]
	public class CustomerController : ControllerBase
	{
		ICustomerService customers;
		public CustomerController(ICustomerService customerData)
		{
			customers = customerData;
		}

		[HttpGet]
		public IActionResult Gets()
		{
			if (customers.GetList() == null)
			{
				return BadRequest();
			}
			return Ok(this.customers.GetList());

		}
		[HttpGet("{name}", Name = "GetCustomer")]
		public IActionResult Get(string name)
		{
			var customer = customers.GetCustomerByName(name);
			if (customer == null)
			{
				return NotFound("No customer found with the given name");
			}
			return Ok(customer);
		}
		[HttpPost]
		public IActionResult Register([FromBody] Customer customerobject)
		{
			var list = customers.GetList();
			if (customerobject == null)
			{
				return BadRequest();
			}
			customers.AddCustomer(customerobject);
			return Ok();
		}
		[HttpDelete]
		public IActionResult Delete(string name)
		{
			var status = customers.DeleteCustomer(name);
			if (status)
			{
				return Ok();
			}
			else
			{
				return NotFound("Sorry no such customer found");
			}
		}
	}
}