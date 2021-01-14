using System;

namespace KataBank
{
    public class OperationData
    {
        public string OperationType { get; set; }
        public int Amount { get;  set; }
        public DateTime OperationDate { get;  set; }

        public OperationData(string operationType, int amount, DateTime operationDate)
        {
            this.OperationType = operationType;
            this.Amount = amount;
            this.OperationDate = operationDate;
        }

        public OperationData(string operationType, int amount)
        {
            this.OperationType = operationType;
            this.Amount = amount;
        }
    }
}
