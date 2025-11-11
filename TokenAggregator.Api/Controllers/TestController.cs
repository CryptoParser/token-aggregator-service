using Microsoft.AspNetCore.Mvc;

namespace TokenAggregator.Api.Controllers;

[ApiController]
public class TestController : ControllerBase
{
    [HttpGet("ping")]
    public async Task<IActionResult> Test()
    {
        return Ok("pong1");
    }
}