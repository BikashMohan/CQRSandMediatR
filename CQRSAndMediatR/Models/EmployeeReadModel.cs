namespace CQRSAndMediatR.Models;

public class EmployeeReadModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public int YearsOfService { get; set; }
}
