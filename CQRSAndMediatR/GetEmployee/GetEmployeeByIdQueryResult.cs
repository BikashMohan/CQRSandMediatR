using CQRSAndMediatRDemo.Models;
using Messaging.Contracts;

namespace CQRSAndMediatR.GetEmployee;

public class GetEmployeeByIdQueryResult : IQueryResult
{
    public Employee Result;

    public GetEmployeeByIdQueryResult(Employee employee)
    {
        Result = employee;
    }
}
