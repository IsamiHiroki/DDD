using DDDnrs02.SnsApplication.Circles.Create;
using DDDnrs02.SnsApplication.Circles.Join;
using DDDnrs02.SnsApplication.Users;
using DDDnrs02.SnsDomain.Models.Circles;
using DDDnrs02.SnsDomain.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DDDnrs02.SnsApplication.Circles
{
	class CircleApplicationService
	{
		private readonly ICircleFactory circleFactory;
		private readonly ICircleRepository circleRepository;
		private readonly CircleService circleService;
		private readonly IUserReposiotory userRepository;

		public CircleApplicationService(
			ICircleFactory circleFactory,
			ICircleRepository circleRepository,
			CircleService circleService,
			IUserReposiotory userRepository)
		{
			this.circleFactory = circleFactory;
			this.circleRepository = circleRepository;
			this.circleService = circleService;
			this.userRepository = userRepository;
		}

		public void Create(CircleCreateCommand command)
		{
			using(var transaction = new TransactionScope())
			{
				var ownerId = new UserId(command.UserId);
				var owner = userRepository.Find(ownerId);
				if(owner == null)
				{
					throw new UserNotFoundException(ownerId, "サークルのオーナーとなるユーザが見つかりませんでした。");
				}

				var name = new CircleName(command.Name);
				var circle = circleFactory.Create(name, owner);
				if(circleService.Exists(circle))
				{
					throw new CanNotRegisterCircleException(circle, "サークルはすでに存在しています。");
				}

				circleRepository.Save(circle);

				transaction.Complete();
			}
		}

		public void Join(CircleJoinCommand command)
		{
			using(var transaction = new TransactionScope())
			{
				var memberId = new UserId(command.UserId);
				var member = userRepository.Find(memberId);
				if(member == null)
				{
					throw new UserNotFoundException(memberId, "ユーザが見つかりませんでした。");
				}

				var id = new CircleId(command.CircleId);
				var circle = circleRepository.Find(id);
				if(circle == null)
				{
					throw new CircleNotFoundException(id, "サークルが見つかりませんでした。");
				}

				circle.AddMembers(member);
				circleRepository.Save(circle);

				transaction.Complete();
			}
		}
	}
}
