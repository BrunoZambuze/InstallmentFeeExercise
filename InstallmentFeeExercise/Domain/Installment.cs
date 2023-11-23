using System;
namespace InstallmentFeeExercise.Domain
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        //Construtores
        public Installment()
        {
        }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
        public override string ToString()
        {
            return $"{DueDate.ToString("dd/MM/yyyy")} - {Amount:c}";
        }
    }
}
