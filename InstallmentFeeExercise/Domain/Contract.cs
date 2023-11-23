using System;
using System.Collections.Generic;

namespace InstallmentFeeExercise.Domain
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> ListInstallment { get; set; } = new List<Installment>();

        //Construtores
        public Contract()
        {
        }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public void AddInstallment(Installment installment)
        {
            ListInstallment.Add(installment);
        }
    }
}
