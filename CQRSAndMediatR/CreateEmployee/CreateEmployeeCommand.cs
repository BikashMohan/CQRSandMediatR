using CQRSAndMediatRDemo.Models;
using CQRSAndMediatRDemo.Repositories;

namespace CQRSAndMediatRDemo.CreateEmployee;

public class CreateEmployeeCommand
{
    private readonly Employee _employee;
    private readonly IEmployeeRepository _employeeRepository;

    public CreateEmployeeCommand(Employee employee, IEmployeeRepository employeeRepository)
    {
        _employee = employee;
        _employeeRepository = employeeRepository;
    }

    public async Task<Employee> Execute()
    {

        var employeeDetails = new Employee(_employee.Name, _employee.Email, _employee.Address, _employee.Age, _employee.HireDate);
        await _employeeRepository.AddEmployeeAsync(employeeDetails);
        return employeeDetails;


    }
}
