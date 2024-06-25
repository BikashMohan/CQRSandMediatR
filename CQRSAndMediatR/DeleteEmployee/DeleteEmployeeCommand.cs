using CQRSAndMediatRDemo.Repositories;

namespace CQRSAndMediatR.DeleteEmployee;

public class DeleteEmployeeCommand
{
    private readonly Guid _id;
    private readonly IEmployeeRepository _employeeRepository;
    public DeleteEmployeeCommand(Guid id, IEmployeeRepository employeeRepository)
    {
        _id = id;
        _employeeRepository = employeeRepository;
    }

    public async Task<int> Execute()
    {
        var employeeDetails = await _employeeRepository.GetEmployeeByIdAsync(_id);
        if (employeeDetails == null)
            throw new Exception("Employee not exist");

        return await _employeeRepository.DeleteEmployeeAsync(employeeDetails.Id);
    }
}

