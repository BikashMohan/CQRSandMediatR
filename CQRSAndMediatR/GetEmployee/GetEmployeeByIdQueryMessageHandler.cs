using CQRSAndMediatRDemo.Repositories;
using Messaging.Contracts;

namespace CQRSAndMediatR.GetEmployee;

public class GetEmployeeByIdQueryMessageHandler : IQueryMessageHandler<GetEmployeeByIdQueryMessage, GetEmployeeByIdQueryResult>
{
    private readonly IEmployeeRepository _employeeRepository;

    public GetEmployeeByIdQueryMessageHandler(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<GetEmployeeByIdQueryResult> Handle(GetEmployeeByIdQueryMessage request, CancellationToken cancellationToken)
    {
        var query = new GetEmployeeByIdQuery(request.EmployeeId, _employeeRepository);
        return new GetEmployeeByIdQueryResult(await query.Execute());
    }
}
