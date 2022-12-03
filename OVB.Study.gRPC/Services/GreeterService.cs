using Grpc.Core;
using OVB.Study.gRPC;

namespace OVB.Study.gRPC.Services;

public class GreeterService : Greeter.GreeterBase
{
    public override Task<Response> Message(Request request, ServerCallContext context)
    {
        return Task.FromResult(new Response
        {
            Notification = $"T�tulo: {request.Title}, Descri��o: {request.Description}"
        });
    }
}