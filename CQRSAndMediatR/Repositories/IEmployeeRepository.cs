using CQRSAndMediatR.Models;
using CQRSAndMediatRDemo.Models;

namespace CQRSAndMediatRDemo.Repositories;

public interface IEmployeeRepository
{
    public Task<List<EmployeeReadModel>> GetEmployeeListAsync();
    public Task<EmployeeReadModel> GetEmployeeByIdAsync(Guid Id);
    public Task<Employee> AddEmployeeAsync(Employee studentDetails);
    public Task<Employee> UpdateEmployeeAsync(Employee studentDetails);
    public Task<int> DeleteEmployeeAsync(Guid Id);
}
