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
		public static readonly EducationStructureUnit Unit2 = EducationStructure.Tutorials[EducationTutorial.FinancialServices].Units[2];

		public async ValueTask<TestScoreGrpcResponse> Unit2TextAsync(FinancialTaskTextGrpcRequest request) => 
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit2, Unit2.Tasks[1], request.IsRetry, request.Duration);

		public async ValueTask<TestScoreGrpcResponse> Unit2TestAsync(FinancialTaskTestGrpcRequest request)
		{
			ITaskTestAnswer[] answers = request.Answers;

			int progress = CheckAnswer(20, answers, 1, 1, 2)
				+ CheckAnswer(20, answers, 2, 2, 3)
				+ CheckAnswer(20, answers, 3, 1)
				+ CheckAnswer(20, answers, 4, 2)
				+ CheckAnswer(20, answers, 5, 1, 2);

			return await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit2, Unit2.Tasks[2], request.IsRetry, request.Duration, progress);
		}

		public async ValueTask<TestScoreGrpcResponse> Unit2VideoAsync(FinancialTaskVideoGrpcRequest request) => 
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit2, Unit2.Tasks[3], request.IsRetry, request.Duration);

		public async ValueTask<TestScoreGrpcResponse> Unit2CaseAsync(FinancialTaskCaseGrpcRequest request) => 
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit2, Unit2.Tasks[4], request.IsRetry, request.Duration, CountProgress(request.Value == 2));

		public async ValueTask<TestScoreGrpcResponse> Unit2TrueFalseAsync(FinancialTaskTrueFalseGrpcRequest request)
		{
			ITaskTrueFalseAnswer[] answers = request.Answers;

			int progress = CheckAnswer(20, answers, 1, false)
				+ CheckAnswer(20, answers, 2, false)
				+ CheckAnswer(20, answers, 3, true)
				+ CheckAnswer(20, answers, 4, false)
				+ CheckAnswer(20, answers, 5, false);

			return await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit2, Unit2.Tasks[5], request.IsRetry, request.Duration, progress);
		}

		public async ValueTask<TestScoreGrpcResponse> Unit2GameAsync(FinancialTaskGameGrpcRequest request) => 
			await _taskProgressService.SetTaskProgressAsync(request.UserId, Unit2, Unit2.Tasks[6], request.IsRetry, request.Duration);
	}
}