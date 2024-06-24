using System.ComponentModel.DataAnnotations.Schema;

namespace CQRSAndMediatRDemo.Models;

public class Employee
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public DateTime HireDate { get; set; }
}
