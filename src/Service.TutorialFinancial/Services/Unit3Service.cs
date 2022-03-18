using System.Threading.Tasks;
using Service.Education;
using Service.Education.Structure;
using Service.TutorialFinancial.Grpc.Models;
using Service.TutorialFinancial.Grpc.Models.State;
using Service.TutorialFinancial.Helper;
using static Service.Education.Helpers.AnswerHelper;

namespace Service.TutorialFinancial.Services
{
	public partial class TutorialFinancialService
	{
		private static readonly EducationStructureUnit Unit3 = TutorialHelper.StructureTutorial.Units[3];

		public async ValueTask<TestScoreGrpcResponse> Unit3TextAsync(FinancialTaskTextGrpcRequest request) =>
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit3, Unit3.Tasks[1], request.IsRetry, request.Duration);

		public async ValueTask<TestScoreGrpcResponse> Unit3TestAsync(FinancialTaskTestGrpcRequest request)
		{
			ITaskTestAnswer[] answers = request.Answers;

			int progress = CheckAnswer(20, answers, 1, 2)
				+ CheckAnswer(20, answers, 2, 2)
				+ CheckAnswer(20, answers, 3, 2)
				+ CheckAnswer(20, answers, 4, 2)
				+ CheckAnswer(20, answers, 5, 2);

			return await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit3, Unit3.Tasks[2], request.IsRetry, request.Duration, progress);
		}

		public async ValueTask<TestScoreGrpcResponse> Unit3VideoAsync(FinancialTaskVideoGrpcRequest request) =>
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit3, Unit3.Tasks[3], request.IsRetry, request.Duration);

		public async ValueTask<TestScoreGrpcResponse> Unit3CaseAsync(FinancialTaskCaseGrpcRequest request) =>
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit3, Unit3.Tasks[4], request.IsRetry, request.Duration, CountProgress(request.Value == 1));

		public async ValueTask<TestScoreGrpcResponse> Unit3TrueFalseAsync(FinancialTaskTrueFalseGrpcRequest request)
		{
			ITaskTrueFalseAnswer[] answers = request.Answers;

			int progress = CheckAnswer(20, answers, 1, false)
				+ CheckAnswer(20, answers, 2, true)
				+ CheckAnswer(20, answers, 3, true)
				+ CheckAnswer(20, answers, 4, true)
				+ CheckAnswer(20, answers, 5, true);

			return await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit3, Unit3.Tasks[5], request.IsRetry, request.Duration, progress);
		}

		public async ValueTask<TestScoreGrpcResponse> Unit3GameAsync(FinancialTaskGameGrpcRequest request) =>
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit3, Unit3.Tasks[6], request.IsRetry, request.Duration);
	}
}