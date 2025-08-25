using Microsoft.AspNetCore.Mvc;
using MyBank.Data;
using MyBank.Models;

namespace MyBank.Controllers.User_Controllers
{
    [ApiController]
    
    public class SignUpController : ControllerBase
    {
        [HttpPost("v1/signup")]
         public async Task<IActionResult> SignUp(
            [FromServices]MyBankDataContext context, 
            [FromBody] Client model)
         {

            await context.Clients.AddAsync(model);
            await context.SaveChangesAsync();

            return Created($"v1/signup/{model.Id}", model);

         }

    }
}
