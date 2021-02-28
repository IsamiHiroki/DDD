using DDDnrs02.SnsDomain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDnrs02.SnsDomain.Models.Circles
{
	interface ICircleFactory
	{
		Circle Create(CircleName name, User owner);
	}
}
