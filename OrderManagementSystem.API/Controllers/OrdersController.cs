using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("API работает ??");
    }
}