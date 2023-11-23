using System;
using InstallmentFeeExercise.Domain;

namespace InstallmentFeeExercise.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService { get; set; }

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }
        public void ProcessContract(Contract contract, int months)
        {
            double value = contract.TotalValue / months;
            for (int i = 0; i < months; i++)
            {
                DateTime dateMonth = contract.Date.AddMonths(i);
                double update = value + _onlinePaymentService.Interest(value, i+1);
                double total = update + _onlinePaymentService.PaymentFee(update);
                contract.AddInstallment(new Installment(dateMonth, total));
            }
        }
    }
}
