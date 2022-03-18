using Autofac;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialFinancial.Grpc;

// ReSharper disable UnusedMember.Global

namespace Service.TutorialFinancial.Client
{
	public static class AutofacHelper
	{
		public static void RegisterTutorialFinancialClient(this ContainerBuilder builder, string grpcServiceUrl, ILogger logger)
		{
			var factory = new TutorialFinancialClientFactory(grpcServiceUrl, logger);

			builder.RegisterInstance(factory.GetTutorialFinancialService()).As<IGrpcServiceProxy<ITutorialFinancialService>>().SingleInstance();
		}
	}
}
