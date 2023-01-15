namespace MediumFluentValidation.Models;

public class CustomerCreateRequest
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}