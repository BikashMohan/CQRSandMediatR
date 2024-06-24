using CQRSAndMediatR.Models;
using Messaging.Contracts;

namespace CQRSAndMediatR.GetEmployee;

public class GetEmployeeListQueryResult : IQueryResult
{
    public List<EmployeeReadModel> Result;

    public GetEmployeeListQueryResult(List<EmployeeReadModel> employee)
    {
        Result = employee;
    }
}
