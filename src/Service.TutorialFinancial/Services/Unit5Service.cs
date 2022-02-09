using System.Threading.Tasks;
using Service.Education;
using Service.Education.Structure;
using Service.TutorialFinancial.Grpc.Models;
using Service.TutorialFinancial.Grpc.Models.State;
using static Service.Education.Helpers.AnswerHelper;

namespace Service.TutorialFinancial.Services
{
	public partial class TutorialFinancialService
	{
		public static readonly EducationStructureUnit Unit5 = EducationStructure.Tutorials[EducationTutorial.FinancialServices].Units[5];

		public async ValueTask<TestScoreGrpcResponse> Unit5TextAsync(FinancialTaskTextGrpcRequest request)
			=> await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit5, Unit5.Tasks[1], request.IsRetry, request.Duration);

		public async ValueTask<TestScoreGrpcResponse> Unit5TestAsync(FinancialTaskTestGrpcRequest request)
		{
			ITaskTestAnswer[] answers = request.Answers;

			int progress = CheckAnswer(20, answers, 1, 1)
				+ CheckAnswer(20, answers, 2, 2, 1)
				+ CheckAnswer(20, answers, 3, 2)
				+ CheckAnswer(20, answers, 4, 1)
				+ CheckAnswer(20, answers, 5, 2);

			return await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit5, Unit5.Tasks[2], request.IsRetry, request.Duration, progress);
		}

		public async ValueTask<TestScoreGrpcResponse> Unit5VideoAsync(FinancialTaskVideoGrpcRequest request) => 
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit5, Unit5.Tasks[3], request.IsRetry, request.Duration);

		public async ValueTask<TestScoreGrpcResponse> Unit5CaseAsync(FinancialTaskCaseGrpcRequest request) => 
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit5, Unit5.Tasks[4], request.IsRetry, request.Duration, CountProgress(request.Value == 1));

		public async ValueTask<TestScoreGrpcResponse> Unit5TrueFalseAsync(FinancialTaskTrueFalseGrpcRequest request)
		{
			ITaskTrueFalseAnswer[] answers = request.Answers;

			int progress = CheckAnswer(20, answers, 1, true)
				+ CheckAnswer(20, answers, 2, true)
				+ CheckAnswer(20, answers, 3, false)
				+ CheckAnswer(20, answers, 4, false)
				+ CheckAnswer(20, answers, 5, true);

			return await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit5, Unit5.Tasks[5], request.IsRetry, request.Duration, progress);
		}

		public async ValueTask<TestScoreGrpcResponse> Unit5GameAsync(FinancialTaskGameGrpcRequest request) => 
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit5, Unit5.Tasks[6], request.IsRetry, request.Duration);
	}
}