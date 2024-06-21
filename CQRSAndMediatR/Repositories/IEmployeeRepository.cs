﻿using CQRSAndMediatRDemo.Models;

namespace CQRSAndMediatRDemo.Repositories;

public interface IEmployeeRepository
{
    public Task<List<Employee>> GetEmployeeListAsync();
    public Task<Employee> GetEmployeeByIdAsync(int Id);
    public Task<Employee> AddEmployeeAsync(Employee studentDetails);
    public Task<Employee> UpdateEmployeeAsync(Employee studentDetails);
    public Task<int> DeleteEmployeeAsync(int Id);
}
