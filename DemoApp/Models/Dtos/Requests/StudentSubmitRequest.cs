namespace DemoApp.Models.Dtos.Requests;

public class StudentSubmitRequest
{
    public List<Student> Students { get; set; } = new();

    public List<Teacher> Teachers { get; set; } = new();
}
