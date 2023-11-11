using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioIngaCode.Models
{
	public class TimeTrackers : Base
	{
		public TimeTrackers()
		{
		}

		public TimeTrackers(DateTime startDate, string timeZoneId, Guid collaboratorId) : base()
		{
			this.StartDate = startDate;
			this.TimeZoneId = timeZoneId;
			this.CollaboratorId = collaboratorId;

		}
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string TimeZoneId { get; set; }
		public Collaborators collaborator { get; set; }
		public Guid CollaboratorId { get; set; }
		public Tasks Task { get; set; }
		public Guid TaskId { get; set; }

	}
}