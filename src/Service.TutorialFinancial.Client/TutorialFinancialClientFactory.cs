using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialFinancial.Grpc;

namespace Service.TutorialFinancial.Client
{
	[UsedImplicitly]
	public class TutorialFinancialClientFactory : GrpcClientFactory
	{
		public TutorialFinancialClientFactory(string grpcServiceUrl, ILogger logger) : base(grpcServiceUrl, logger)
		{
		}

		public IGrpcServiceProxy<ITutorialFinancialService> GetTutorialFinancialService() => CreateGrpcService<ITutorialFinancialService>();
	}
}