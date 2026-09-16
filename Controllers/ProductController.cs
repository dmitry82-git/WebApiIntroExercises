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

    [HttpGet("description/new")]
    public string GetNewDescription()
    {
        return "You have been redirected to the new description page for a product!";
    }


    [HttpGet("description/old")]
    public IActionResult GetOldDescription()
    {
        return Redirect("/api/product/description/new");
    }


}