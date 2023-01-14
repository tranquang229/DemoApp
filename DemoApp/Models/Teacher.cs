namespace DemoApp.Models;

public class Teacher
{
    public Guid Id { get; set; }

    public string FullName { get; set; }

    public List<Student> Students { get; set; } = new();
}
