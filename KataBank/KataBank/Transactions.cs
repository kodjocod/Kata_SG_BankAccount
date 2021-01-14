using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
