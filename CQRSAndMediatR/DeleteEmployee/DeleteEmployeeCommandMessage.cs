using Messaging.Contracts;

namespace CQRSAndMediatR.DeleteEmployee;

public class DeleteEmployeeCommandMessage : ICommandMessage<DeleteEmployeeCommandResult>
{
    public Guid Id;

    public DeleteEmployeeCommandMessage(Guid id)
    {
        Id = id;
    }
}
