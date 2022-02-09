using System.Runtime.Serialization;

namespace Service.TutorialFinancial.Grpc.Models.State
{
	[DataContract]
	public class FinancialStateUnitGrpcModel
	{
		[DataMember(Order = 1)]
		public int Unit { get; set; }

		[DataMember(Order = 2)]
		public int TestScore { get; set; }

		[DataMember(Order = 3)]
		public FinancialStateTaskGrpcModel[] Tasks { get; set; }
	}
}