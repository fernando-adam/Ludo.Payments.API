using Ludo.Payments.API.Models;
using System.Security.Cryptography.X509Certificates;

namespace Ludo.Payments.API.Services
{
    public class PaymentService : IPaymentService
    {
        public Task<bool> ProcessPayment(PaymentInfoInputModel paymentInfo)
        {
            return Task.FromResult(true);
        }
    }
}
