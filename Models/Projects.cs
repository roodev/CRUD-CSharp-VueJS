using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioIngaCode.Models
{
	public class Projects : Base
	{
		public Projects()
		{
		}

		public Projects(string name) : base()
		{
			this.Name = name;

		}
		public string Name { get; set; }

	}
}