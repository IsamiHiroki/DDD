using DDDnrs02.SnsDomain.Models.Circles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDnrs02.SnsApplication.Circles
{
	class CanNotRegisterCircleException : Exception
	{
		public CanNotRegisterCircleException(Circle circle, string message) : base(message)
		{
			Id = circle?.Id?.Value;
		}

		public string Id { get; }
	}
}
