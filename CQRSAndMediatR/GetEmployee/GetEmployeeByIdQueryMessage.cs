using Messaging.Contracts;

namespace CQRSAndMediatR.GetEmployee;

public class GetEmployeeByIdQueryMessage : IQueryMessage<GetEmployeeByIdQueryResult>
{
    public int EmployeeId { get; }
    public GetEmployeeByIdQueryMessage(int employeeId)
    {
        EmployeeId = employeeId;
    }
}
