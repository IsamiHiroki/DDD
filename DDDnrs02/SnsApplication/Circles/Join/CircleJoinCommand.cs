using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDnrs02.SnsApplication.Circles.Join
{
	class CircleJoinCommand
	{
		public CircleJoinCommand(string userId, string circleId)
		{
			this.UserId = userId;
			this.CircleId = circleId;
		}

		public string UserId { get; }
		public string CircleId { get; }
	}
}
