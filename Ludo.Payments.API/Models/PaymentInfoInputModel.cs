﻿namespace Ludo.Payments.API.Models
{
    public class PaymentInfoInputModel
    {
        public int IdProject { get; set; }
        public string CreditCardNumber { get; set; }
        public string Cvv { get; set; }
        public string ExpiresAt { get; set; }
        public string CardName { get; set; }
        public decimal Amount { get; set; }
    }
}
