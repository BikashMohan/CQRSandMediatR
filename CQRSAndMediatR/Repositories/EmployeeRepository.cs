using CQRSAndMediatRDemo.Data;
using CQRSAndMediatRDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSAndMediatRDemo.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly DbContextClass _dbContext;

    public EmployeeRepository(DbContextClass dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Employee> AddEmployeeAsync(Employee employeeDetails)
    {
        var result = _dbContext.Employee.Add(employeeDetails);
        await _dbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<int> DeleteEmployeeAsync(int Id)
    {
        var filteredData = _dbContext.Employee.Where(x => x.Id == Id).FirstOrDefault();
        _dbContext.Employee.Remove(filteredData);
        return await _dbContext.SaveChangesAsync();
    }

    public async Task<Employee> GetEmployeeByIdAsync(int Id)
    {
        return await _dbContext.Employee.Where(x => x.Id == Id).FirstOrDefaultAsync();
    }

    public async Task<List<Employee>> GetEmployeeListAsync()
    {
        return await _dbContext.Employee.ToListAsync();
    }

    public async Task<Employee> UpdateEmployeeAsync(Employee employeeDetails)
    {
        var result = _dbContext.Employee.Update(employeeDetails);
        await _dbContext.SaveChangesAsync();
        return result.Entity;
    }
}
