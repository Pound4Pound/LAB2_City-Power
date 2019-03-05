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
    public class Customer
    {
        //Declaration list for constant values used throuhgout the program. 
        //Data is centralized for ease of maintenance.
        const decimal ResidentialFlatRate = 6.00m;
        const decimal ResidentialHourlyRate = 0.052m;
        const decimal CommercialFlatRate = 60.00m;
        const decimal CommercialHourlyRate = 0.045m;
        const decimal IndustrialPeakHoursFlatRate = 76.00m;
        const decimal IndustrialPeakHoursHourlyRate = 0.065m;
        const decimal IndustrialOffPeakHoursFlatRate = 40.00m;
        const decimal IndustrialOffPeakHoursHourlyRate = 0.028m;


        public string _CustomerName; //property of a customer (public field)
        public int _AccountNumber;   //property of a customer (public field)
        public char _CustomerType;   //property of a customer (public field)
        public decimal _ChargeAmount; //property of a customer (public field)

        public Customer() { }  // constructor to create a customer

        public string CustomerName
        {
                get
            {
                return _CustomerName;
            }

                set
            {
                _CustomerName = value;
            }

        }   

        public int AccountNumber
        {
            get
            {
                return _AccountNumber;
            }

            set
            {
                _AccountNumber = value;  
            }

        }

        public char CustomerType
        {
            get
            {
                return _CustomerType;
            }
            set
            {
                _CustomerType = value;
            }
        }

        public decimal ChargeAmount
        {
            get
            {
                return _ChargeAmount;
            }

            set
            {
                _ChargeAmount = value;
            }
        }

      
        

        public decimal CalculateCharge(char _CustomerType, decimal _ChargeAmount)
        {
            decimal totalCharge;
            decimal flatRate = CommercialFlatRate;
            decimal hourlyRate = CommercialHourlyRate;

            switch (_CustomerType)
            {
                case 'r':
                    {
                        //Calculation of residential charges.

                        flatRate = ResidentialFlatRate;
                        hourlyRate = ResidentialHourlyRate;

                        totalCharge = flatRate + _ChargeAmount * hourlyRate;

                        return totalCharge;
                    }

                case 'c':

                    //checks amount entered into kWh 
                    if (ChargeAmount <= 1000)
                    {//charges flat rate if less than the minimum number of kWh

                        totalCharge = flatRate;

                        return totalCharge;
                    }
                    else
                    {//charge of bill is flat rate plus excess amount 
                        totalCharge = flatRate + (_ChargeAmount - 1000) * hourlyRate;

                        return totalCharge;
                    }

                case 'i':
                    {

                        //peak rate charge

                        flatRate = IndustrialPeakHoursFlatRate;
                        hourlyRate = IndustrialPeakHoursHourlyRate;

                        if (_ChargeAmount <= 1000)  //check to see if the client used more than the minimum alloted rate 
                        {//base rate of calculation
                            totalCharge = flatRate;

                            return totalCharge;
                        }
                        else
                        {
                            //calculation of energy over the base charge of power.
                            totalCharge = flatRate + (_ChargeAmount - 1000) * hourlyRate;

                            return totalCharge;
                        }


                        ////Calculation of industrial rate of charge at off peak rates
                        //flatRate = IndustrialOffPeakHoursFlatRate;
                        //hourlyRate = IndustrialOffPeakHoursHourlyRate;

                        //if (Convert.ToDecimal(txtKilowatthours.Text) <= 1000)
                        //    total = flatRate;//base rate of calculation
                        //else
                        //    total = flatRate + (Convert.ToDecimal(txtKilowatthours.Text) - 1000) * hourlyRate; //calculation of energy over the base charge of power.

                        //txtChargeTotal.Text = total.ToString("c");


                    }
                  
            }

            return totalCharge = -1;  //error of calculatecharge method call
        }

        //public override string ToString(decimal totalCharge)
        //{//method used to display results
        //    if (totalCharge != -1)
        //    {
        //        // return frmCityPower.ActiveForm.ToString(totalCharge) = Convert.ToString(totalCharge);
                
        //        //  return CustomerName + " owes" + CalculateCharge(this.CustomerType).ToString("f2");

        //    }
        //}

    }
}
