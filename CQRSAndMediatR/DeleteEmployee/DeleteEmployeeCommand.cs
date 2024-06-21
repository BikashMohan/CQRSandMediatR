using CQRSAndMediatRDemo.Repositories;

namespace CQRSAndMediatR.DeleteEmployee;

public class DeleteEmployeeCommand
{
    private readonly int _id;
    private readonly IEmployeeRepository _employeeRepository;
    public DeleteEmployeeCommand(int id, IEmployeeRepository employeeRepository)
    {
        _id = id;
        _employeeRepository = employeeRepository;
    }

    public async Task<int> Execute()
    {
        var employeeDetails = await _employeeRepository.GetEmployeeByIdAsync(_id);
        if (employeeDetails == null)
            return default;

        return await _employeeRepository.DeleteEmployeeAsync(employeeDetails.Id);
    }
}

