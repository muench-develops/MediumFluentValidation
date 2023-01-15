using MediumFluentValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediumFluentValidation.Controllers;

public class CustomerController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateCustomer([FromBody] CustomerCreateRequest request)
    {
        return Ok();
    }
}