using Messaging.Contracts;

namespace CQRSAndMediatR.DeleteEmployee;

public class DeleteEmployeeCommandResult : ICommandResult
{
    public int Result { get; }

    public DeleteEmployeeCommandResult(int result)
    {
        Result = result;
    }
}
