using DDDnrs02.SnsDomain.Models.Circles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDnrs02.SnsApplication.Circles
{
	class CircleNotFoundException : Exception
	{
		public CircleNotFoundException(CircleId id)
		{
			Id = id.Value;
		}

		public CircleNotFoundException(CircleId id, string message) : base(message)
		{
			Id = id.Value;
		}

		public string Id { get; }
	}
}
