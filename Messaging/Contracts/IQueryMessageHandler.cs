using MediatR;

namespace Messaging.Contracts;

public interface IQueryMessageHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
    where TQuery : IQueryMessage<TResponse>
    where TResponse : IQueryResult
{
}
