using System;
using System.Threading.Tasks;
using ProtoBuf.Grpc.Client;
using Service.TutorialFinancial.Client;
using Service.TutorialFinancial.Grpc.Models;

namespace TestApp
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            GrpcClientFactory.AllowUnencryptedHttp2 = true;

            Console.Write("Press enter to start");
            Console.ReadLine();

            var factory = new TutorialFinancialClientFactory("http://localhost:5001");
            var client = factory.GetTutorialFinancialService();

            //var resp = await  client.SayHelloAsync(new HelloGrpcRequest(){Name = "Alex"});
            //Console.WriteLine(resp?.Message);

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
