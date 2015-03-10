using System;

namespace Bank
{
   public class BankAccountMorosos
    {
        double saldo,nomina;
        String moroso;
       

         public BankAccountMorosos(double saldo,double nomina, String moroso)
        {
             this.saldo=saldo;
             this.nomina = nomina;
             this.moroso=moroso;
        }

    
        public int saldoDeudor( double saldo)
         {
        
            if (saldo < 0){
                return 0;
            }
            else{
                return 1;
            }
          
         }
        public void Restarnomina(double saldo, double nomina, String moroso)
        {
            if (saldoDeudor(saldo)==0)
            {
                if (nomina*2>saldo*-1)
                {
                    nomina = nomina - (saldo * -1 * 0.5);
                }
            }
        }


    }
}
