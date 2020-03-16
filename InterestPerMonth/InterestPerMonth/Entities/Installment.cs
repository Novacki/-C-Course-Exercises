using System;
using InterestPerMonth.Entities.Services;


namespace InterestPerMonth.Entities
{
    class Installment : PayPallService
    {
        public DateTime DueDate {get; set;}
        public double Amount { get; private set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override void InterestValue(double installments)
        {
            Amount += Amount * 0.01 * installments;
            Amount += Amount * 0.02;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + " - " + Amount;
        }
    }
}
