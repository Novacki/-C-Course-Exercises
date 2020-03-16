using InterestPerMonth.Entities.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterestPerMonth.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        private List<IPaymentService> _installment;
   

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            _installment = new List<IPaymentService>();
        }

        public void GenerateInstallment(double installment)
        {
            double resultInstallment = TotalValue / installment;

            for(int i = 0; i < installment; i++)
            {
                DateTime date = Date.AddMonths(i + 1);

                IPaymentService paymentInstallment = new Installment(date, resultInstallment);
                paymentInstallment.InterestValue(i + 1);

                AddInstallment(paymentInstallment);
            }
        }

        private void AddInstallment(IPaymentService installmentValue)
        {
            _installment.Add(installmentValue);
        }

        public override string ToString()
        {
            StringBuilder builderText = new StringBuilder();

            builderText.AppendLine("Installments");
            foreach(Installment ist in _installment)
            {
                builderText.AppendLine(ist.ToString());
            }

            return builderText.ToString();
        }
    }
}
