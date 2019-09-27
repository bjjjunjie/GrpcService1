using Grpc.Net.Client;
using GrpcService1;
using System;

namespace grpcclient
{
    class Program
    {
       static void Main(string[] args)
        {
            Client();
            Console.ReadKey();
        }
        public static async void Client()
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            //创建连接通道，端口80




            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                new HelloRequest { Name = "晓晨" });
            Console.WriteLine("Greeter 服务返回数据: " + reply.Message);
        }
    }
}
