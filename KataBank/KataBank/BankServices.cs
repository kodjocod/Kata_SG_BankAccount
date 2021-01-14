using System.Collections.Generic;

namespace KataBank
{
    public class BankServices
    {
        private List<Amount> operations;

        public BankServices(List<Amount> operations)
        {
            this.operations = operations;
        }

        public void MakeDeposit(Amount amount)
        {
            this.operations.Add(amount);
        }
    }
}
