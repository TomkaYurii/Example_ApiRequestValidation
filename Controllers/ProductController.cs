using Microsoft.AspNetCore.Mvc;
using ApiRequestValidation.Entities;

namespace ApiRequestValidation.Controllers;

////////////////////////////////////////////////////////
// Model Binding validation + Data Annotations
////////////////////////////////////////////////////////
// Using DataAnnotations and ModelBinding I can replace 
// all the dirty validation logic in the controllers for
// a clean and separated validation logic directly on the
// application models.

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    [HttpPost]
    public ActionResult Post(Product product)
    {
        // comment 22-25 for Action Filters validations
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(product);
    }
}
