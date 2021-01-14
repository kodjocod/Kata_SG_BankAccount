namespace KataBank
{
    public class OperationData
    {
        private readonly string operationType;
        private readonly Amount amount;

        public OperationData(string operationType, Amount amount)
        {
            this.operationType = operationType;
            this.amount = amount;
        }
    }
}
