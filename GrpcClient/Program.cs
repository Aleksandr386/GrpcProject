﻿using Grpc.Net.Client;
using GrpcServer;

namespace GrpcClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:7128");
            var client = new Greeter.GreeterClient(channel);

            var input = new HelloRequest { Name = "Alex" };

            var reply = await client.SayHelloAsync(input);

            Console.WriteLine(reply.Message);

            Console.ReadLine();
        }
    }
}