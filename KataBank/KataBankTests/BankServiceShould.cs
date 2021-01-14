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
            List<Amount> operations = new List<Amount>();
            BankServices bankservices = new BankServices(operations);
            bankservices.MakeDeposit(new Amount(50));
            List<Amount> expectedOperations = new List<Amount>();
            expectedOperations.Add(new Amount(50));
           Check.That(operations).HasFieldsWithSameValues(expectedOperations);
          
        }
        [Test]
        public void Make_several_deposit_when_client_want_to_put_money_into_his_account()
        {
            List<Amount> operations = new List<Amount>();
            BankServices bankservices = new BankServices(operations);

            bankservices.MakeDeposit(new Amount(50));
            bankservices.MakeDeposit(new Amount(80));
            bankservices.MakeDeposit(new Amount(200));
            List<Amount> expectedOperations = new List<Amount>();
            expectedOperations.Add(new Amount(50));
            expectedOperations.Add(new Amount(80));
            expectedOperations.Add(new Amount(200));

            Check.That(operations).HasFieldsWithSameValues(expectedOperations);

        }
    }
}