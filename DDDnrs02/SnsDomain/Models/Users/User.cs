using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDnrs02.SnsDomain.Models.Users
{
	class User
	{
		public User(UserId id, UserName name)
		{
			if (id == null) throw new ArgumentNullException(nameof(id));
			if (name == null) throw new ArgumentNullException(nameof(name));

			Id = id;
			Name = name;
		}

		public UserId Id { get; }
		public UserName Name { get; private set; }
	}
}
