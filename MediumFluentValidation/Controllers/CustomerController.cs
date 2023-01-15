using MediumFluentValidation.Models;
using MediumFluentValidation.Validators;
using Microsoft.AspNetCore.Mvc;

namespace MediumFluentValidation.Controllers;

public class CustomerController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateCustomer([FromBody] CustomerCreateRequest request)
    {
        var validator = new CustomerCreateRequestValidator();
        var validationResult = validator.Validate(request);

        if (validationResult.IsValid == false)
        {
            return BadRequest(validationResult.Errors[0].ErrorMessage);
        }

        return Ok();
    }
}