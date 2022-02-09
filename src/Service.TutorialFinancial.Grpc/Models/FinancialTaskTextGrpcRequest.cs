using System;
using System.Runtime.Serialization;

namespace Service.TutorialFinancial.Grpc.Models
{
	[DataContract]
	public class FinancialTaskTextGrpcRequest
	{
		[DataMember(Order = 1)]
		public Guid? UserId { get; set; }

		[DataMember(Order = 2)]
		public bool IsRetry { get; set; }

		[DataMember(Order = 3)]
		public TimeSpan Duration { get; set; }
	}
}