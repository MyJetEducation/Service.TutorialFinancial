using System;
using System.Threading.Tasks;
using Service.TutorialFinancial.Grpc;
using Service.TutorialFinancial.Grpc.Models;
using Service.TutorialFinancial.Grpc.Models.State;
using Service.TutorialFinancial.Mappers;
using Service.TutorialFinancial.Models;
using Service.UserReward.Grpc;
using Service.UserReward.Grpc.Models;

namespace Service.TutorialFinancial.Services
{
	public partial class TutorialFinancialService : ITutorialFinancialService
	{
		private readonly ITaskProgressService _taskProgressService;
		private readonly IUserRewardService _userRewardService;

		public TutorialFinancialService(ITaskProgressService taskProgressService, IUserRewardService userRewardService)
		{
			_taskProgressService = taskProgressService;
			_userRewardService = userRewardService;
		}

		public async ValueTask<FinishStateGrpcResponse> GetFinishStateAsync(GetFinishStateGrpcRequest request)
		{
			Guid? userId = request.UserId;
			int? unit = request.Unit;

			TaskTypeProgressInfo typeProgressInfo = await _taskProgressService.GetTotalProgressAsync(userId, unit);

			UserAchievementsGrpcResponse achievements = await _userRewardService.GetUserNewAchievementsAsync(new GetUserAchievementsGrpcRequest
			{
				UserId = userId,
				Unit = unit
			});

			return typeProgressInfo.ToGrpcModel(achievements?.Items);
		}
	}
}