using CQRSAndMediatRDemo.Models;
using Messaging.Contracts;

namespace CQRSAndMediatR.UpdateEmployee;

public class UpdateEmployeeCommandResult : ICommandResult
{
    public Employee Result { get; }

    public UpdateEmployeeCommandResult(Employee result)
    {
        Result = result;
    }
}
