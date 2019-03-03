using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This is the definition of the customer class. 
/// 
/// Purpose: To be the base object that will calculate the charge for the customer.
/// </summary>

namespace City_Power
{
    public class customer
    {
        public string CustomerName; //property of a customer (public field)
        public int AccountNumber;   //property of a customer (public field)
        public char CustomerType;   //property of a customer (public field)
        public decimal ChargeAmount; //property of a customer (public field)

        public customer() { }  // constructor to create a customer

        public customer(string customerName,
                        int accountNumber,
                        char customerType,
                        decimal chargeAmount)
        {
            this.CustomerName = customerName;
            this.AccountNumber = accountNumber;
            this.CustomerType = customerType;
            this.ChargeAmount = chargeAmount;

        }

        private decimal calculateCharge()
        {
            ChargeAmount = flatRate + 


            return ChargeAmount;
        }  // no body meant to be overidden

        public override string ToString()
        {
            return CustomerName + " owes" + calculateCharge().ToString("f2");
        }

    }
}
