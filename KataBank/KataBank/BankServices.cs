using System;
using System.Collections.Generic;

namespace KataBank
{
    public class BankServices
    {
        private readonly Transaction transaction;
        private readonly AcountHistory acountHistory;
        public BankServices(List<OperationData> operations)
        {
            transaction = new Transaction(operations);
            acountHistory = new AcountHistory();
        }

        public void MakeDeposit(OperationData operationData)
        {
            this.transaction.Add(operationData);
        }

        public void MakeWithDrawal(OperationData operationData)
        {
            this.transaction.Add(operationData);
        }
        public List<string> GetOperationHistory(List<OperationData> operations)
        {
            int totalBalance = transaction.ComputeAccountBalance(operations);
            
            return acountHistory.GetOperations(operations, totalBalance);
        }
    }
}
