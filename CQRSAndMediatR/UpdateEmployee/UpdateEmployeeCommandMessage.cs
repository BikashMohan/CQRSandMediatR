using CQRSAndMediatRDemo.Models;
using Messaging.Contracts;

namespace CQRSAndMediatR.UpdateEmployee;

public class UpdateEmployeeCommandMessage : ICommandMessage<UpdateEmployeeCommandResult>
{
    public Employee Employee { get; set; }
    public UpdateEmployeeCommandMessage(Employee employee)
    {
        Employee = employee;
    }
}
