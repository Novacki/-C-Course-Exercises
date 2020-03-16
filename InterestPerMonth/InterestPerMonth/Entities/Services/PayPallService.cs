using System;
using System.Collections.Generic;
using System.Text;

namespace InterestPerMonth.Entities.Services
{
    public abstract class PayPallService : IPaymentService
    {
        public abstract void InterestValue(double installments);
       
    }
}
