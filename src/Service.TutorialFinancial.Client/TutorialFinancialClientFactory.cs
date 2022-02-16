using JetBrains.Annotations;
using MyJetWallet.Sdk.Grpc;
using Service.TutorialFinancial.Grpc;

namespace Service.TutorialFinancial.Client
{
	[UsedImplicitly]
	public class TutorialFinancialClientFactory : MyGrpcClientFactory
	{
		public TutorialFinancialClientFactory(string grpcServiceUrl) : base(grpcServiceUrl)
		{
		}

		public ITutorialFinancialService GetTutorialFinancialService() => CreateGrpcService<ITutorialFinancialService>();
	}
}
