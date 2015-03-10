using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;


namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act
            account.Debit(debitAmount);

            // assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        //método comprobando valores fuera de rango
        //unit test method
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act
            account.Debit(debitAmount);

            // assert is handled by ExpectedException
        }

        [TestMethod]
        public void TestMorosos()
        {
            // arrange
            double saldo = -100;
            double nomina = 500;         
            BankAccountMorosos m = new BankAccountMorosos(saldo, nomina, "Cualquiera");

            m.Restarnomina(saldo, nomina, "Cualquiera");
        }


    }
}
