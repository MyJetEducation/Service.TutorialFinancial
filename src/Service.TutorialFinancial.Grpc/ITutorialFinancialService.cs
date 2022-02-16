using System.ServiceModel;
using System.Threading.Tasks;
using Service.TutorialFinancial.Grpc.Models;
using Service.TutorialFinancial.Grpc.Models.State;

namespace Service.TutorialFinancial.Grpc
{
	[ServiceContract]
	public interface ITutorialFinancialService
	{
		[OperationContract]
		ValueTask<FinishStateGrpcResponse> GetFinishStateAsync(GetFinishStateGrpcRequest request);

		#region Unit1

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit1TextAsync(FinancialTaskTextGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit1TestAsync(FinancialTaskTestGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit1VideoAsync(FinancialTaskVideoGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit1CaseAsync(FinancialTaskCaseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit1TrueFalseAsync(FinancialTaskTrueFalseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit1GameAsync(FinancialTaskGameGrpcRequest request);

		#endregion

		#region Unit2

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit2TextAsync(FinancialTaskTextGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit2TestAsync(FinancialTaskTestGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit2VideoAsync(FinancialTaskVideoGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit2CaseAsync(FinancialTaskCaseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit2TrueFalseAsync(FinancialTaskTrueFalseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit2GameAsync(FinancialTaskGameGrpcRequest request);

		#endregion

		#region Unit3

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit3TextAsync(FinancialTaskTextGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit3TestAsync(FinancialTaskTestGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit3VideoAsync(FinancialTaskVideoGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit3CaseAsync(FinancialTaskCaseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit3TrueFalseAsync(FinancialTaskTrueFalseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit3GameAsync(FinancialTaskGameGrpcRequest request);

		#endregion

		#region Unit4

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit4TextAsync(FinancialTaskTextGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit4TestAsync(FinancialTaskTestGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit4VideoAsync(FinancialTaskVideoGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit4CaseAsync(FinancialTaskCaseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit4TrueFalseAsync(FinancialTaskTrueFalseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit4GameAsync(FinancialTaskGameGrpcRequest request);

		#endregion

		#region Unit5

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit5TextAsync(FinancialTaskTextGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit5TestAsync(FinancialTaskTestGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit5VideoAsync(FinancialTaskVideoGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit5CaseAsync(FinancialTaskCaseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit5TrueFalseAsync(FinancialTaskTrueFalseGrpcRequest request);

		[OperationContract]
		ValueTask<TestScoreGrpcResponse> Unit5GameAsync(FinancialTaskGameGrpcRequest request);

		#endregion
	}
}