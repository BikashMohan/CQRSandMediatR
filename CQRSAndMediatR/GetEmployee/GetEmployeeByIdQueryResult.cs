using CQRSAndMediatR.Models;
using Messaging.Contracts;

namespace CQRSAndMediatR.GetEmployee;

public class GetEmployeeByIdQueryResult : IQueryResult
{
    public EmployeeReadModel Result;

    public GetEmployeeByIdQueryResult(EmployeeReadModel employee)
    {
        Result = employee;
    }
}
