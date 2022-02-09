using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Service.TutorialFinancial.Grpc.Models.State
{
	[DataContract]
	public class FinancialStateGrpcResponse
	{
		[DataMember(Order = 1)]
		public bool Available { get; set; }

		[DataMember(Order = 2)]
		public IList<FinancialStateUnitGrpcModel> Units { get; set; }

		[DataMember(Order = 3)]
		public TotalProgressStateGrpcModel TotalProgress { get; set; }
	}
}