using CQRSAndMediatRDemo.Repositories;
using Messaging.Contracts;

namespace CQRSAndMediatR.GetEmployee;

public class GetEmployeeListQueryMessageHandler : IQueryMessageHandler<GetEmployeeListQueryMessage, GetEmployeeListQueryResult>
{
    private readonly IEmployeeRepository _employeeRepository;

    public GetEmployeeListQueryMessageHandler(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<GetEmployeeListQueryResult> Handle(GetEmployeeListQueryMessage request, CancellationToken cancellationToken)
    {
        var query = new GetEmployeeListQuery(_employeeRepository);
        return new GetEmployeeListQueryResult(await query.Execute());
    }
}
