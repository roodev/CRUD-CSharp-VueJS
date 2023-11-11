using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioIngaCode.Models
{
	public class Users : Base
	{
		public Users()
		{
		}

		public Users(string userName, string password) : base()
		{
			this.UserName = userName;
			this.Password = password;
		}

		public string UserName { get; set; }
		public string Password { get; set; }
	}
}