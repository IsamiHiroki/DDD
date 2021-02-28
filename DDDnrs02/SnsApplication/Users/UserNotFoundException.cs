using DDDnrs02.SnsDomain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDnrs02.SnsApplication.Users
{
	class UserNotFoundException : Exception
	{
		public UserNotFoundException(UserId id)
		{
			Id = id.Value;
		}

		public UserNotFoundException(UserId id, string message) : base(message)
		{
			Id = id.Value;
		}

		public string Id { get; }
	}
}
