using System;
using System.Runtime.Serialization;

namespace Service.TutorialFinancial.Grpc.Models
{
	[DataContract]
	public class FinancialTaskTrueFalseGrpcRequest
	{
		[DataMember(Order = 1)]
		public Guid? UserId { get; set; }

		[DataMember(Order = 2)]
		public FinancialTaskTrueFalseAnswerGrpcModel[] Answers { get; set; }

		[DataMember(Order = 3)]
		public bool IsRetry { get; set; }

		[DataMember(Order = 4)]
		public TimeSpan Duration { get; set; }
	}
}