using System;
using System.Collections.Generic;
using System.Linq;

namespace KataBank
{
    class Transaction : ITransaction
    {
        private List<OperationData> operationDatas;
        public Transaction(List<OperationData>incomingOperations)
        {
            this.operationDatas = incomingOperations;
        }

         public void Add(OperationData operation)
        {
            this.operationDatas.Add(operation);
        }

        public int ComputeAccountBalance(List<OperationData> transactions)
        {
            return transactions.Sum(item => item.Amount);
        }
    }
}
