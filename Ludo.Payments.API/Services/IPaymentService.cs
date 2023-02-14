using Ludo.Payments.API.Models;

namespace Ludo.Payments.API.Services
{
    public interface IPaymentService
    {
        Task<bool> ProcessPayment(PaymentInfoInputModel paymentInfo);
    }
}
