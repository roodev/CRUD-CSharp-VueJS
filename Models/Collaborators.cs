using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioIngaCode.Models
{
	public class Collaborators : Base
	{
		public Collaborators()
		{
		}

		public Collaborators(string name)
		{
			this.Name = name;

		}

		public string Name { get; set; }
	}
}