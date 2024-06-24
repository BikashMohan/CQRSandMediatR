using CQRSAndMediatR.Models;
using CQRSAndMediatRDemo.Repositories;

namespace CQRSAndMediatR.GetEmployee;

public class GetEmployeeListQuery
{
    private IEmployeeRepository _employeeRepository;

    public GetEmployeeListQuery(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<List<EmployeeReadModel>> Execute()
    {
        return await _employeeRepository.GetEmployeeListAsync();
    }
}
