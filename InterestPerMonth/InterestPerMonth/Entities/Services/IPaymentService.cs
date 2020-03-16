using System;
using System.Collections.Generic;
using System.Text;

namespace InterestPerMonth.Entities.Services
{
    public interface IPaymentService
    {
        public void InterestValue(double installments);
    }
}
