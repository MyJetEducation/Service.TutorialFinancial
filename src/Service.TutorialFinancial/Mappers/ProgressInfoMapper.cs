using Service.Core.Client.Constants;
using Service.TutorialFinancial.Grpc.Models.State;
using Service.TutorialFinancial.Models;

namespace Service.TutorialFinancial.Mappers
{
	public static class ProgressInfoMapper
	{
		public static FinishStateGrpcResponse ToGrpcModel(this TaskTypeProgressInfo info, UserAchievement[] achievements)
		{
			return new FinishStateGrpcResponse
			{
				Case = info.Case,
				TrueFalse = info.TrueFalse,
				Game = info.Game,
				Test = info.Test,
				Text = info.Text,
				Video = info.Video,
				Achievements = achievements
			};
		}
	}
}