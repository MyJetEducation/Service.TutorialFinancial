using System;
using System.Runtime.Serialization;

namespace Service.TutorialFinancial.Grpc.Models
{
	[DataContract]
	public class FinancialSelectTaskUnitGrpcRequest
	{
		[DataMember(Order = 1)]
		public Guid? UserId { get; set; }
	}
}