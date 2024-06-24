using CQRSAndMediatR.Models;
using CQRSAndMediatRDemo.Repositories;

namespace CQRSAndMediatR.GetEmployee;

public class GetEmployeeByIdQuery
{
    private int _employeeId;
    private IEmployeeRepository _employeeRepository;

    public GetEmployeeByIdQuery(int employeeId, IEmployeeRepository employeeRepository)
    {
        _employeeId = employeeId;
        _employeeRepository = employeeRepository;
    }

    public async Task<EmployeeReadModel> Execute()
    {
        return await _employeeRepository.GetEmployeeByIdAsync(_employeeId);
    }
}
