using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///     Title: Cost calculator for a City Power Company
///     Date: Feb 2019
///     
///     Author: Colin Lee-Chee
///     Class: CPRG 200 - Rapid Application Development
///     Lab #: 1
///     
///     The start of an account page that calculates a customer's bill according to their account type
/// </summary>

namespace City_Power
{
    public partial class frmCityPower : Form
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

        

        public frmCityPower()
        {
            InitializeComponent();
            
        }

        //button exits program and closes form
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Function to close application

            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
          //Event handler for calculation button

            decimal flatRate = 0;
            decimal hourlyRate = 0;
            string customerType = "r";

         //Data validation call

            try
            {
                if (IsPresent(txtKilowatthours, "kWh")  && // check to see that a value was entered into the form
                    IsDecimal(txtKilowatthours, "kWh") &&  // check to see that a number is entered into the field
                    IsNotNeg(txtKilowatthours, "kWh"))     // check to see if the number is zero or positive 
                {

                    if (radResidential.Checked)
                    {//set residential rate off of radio button
                        customerType = "r";
                    }

                    if (radCommercial.Checked)
                    {//set commercial rate off of radio button
                        customerType = "c";

                    }

                    //set industrial rate off of radio button
                    if (radIndustrial.Checked)
                    {
                        customerType = "i";
                    }



                    switch (customerType)
                    {//calculate residential rate
                        case "r":
                            decimal total;
                            CalcResidential(out flatRate, out hourlyRate);

                            break;

                        //calculate commercial rate
                        case "c":
                            CalcCommercial(out flatRate, out hourlyRate, out total);

                            break;
                        case "i":
                       // calculater industrial rate
                            if (radOffPeakHours.Checked) // check what type of charge is made depending on time of day
                                 //Calculate Industrial rate of charge during off peak hours.
                                CalcOffPeak(out flatRate, out hourlyRate, out total);

                            //Calculate Industrial rate of charge during peak hours.
                            if (radPeakHours.Checked)
                                CalcPeak(out flatRate, out hourlyRate, out total);

                            break;

                    }
                }
            }

            catch (Exception ex)
            {//Exception catch for any unforseen errors.
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        public bool IsPresent(TextBox textBox, string name)
        {//Check to see if the text field is empty.
            if (txtKilowatthours.Text == "")
            {
                MessageBox.Show("Number of kWh needs to be entered", "Entry Error");
                txtKilowatthours.Focus();

                return false;
            }
            else
                return true;
        }

        public bool IsDecimal(TextBox textbox, string name)
        {//data check to see if the entry is a number
            decimal number = 0m;
            if (Decimal.TryParse(txtKilowatthours.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Number of kWh needs to be entered as decimal value", "Entry Error");
                txtKilowatthours.Focus();
                return false;
            }  
        }

        public bool IsNotNeg(TextBox textbox, string name)
        {//data check to see if the entry is a positive number
            decimal number = Convert.ToDecimal(txtKilowatthours.Text);
            if (number < 0)
            {
                MessageBox.Show("Value can not be negative.", "Entry Error");
                textbox.Focus();
                return false;
            }
            return true;


        }

        private void CalcPeak(out decimal flatRate, out decimal hourlyRate, out decimal total)
        {//Calculation of industrial rate of charge at peak rates
            
            flatRate = IndustrialPeakHoursFlatRate;
            hourlyRate = IndustrialPeakHoursHourlyRate;

            if (Convert.ToDecimal(txtKilowatthours.Text) <= 1000)  //check to see if the client used more than the minimum alloted rate 
            {//base rate of calculation
                total = flatRate;
                txtChargeTotal.Text = total.ToString("c");
            }
            else
            //calculation of energy over the base charge of power.
                total = flatRate + (Convert.ToDecimal(txtKilowatthours.Text) - 1000) * hourlyRate;
           

            
            txtChargeTotal.Text = total.ToString("c");

        }

        private void CalcOffPeak(out decimal flatRate, out decimal hourlyRate, out decimal total)
        {//Calculation of industrial rate of charge at off peak rates
            flatRate = IndustrialOffPeakHoursFlatRate;
            hourlyRate = IndustrialOffPeakHoursHourlyRate;

            if (Convert.ToDecimal(txtKilowatthours.Text) <= 1000)
                total = flatRate;//base rate of calculation
            else
                total = flatRate + (Convert.ToDecimal(txtKilowatthours.Text) - 1000) * hourlyRate; //calculation of energy over the base charge of power.

            txtChargeTotal.Text = total.ToString("c");
        }

        private void CalcCommercial(out decimal flatRate, out decimal hourlyRate, out decimal total)
        {
            flatRate = CommercialFlatRate;
            hourlyRate = CommercialHourlyRate;

            //checks amount entered into kWh 
            if (Convert.ToDecimal(txtKilowatthours.Text) <= 1000)
            {//charges flat rate if less than the minimum number of kWh
                total = flatRate;
                txtChargeTotal.Text = total.ToString("c");
            }
            else
            {//charge of bill is flat rate plus excess amount 
                total = flatRate + (Convert.ToDecimal(txtKilowatthours.Text) - 1000) * hourlyRate;
                txtChargeTotal.Text = total.ToString("c");
            }
        }

        private void CalcResidential(out decimal flatRate, out decimal hourlyRate)
        {//Calculation of residential charges.
            flatRate = ResidentialFlatRate;
            hourlyRate = ResidentialHourlyRate;
            decimal total = flatRate + Convert.ToDecimal(txtKilowatthours.Text) * hourlyRate;

            txtChargeTotal.Text = total.ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKilowatthours.Clear();
            txtKilowatthours.Focus();
            txtChargeTotal.Clear();
        }

        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {//radio button event handler hiding industrial charges if not selected
            gbxSelectedChargeTime.Visible = false;
        }

        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {//radio button event handler showing industrial charges if selected
            gbxSelectedChargeTime.Visible = true;
         
        }
        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {//radio button event handler hiding industrial charges if not selected
            gbxSelectedChargeTime.Visible = false;
        }

    }
}
