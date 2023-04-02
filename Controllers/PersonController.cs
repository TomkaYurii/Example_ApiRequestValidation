using Microsoft.AspNetCore.Mvc;
using ApiRequestValidation.Entities;

namespace ApiRequestValidation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonController : ControllerBase
{

    // [HttpPost]
    // public ActionResult Post(Person? person)
    // {
    //     if (ValidatePerson(person))
    //     {
    //         //...

    //         return Ok();
    //     }

    //     return BadRequest();
    // }

    // private bool ValidatePerson(Person? person)
    // {
    //     if (person is null)
    //         return false;

    //     if (string.IsNullOrEmpty(person.Name))
    //         return false;

    //     if (string.IsNullOrEmpty(person.Address1))
    //         return false;

    //     return true;
    // }

    //// 1 — We are not returning to the client the validation problems
    //// 2 — There is a big chance of duplicating the validation code in other methods.
    //// 3 — There is no separation of concerns.
    //// 4 — The errors will be reported one by one to the caller and not at the same time

    [HttpPost]
    public ActionResult Post(Person person)
    {
        // comment 47-50 for Action Filters validations
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(person);
    }
}
