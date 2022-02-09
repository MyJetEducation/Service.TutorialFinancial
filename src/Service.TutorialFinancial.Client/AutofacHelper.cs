using Autofac;
using Service.TutorialFinancial.Grpc;

// ReSharper disable UnusedMember.Global

namespace Service.TutorialFinancial.Client
{
    public static class AutofacHelper
    {
        public static void RegisterTutorialFinancialClient(this ContainerBuilder builder, string grpcServiceUrl)
        {
            var factory = new TutorialFinancialClientFactory(grpcServiceUrl);

            builder.RegisterInstance(factory.GetTutorialFinancialService()).As<ITutorialFinancialService>().SingleInstance();
        }
    }
}
