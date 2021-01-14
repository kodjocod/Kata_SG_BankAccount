using KataBank;
using NFluent;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class BankServiceShould
    {
        [Test]
        public void Make_deposit_when_client_want_to_put_money_into_his_account()
        {
            List<OperationData> transactions = new List<OperationData>();
            BankServices bankservices = new BankServices(transactions);

            bankservices.MakeDeposit(new OperationData("DEPOSIT",new Amount(50)));

            List<OperationData> expectedOperations = new List<OperationData>
            {
                new OperationData("DEPOSIT", new Amount(50))
            };
            Check.That(transactions).HasFieldsWithSameValues(expectedOperations);
          
        }
        [Test]
        public void Make_several_deposit_when_client_want_to_put_money_into_his_account()
        {
            List<OperationData> transactions = new List<OperationData>();
            BankServices bankservices = new BankServices(transactions);

            bankservices.MakeDeposit(new OperationData("DEPOSIT",new Amount(50)));
            bankservices.MakeDeposit(new OperationData("DEPOSIT", new Amount(80)));
            bankservices.MakeDeposit(new OperationData("DEPOSIT", new Amount(200)));

            List<OperationData> expectedOperations = new List<OperationData>
            {
                new OperationData("DEPOSIT", new Amount(50)),
                new OperationData("DEPOSIT", new Amount(80)),
                new OperationData("DEPOSIT", new Amount(200))
            };

            Check.That(transactions).HasFieldsWithSameValues(expectedOperations);

        }
        [Test]
        public void Make_withdrawal_when_client_want_to_widthdraw_money_from_his_account()
        {
            List<OperationData> transactions = new List<OperationData>();
            BankServices bankservices = new BankServices(transactions);
            bankservices.MakeWithDrawal(new OperationData("WITHDRAWAL", new Amount(80)));

            List<OperationData> expectedOperations = new List<OperationData>
            {
                new OperationData("WITHDRAWAL", new Amount(80))
            };

            Check.That(transactions).HasFieldsWithSameValues(expectedOperations);
        }
    }
}