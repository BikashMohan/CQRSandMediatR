using CQRSAndMediatRDemo.Models;
using Messaging.Contracts;

namespace CQRSAndMediatR.GetEmployee;

public class GetEmployeeListQueryResult : IQueryResult
{
    public List<Employee> Result;

    public GetEmployeeListQueryResult(List<Employee> employee)
    {
        Result = employee;
    }
}
