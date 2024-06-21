using MediatR;

namespace Messaging.Contracts;

public interface ICommandMessage<out TResponse>
    : IRequest<TResponse> where TResponse : ICommandResult
{
}
