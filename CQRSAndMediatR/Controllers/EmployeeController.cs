using CQRSAndMediatR.CreateEmployee;
using CQRSAndMediatR.DeleteEmployee;
using CQRSAndMediatR.GetEmployee;
using CQRSAndMediatR.UpdateEmployee;
using CQRSAndMediatRDemo.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSAndMediatRDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IMediator _mediator;

    public EmployeeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetEmployeeListAsync()
    {
        var message = new GetEmployeeListQueryMessage();
        var response = await _mediator.Send(message);
        return Ok(response.Result);
    }

    [HttpGet("employeeId")]
    public async Task<IActionResult> GetEmployeeByIdAsync(int employeeId)
    {
        var message = new GetEmployeeByIdQueryMessage(employeeId);

        var response = await _mediator.Send(message);

        return Ok(response.Result);
    }

    [HttpPost]
    public async Task<IActionResult> AddEmployeeAsync(Employee employeeDetails)
    {
        var message = new CreateEmployeeCommandMessage(employeeDetails);

        var response = await _mediator.Send(message);

        return Ok(response.Result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateEmployeeAsync(Employee employeeDetails)
    {
        var message = new UpdateEmployeeCommandMessage(employeeDetails);

        var response = await _mediator.Send(message);

        return Ok(response.Result);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteEmployeeAsync(int Id)
    {
        var message = new DeleteEmployeeCommandMessage(Id);
        var response = await _mediator.Send(message);
        return Ok(response.Result);
    }
}