using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Service.Education.Structure;
using Service.TutorialFinancial.Grpc;
using Service.TutorialFinancial.Grpc.Models;
using Service.TutorialFinancial.Grpc.Models.State;
using Service.TutorialFinancial.Mappers;
using Service.UserProgress.Grpc;
using Service.UserProgress.Grpc.Models;
using Service.UserReward.Grpc;
using Service.UserReward.Grpc.Models;

namespace Service.TutorialFinancial.Services
{
	public partial class TutorialFinancialService : ITutorialFinancialService
	{
		private static readonly EducationStructureTutorial Tutorial = EducationStructure.Tutorials[EducationTutorial.FinancialServices];

		private readonly ITaskProgressService _taskProgressService;
		private readonly IUserRewardService _userRewardService;
		private readonly IUserProgressService _userProgressService;

		public TutorialFinancialService(ITaskProgressService taskProgressService, IUserRewardService userRewardService, IUserProgressService userProgressService)
		{
			_taskProgressService = taskProgressService;
			_userRewardService = userRewardService;
			_userProgressService = userProgressService;
		}

		public async ValueTask<FinancialStateGrpcResponse> GetDashboardStateAsync(FinancialSelectTaskUnitGrpcRequest request)
		{
			var units = new List<FinancialStateUnitGrpcModel>();
			Guid? userId = request.UserId;

			foreach ((_, EducationStructureUnit unit) in Tutorial.Units)
			{
				(FinancialStateUnitGrpcModel stateUnitModel, _, _) = await _taskProgressService.GetUnitProgressAsync(userId, unit.Unit);

				if (stateUnitModel != null)
					units.Add(stateUnitModel);
			}

			UserAchievementsGrpcResponse achievements = await _userRewardService.GetUserAchievementsAsync(new GetUserAchievementsGrpcRequest {UserId = userId});
			UnitedProgressGrpcResponse progress = await _userProgressService.GetUnitedProgressAsync(new GetProgressGrpcRequset {UserId = userId});

			return new FinancialStateGrpcResponse
			{
				Available = true,
				Units = units,
				TotalProgress = new TotalProgressStateGrpcModel
				{
					Habit = progress.Habit.ToGrpcModel(),
					Skill = progress.Skill.ToGrpcModel(),
					Achievements = achievements.Items
				}
			};
		}

		public async ValueTask<FinishUnitGrpcResponse> GetFinishStateAsync(GetFinishStateGrpcRequest request)
		{
			Guid? userId = request.UserId;

			(FinancialStateUnitGrpcModel stateUnitModel, int trueFalseProgress, int caseProgress) = await _taskProgressService.GetUnitProgressAsync(userId, request.Unit);

			var result = new FinishUnitGrpcResponse
			{
				Unit = stateUnitModel,
				TrueFalseProgress = trueFalseProgress,
				CaseProgress = caseProgress
			};

			UserAchievementsGrpcResponse newAchievements = await _userRewardService.GetUserNewUnitAchievementsAsync(new GetUserAchievementsGrpcRequest {UserId = userId});
			if (newAchievements != null)
				result.NewAchievements = newAchievements.Items;

			return result;
		}
	}
}