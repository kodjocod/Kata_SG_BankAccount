using System;
using System.Collections.Generic;
using System.Text;

namespace KataBank
{
    interface ITransaction
    {
        void Add(OperationData operation);
    }
}
