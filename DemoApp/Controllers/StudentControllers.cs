using DemoApp.Models;
using DemoApp.Models.Dtos.Requests;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StudentControllers : ControllerBase
{

    [HttpPost("submit")]
    public IActionResult Submit([FromBody] StudentSubmitRequest request)
    {

        if (request.Students.Count < 30)
        {
            return BadRequest("Must be > 30 students");
        }

        if (request.Teachers.Count < 2)
        {
            return BadRequest("Must be > 2 students");
        }

        var response = SortTeachersAndStudents(request);

        return Ok(response);
    }

    private List<Teacher> SortTeachersAndStudents(StudentSubmitRequest request)
    {
        var listTeacherOrderedByName = request.Teachers.OrderBy(x => x.FullName);
        foreach (var teacher in listTeacherOrderedByName)
        {
            teacher.Students = request.Students
                .Where(x => x.TeacherId == teacher.Id)
                .OrderBy(x => x.DateOfBirth)
                .ToList();
        }

        return listTeacherOrderedByName.ToList();

    }
}
