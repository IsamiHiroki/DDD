using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDnrs02.SnsDomain.Models.Users
{
	interface IUserReposiotory
	{
		User Find(UserId id);
		User Find(UserName name);
		List<User> FindAll();
		void Save(User user);
		void Delete(User user);
	}
}
