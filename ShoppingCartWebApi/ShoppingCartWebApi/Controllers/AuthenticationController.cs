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
	[Route("api/Authentication")]
	
	public class AuthenticationController : ControllerBase
	{
		ICustomerService customerservice;
		public AuthenticationController(ICustomerService _customerservice)
		{
			customerservice = _customerservice;
		}
		[HttpPost]
		public IActionResult Login([FromBody]Authentication authentication)
		{
		
			Customer customer = customerservice.GetCustomerByNameAndPassword(authentication.username, authentication.password);

			if (customer == null)
			{
				return NotFound("Autentication failed");
			}
			return Ok(customer);

		}
	}
}