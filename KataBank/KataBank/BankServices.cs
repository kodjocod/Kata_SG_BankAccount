using System;
using System.Collections.Generic;

namespace KataBank
{
    public class BankServices
    {
        private Transaction transactions;

        public BankServices(List<OperationData> operations)
        {
            transactions = new Transaction(operations);
            
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
