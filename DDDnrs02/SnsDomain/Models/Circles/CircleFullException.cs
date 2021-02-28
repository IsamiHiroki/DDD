using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDnrs02.SnsDomain.Models.Circles
{
	class CircleFullException : Exception
	{
		public CircleFullException(CircleId id, string message = null) : base(message)
		{
			Id = id;
		}

		public CircleId Id { get; }
	}
}
