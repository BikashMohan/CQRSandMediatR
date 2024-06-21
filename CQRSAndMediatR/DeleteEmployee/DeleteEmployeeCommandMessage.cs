using Messaging.Contracts;

namespace CQRSAndMediatR.DeleteEmployee;

public class DeleteEmployeeCommandMessage : ICommandMessage<DeleteEmployeeCommandResult>
{
    public int Id;

    public DeleteEmployeeCommandMessage(int id)
    {
        Id = id;
    }
}
