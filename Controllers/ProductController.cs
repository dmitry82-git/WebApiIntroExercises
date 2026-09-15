using Microsoft.AspNetCore.Mvc;

namespace WebApiIntroExercises.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet("description")]
    public string GetDescription(string name = "Gaming Computer", int quantity = 2)
    {
        return $"Product: {name}, Quantity: {quantity}";
    }

}