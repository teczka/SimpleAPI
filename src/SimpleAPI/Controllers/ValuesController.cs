using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public ValuesController()
    {
    }

    [HttpGet(Name = "GetName")]
    public ActionResult<string> Get()
    {
        return "Pawel";
    }
}
