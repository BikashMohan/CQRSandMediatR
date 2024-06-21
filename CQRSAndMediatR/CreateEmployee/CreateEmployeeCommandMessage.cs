using CQRSAndMediatRDemo.Models;
using Messaging.Contracts;

namespace CQRSAndMediatR.CreateEmployee;

public class CreateEmployeeCommandMessage : ICommandMessage<CreateEmployeeCommandMessageResult>
{
    public Employee Employee { get; }

    public CreateEmployeeCommandMessage(Employee employee)
    {
        Employee = employee;
    }
}
