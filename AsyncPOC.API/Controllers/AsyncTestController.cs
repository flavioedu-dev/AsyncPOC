using AsyncPOC.Application;
using Microsoft.AspNetCore.Mvc;

namespace AsyncPOC.API.Controllers;

[ApiController]
[Route("[controller]")]
public class AsyncTestController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        AsyncMethods asyncTest = new AsyncMethods();

        await asyncTest.ExecMethods();

        return StatusCode(StatusCodes.Status200OK, null);
    }
}