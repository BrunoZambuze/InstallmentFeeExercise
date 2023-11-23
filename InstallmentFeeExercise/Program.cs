using System;
using System.Globalization;
using InstallmentFeeExercise.Domain;
using InstallmentFeeExercise.Services;
namespace InstallmentFeeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Enter Contract Data--");
            Console.Write("Number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/mm/yyyy):");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: R$");
            double value = double.Parse(Console.ReadLine());
            Contract contract = new Contract(number, date, value);
            Console.Write("Enter number of installments:");
            int n = int.Parse(Console.ReadLine());
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, n);
            Console.WriteLine("\nInstallments:");
            foreach (Installment installment in contract.ListInstallment)
            {
                Console.WriteLine(installment);
            }
        }
    }
}