using CQRSAndMediatRDemo.CreateEmployee;
using CQRSAndMediatRDemo.Repositories;
using JetBrains.Annotations;
using Messaging.Contracts;

namespace CQRSAndMediatR.CreateEmployee;

[UsedImplicitly]
public class CreateEmployeeCommandMessageHandler : ICommandMessageHandler<CreateEmployeeCommandMessage, CreateEmployeeCommandMessageResult>
{
    private readonly IEmployeeRepository _employeeRepository;

    public CreateEmployeeCommandMessageHandler(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
    public async Task<CreateEmployeeCommandMessageResult> Handle(CreateEmployeeCommandMessage request, CancellationToken cancellationToken)
    {
        var command = new CreateEmployeeCommand(request.Employee, _employeeRepository);
        return new CreateEmployeeCommandMessageResult(await command.Execute());
    }
}
