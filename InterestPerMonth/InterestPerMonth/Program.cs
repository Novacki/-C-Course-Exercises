using InterestPerMonth.Entities;
using System;
using System.Globalization;

namespace InterestPerMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Contract Data ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/mm/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract Value: ");
            double totalValue = double.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, totalValue);

            Console.WriteLine("Enter numbers os installments");
            double installments = double.Parse(Console.ReadLine());

            contract.GenerateInstallment(installments);

            Console.WriteLine(contract);
            

            //REFAZER CRIANDO OS SERVIÇOS PARA CONTRATO E PARA PAGAMENTO COMO EXEMPLO
        }
    }
}
