using MediatR;

namespace Messaging.Contracts;

public interface IQueryMessage<out TResponse>
: IRequest<TResponse> where TResponse : IQueryResult
{
}
