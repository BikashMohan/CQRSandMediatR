using Messaging.Contracts;

namespace CQRSAndMediatR.GetEmployee;

public class GetEmployeeByIdQueryMessage : IQueryMessage<GetEmployeeByIdQueryResult>
{
    public Guid EmployeeId { get; }
    public GetEmployeeByIdQueryMessage(Guid employeeId)
    {
        EmployeeId = employeeId;
    }
}
