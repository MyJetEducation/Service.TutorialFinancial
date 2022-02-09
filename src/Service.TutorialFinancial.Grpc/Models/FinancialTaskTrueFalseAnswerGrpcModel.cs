using System.Runtime.Serialization;
using Service.Education;

namespace Service.TutorialFinancial.Grpc.Models
{
	[DataContract]
	public class FinancialTaskTrueFalseAnswerGrpcModel : ITaskTrueFalseAnswer
	{
		[DataMember(Order = 1)]
		public int Number { get; set; }

		[DataMember(Order = 2)]
		public bool Value { get; set; }
	}
}