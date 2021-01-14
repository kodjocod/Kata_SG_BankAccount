using System;
using System.Collections.Generic;

namespace KataBank
{
    internal class AcountHistory
    {
         public List<string> GetOperations(List<OperationData> operations, int totalBalance)
        {
            List<string> operationsHistory = new List<string>();
            foreach (var operationData in operations)
            {
                operationsHistory.Add(String.Format("{0}: {1}e on {2}, balance: {3}e", operationData.OperationType,operationData.Amount,operationData.OperationDate.ToString("MM/dd/yyyy"), totalBalance));
            }
           
            return operationsHistory;
        }
    }
}