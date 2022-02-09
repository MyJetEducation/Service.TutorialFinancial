﻿using System.Threading.Tasks;
using Service.Education;
using Service.Education.Structure;
using Service.TutorialFinancial.Grpc.Models;
using Service.TutorialFinancial.Grpc.Models.State;
using static Service.Education.Helpers.AnswerHelper;

namespace Service.TutorialFinancial.Services
{
	public partial class TutorialFinancialService
	{
		public static readonly EducationStructureUnit Unit4 = EducationStructure.Tutorials[EducationTutorial.FinancialServices].Units[4];

		public async ValueTask<TestScoreGrpcResponse> Unit4TextAsync(FinancialTaskTextGrpcRequest request) => 
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit4, Unit4.Tasks[1], request.IsRetry, request.Duration);

		public async ValueTask<TestScoreGrpcResponse> Unit4TestAsync(FinancialTaskTestGrpcRequest request)
		{
			ITaskTestAnswer[] answers = request.Answers;

			int progress = CheckAnswer(20, answers, 1, 2)
				+ CheckAnswer(20, answers, 2, 1)
				+ CheckAnswer(20, answers, 3, 2)
				+ CheckAnswer(20, answers, 4, 1)
				+ CheckAnswer(20, answers, 5, 2);

			return await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit4, Unit4.Tasks[2], request.IsRetry, request.Duration, progress);
		}

		public async ValueTask<TestScoreGrpcResponse> Unit4VideoAsync(FinancialTaskVideoGrpcRequest request) => 
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit4, Unit4.Tasks[3], request.IsRetry, request.Duration);

		public async ValueTask<TestScoreGrpcResponse> Unit4CaseAsync(FinancialTaskCaseGrpcRequest request) => 
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit4, Unit4.Tasks[4], request.IsRetry, request.Duration, CountProgress(request.Value == 1));

		public async ValueTask<TestScoreGrpcResponse> Unit4TrueFalseAsync(FinancialTaskTrueFalseGrpcRequest request)
		{
			ITaskTrueFalseAnswer[] answers = request.Answers;

			int progress = CheckAnswer(20, answers, 1, false)
				+ CheckAnswer(20, answers, 2, false)
				+ CheckAnswer(20, answers, 3, true)
				+ CheckAnswer(20, answers, 4, true)
				+ CheckAnswer(20, answers, 5, true);

			return await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit4, Unit4.Tasks[5], request.IsRetry, request.Duration, progress);
		}

		public async ValueTask<TestScoreGrpcResponse> Unit4GameAsync(FinancialTaskGameGrpcRequest request) => 
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit4, Unit4.Tasks[6], request.IsRetry, request.Duration);
	}
}