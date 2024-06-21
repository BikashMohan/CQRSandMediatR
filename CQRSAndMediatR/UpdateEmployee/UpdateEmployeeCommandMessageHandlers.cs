using CQRSAndMediatRDemo.Repositories;
using Messaging.Contracts;

namespace CQRSAndMediatR.UpdateEmployee;

public class UpdateEmployeeCommandMessageHandlers : ICommandMessageHandler<UpdateEmployeeCommandMessage, UpdateEmployeeCommandResult>
{
    private readonly IEmployeeRepository _employeeRepository;

    public UpdateEmployeeCommandMessageHandlers(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<UpdateEmployeeCommandResult> Handle(UpdateEmployeeCommandMessage request, CancellationToken cancellationToken)
    {
        var updateEmployeeCommand = new UpdateEmployeeCommand(request.Employee, _employeeRepository);
        return new UpdateEmployeeCommandResult(await updateEmployeeCommand.Execute());
    }
}
