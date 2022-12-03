using Grpc.Core;
using gRPCHost;

namespace OVB.Study.gRPC.Client;

public class Program
{
    static async Task Main(string[] args)
    {
        var channel = new Channel("localhost:5145", ChannelCredentials.Insecure);

        var client = new Greeter.GreeterClient(channel);
        var response = await client.MessageAsync(new Request()
        {
            Title = "Title",
            Description = "Description",
        });
        Console.WriteLine(response.Notification);
        await channel.ShutdownAsync();
    }
}