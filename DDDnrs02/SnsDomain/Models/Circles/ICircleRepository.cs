using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDnrs02.SnsDomain.Models.Circles
{
	interface ICircleRepository
	{
		void Save(Circle circle);
		Circle Find(CircleId id);
		Circle Find(CircleName name);
	}
}
