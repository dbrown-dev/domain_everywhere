using Invoice.Service.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Invoice.Service.CreateInvoice
{
    [ApiController]
    [Route("[controller]")]
    public class CreateInvoiceController : ControllerBase
    {
        private readonly ICommandBus _commandBus;

        public CreateInvoiceController(ICommandBus commandBus) => _commandBus = commandBus;

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> OnPostAsync()
        {
            var result =  await _commandBus.Send(new CreateInvoiceCommand("David's Invoice", "REF#1234567"));

            return result.IsSuccess
                ? CreatedAtRoute("RouteName", result.Payload)
                : ValidationProblem(result.FailureReason);
        }
    }
}
