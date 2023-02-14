using Ludo.Payments.API.Models;
using Ludo.Payments.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ludo.Payments.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        [HttpPost]
        public async Task<IActionResult> Post(PaymentInfoInputModel paymentInfo )
        {
            var result = await _paymentService.ProcessPayment( paymentInfo );

            if(!result) return BadRequest();

            return NoContent();
        }
    }
}
