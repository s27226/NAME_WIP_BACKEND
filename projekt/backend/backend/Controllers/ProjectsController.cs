using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("/[controller]")]
public class ProjectsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProjects()
    {
        var projects = new[]
        {
            new { id = 1, name = "Project 1", imageUrl = "" },
            new { id = 2, name = "Project 2", imageUrl = "" }
        };
        return Ok(projects);
    }
}