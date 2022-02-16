using System;
using System.Runtime.Serialization;

namespace Service.TutorialFinancial.Grpc.Models
{
	[DataContract]
	public class GetUnitFinishStateGrpcRequest
	{
		[DataMember(Order = 1)]
		public Guid? UserId { get; set; }

		[DataMember(Order = 2)]
		public int Unit { get; set; }
	}
}