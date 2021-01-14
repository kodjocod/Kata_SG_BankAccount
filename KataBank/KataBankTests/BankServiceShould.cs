using KataBank;
using NFluent;
using NUnit.Framework;
using System;
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

            bankservices.MakeDeposit(new OperationData("DEPOSIT",50));

            List<OperationData> expectedOperations = new List<OperationData>
            {
                new OperationData("DEPOSIT", 50)
            };
            Check.That(transactions).HasFieldsWithSameValues(expectedOperations);
          
        }
        [Test]
        public void Make_several_deposit_when_client_want_to_put_money_into_his_account()
        {
            List<OperationData> transactions = new List<OperationData>();
            BankServices bankservices = new BankServices(transactions);

            bankservices.MakeDeposit(new OperationData("DEPOSIT",50));
            bankservices.MakeDeposit(new OperationData("DEPOSIT", 80));
            bankservices.MakeDeposit(new OperationData("DEPOSIT", 200));

            List<OperationData> expectedOperations = new List<OperationData>
            {
                new OperationData("DEPOSIT", 50),
                new OperationData("DEPOSIT", 80),
                new OperationData("DEPOSIT", 200)
            };

            Check.That(transactions).HasFieldsWithSameValues(expectedOperations);

        }
        [Test]
        public void Make_withdrawal_when_client_want_to_widthdraw_money_from_his_account()
        {
            List<OperationData> transactions = new List<OperationData>();
            BankServices bankservices = new BankServices(transactions);
            bankservices.MakeWithDrawal(new OperationData("WITHDRAWAL", 80));

            List<OperationData> expectedOperations = new List<OperationData>
            {
                new OperationData("WITHDRAWAL", 80)
            };

            Check.That(transactions).HasFieldsWithSameValues(expectedOperations);
        }
        [Test]
        public void Make_several_withdrawal_when_client_want_to_widthdraw_money_from_his_account()
        {
            List<OperationData> transactions = new List<OperationData>();
            BankServices bankservices = new BankServices(transactions);
            bankservices.MakeWithDrawal(new OperationData("WITHDRAWAL", 80));
            bankservices.MakeWithDrawal(new OperationData("WITHDRAWAL", 100));

            List<OperationData> expectedOperations = new List<OperationData>
            {
                new OperationData("WITHDRAWAL",80),
                new OperationData("WITHDRAWAL", 100)
            };

            Check.That(transactions).HasFieldsWithSameValues(expectedOperations);
        }

       [Test]
       public void Show_operations_history_to_the_client()
        {
            List<OperationData> transactions = new List<OperationData>();
            BankServices bankservices = new BankServices(transactions);
            bankservices.MakeDeposit(new OperationData("DEPOSIT", 300,new DateTime(2021,02,20)));
            bankservices.MakeWithDrawal(new OperationData("WITHDRAWAL", 80, new DateTime(2021, 02, 27)));
            bankservices.MakeWithDrawal(new OperationData("WITHDRAWAL", 45, new DateTime(2021, 03, 30)));

            List<string> expectedOperationHistory = new List<string>
            {
              "DEPOSIT: 300e on 02/20/2021, balance: 425e",
              "WITHDRAWAL: 80e on 02/27/2021, balance: 425e",
              "WITHDRAWAL: 45e on 03/30/2021, balance: 425e",

            };
            var operationHistory = bankservices.GetOperationHistory(transactions);
            Check.That(operationHistory).Equals(expectedOperationHistory);
        }
    }
}