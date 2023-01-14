namespace DemoApp.Models;

public class Student
{
    public Guid Id { get; set; }

    public string FullName { get; set; }

    public DateTime DateOfBirth { get; set; }

    public Guid TeacherId { get; set; }
}
