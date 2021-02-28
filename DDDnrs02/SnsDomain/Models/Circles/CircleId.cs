using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDnrs02.SnsDomain.Models.Circles
{
	class CircleId
	{
		public CircleId(string value)
		{
			if (value == null) throw new ArgumentNullException(nameof(value));

			Value = value;
		}

		public string Value { get; }
	}
}
