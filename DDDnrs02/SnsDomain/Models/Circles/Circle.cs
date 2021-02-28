using DDDnrs02.SnsDomain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDnrs02.SnsDomain.Models.Circles
{
	class Circle
	{
		public Circle(CircleId id, CircleName name, User owner, List<User> members)
		{
			if (id == null) throw new ArgumentNullException(nameof(id));
			if (name == null) throw new ArgumentNullException(nameof(name));
			if (owner == null) throw new ArgumentNullException(nameof(owner));
			if (members == null) throw new ArgumentNullException(nameof(members));

			Id = id;
			Name = name;
			Owner = owner;
			this.members = members;
		}

		public CircleId Id { get; }
		public CircleName Name { get; private set; }
		public User Owner { get; private set; }
		private readonly List<User> members;

		public void AddMembers(User user)
		{
			if (members.Count >= 29)
			{
				throw new CircleFullException(Id);
			}

			members.Add(user);
		}
	}
}
