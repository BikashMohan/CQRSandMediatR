using CQRSAndMediatRDemo.Models;
using Messaging.Contracts;

namespace CQRSAndMediatR.CreateEmployee;

public class CreateEmployeeCommandMessageResult : ICommandResult
{
    public Employee Result { get; }

    public CreateEmployeeCommandMessageResult(Employee result)
    {
        Result = result;
    }
}
