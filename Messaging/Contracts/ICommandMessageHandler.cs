using MediatR;

namespace Messaging.Contracts;

public interface ICommandMessageHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommandMessage<TResponse>
    where TResponse : ICommandResult
{
}
