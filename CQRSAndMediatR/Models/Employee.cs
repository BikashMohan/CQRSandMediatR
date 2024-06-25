namespace CQRSAndMediatRDemo.Models;

public class Employee
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public DateOnly HireDate { get; set; }

    public Employee(string name, string email, string address, int age, DateOnly hireDate)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        Address = address;
        Age = age;
        HireDate = hireDate;
    }
}
