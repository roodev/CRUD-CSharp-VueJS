using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioIngaCode.Models
{
	public class Tasks : Base
	{
		public Tasks()
		{
		}

		public Tasks(string name, Projects project) : base()
		{
			this.Name = name;
			this.Project = project;

		}
		public string Name { get; set; }
		public string Description { get; set; }
		public Projects Project { get; set; }
		public Guid ProjectId { get; set; }


	}
}