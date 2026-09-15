using Microsoft.AspNetCore.Mvc;

namespace WebApiIntroExercises.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet("description")]
    public string GetDescription()
    {
        return "Product: Gaming Computer, Quantity: 2";
    }

}