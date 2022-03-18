using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Service.Grpc;
using Service.TutorialFinancial.Client;
using Service.TutorialFinancial.Grpc;
using GrpcClientFactory = ProtoBuf.Grpc.Client.GrpcClientFactory;

namespace TestApp
{
	public class Program
	{
		private static async Task Main(string[] args)
		{
			GrpcClientFactory.AllowUnencryptedHttp2 = true;
			ILogger<Program> logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger<Program>();

			Console.Write("Press enter to start");
			Console.ReadLine();

			var factory = new TutorialFinancialClientFactory("http://localhost:5001", logger);
			IGrpcServiceProxy<ITutorialFinancialService> serviceProxy = factory.GetTutorialFinancialService();
			ITutorialFinancialService client = serviceProxy.Service;

			//var resp = await  client.SayHelloAsync(new HelloGrpcRequest(){Name = "Alex"});
			//Console.WriteLine(resp?.Message);

			Console.WriteLine("End");
			Console.ReadLine();
		}
	}
}