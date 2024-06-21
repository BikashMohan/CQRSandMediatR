using CQRSAndMediatRDemo.Repositories;
using Messaging.Contracts;

namespace CQRSAndMediatR.DeleteEmployee;

public class DeleteEmployeeCommandMessageHandler : ICommandMessageHandler<DeleteEmployeeCommandMessage, DeleteEmployeeCommandResult>
{
    private readonly IEmployeeRepository _employeeRepository;

    public DeleteEmployeeCommandMessageHandler(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<DeleteEmployeeCommandResult> Handle(DeleteEmployeeCommandMessage request, CancellationToken cancellationToken)
    {
        var command = new DeleteEmployeeCommand(request.Id, _employeeRepository);
        return new DeleteEmployeeCommandResult(await command.Execute());
    }
}
