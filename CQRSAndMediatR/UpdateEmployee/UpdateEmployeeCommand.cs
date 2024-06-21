using CQRSAndMediatRDemo.Models;
using CQRSAndMediatRDemo.Repositories;

namespace CQRSAndMediatR.UpdateEmployee;

public class UpdateEmployeeCommand
{
    private readonly Employee _employee;
    private readonly IEmployeeRepository _employeeRepository;

    public UpdateEmployeeCommand(Employee employee, IEmployeeRepository employeeRepository)
    {
        _employee = employee;
        _employeeRepository = employeeRepository;
    }

    public async Task<Employee> Execute()
    {
        var employeeDetails = await _employeeRepository.GetEmployeeByIdAsync(_employee.Id);
        if (employeeDetails == null)
            return default;

        employeeDetails.Name = _employee.Name;
        employeeDetails.Email = _employee.Email;
        employeeDetails.Address = _employee.Address;
        employeeDetails.Age = _employee.Age;

        return await _employeeRepository.UpdateEmployeeAsync(employeeDetails);
    }
}
