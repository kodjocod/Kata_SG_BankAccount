using System;
using System.Collections.Generic;

namespace KataBank
{
    public class BankServices
    {
        private readonly List<OperationData> transactions;

        public BankServices(List<OperationData> operations)
        {
            this.transactions = operations;
        }

        public void MakeDeposit(OperationData operationData)
        {
            this.transactions.Add(operationData);
        }

        public void MakeWithDrawal(OperationData operationData)
        {
            this.transactions.Add(operationData);
        }
    }
}
