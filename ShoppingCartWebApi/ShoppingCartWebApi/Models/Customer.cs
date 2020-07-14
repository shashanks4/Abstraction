using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartWebApi.Models
{
	public class Customer
	{
		
			public string CustomerName { get; set; }
			public string Email { get; set; }
			public string Phonenumber { get; set; }
			public string Password { get; set; }
		private Guid customerUniqueId = Guid.NewGuid();
		public Guid CustomerUniqueId { get => customerUniqueId; }


	}
}
