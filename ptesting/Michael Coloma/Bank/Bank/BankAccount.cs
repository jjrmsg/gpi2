/*///////////////////////////////////////////////////////////////////////////////////////////
 * 
Nota: No he creado la clase runner para realizar los test a las dos clases, ya que 
 * que nos servimos del mismo visual studio para poder realizar las pruebas a través de
 * su propias herramientas, en este caso tiene una pestaña "PRUEBA" donde seleccionaremos
 * ventanas--> ejecutar todas
 *Todas las pruebas superadas tendran un tick verde y las malas tendrán una x roja.
 * 
 * //////////////////////////////////////////////////////////////////////////////////////////
*/
using System;

namespace BankAccountNS
{
    public class BankAccount
    {
        private string m_customerName;

        private double m_balance;

        private bool m_frozen = false;

        private BankAccount()
        {
        }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }

            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance -= amount;
        }

        public void Credit(double amount)
        {
            if (m_frozen)
            {
                throw new Exception("Account frozen");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }

    }
}