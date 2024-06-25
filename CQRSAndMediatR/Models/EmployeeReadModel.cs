namespace CQRSAndMediatR.Models;

public record EmployeeReadModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public int YearsOfService { get; set; }

    public EmployeeReadModel(Guid id, string name, string email, string address, int age)
    {
        Id = id;
        Name = name;
        Email = email;
        Address = address;
        Age = age;
    }
}
