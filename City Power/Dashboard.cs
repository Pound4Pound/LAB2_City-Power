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
///     Lab #: 2
///     
///     The start of an account page that calculates a customer's bill according to their account type
/// </summary>

namespace City_Power
{
    public partial class frmCityPower : Form
    {
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

            try
            {
                if (IsPresent(txtKilowatthours, "kWh") && // check to see that a value was entered into the form
                    IsDecimal(txtKilowatthours, "kWh") &&  // check to see that a number is entered into the field
                    IsNotNeg(txtKilowatthours, "kWh"))     // check to see if the number is zero or positive 
                {

                    //Event handler for calculation button
                    //new customer
                    Customer cust = new Customer
                    {
                        AccountNumber = Convert.ToInt32(txtCustAcctNo.Text),
                        CustomerName = txtCustName.ToString(),
                        ChargeAmount = Convert.ToDecimal(txtKilowatthours.Text)
                    //sets the amount of kWh used by the customer in the customer object

                    };

                    
                    if (radResidential.Checked)
                    {//set the cutomer type to residential to allow 
                     //instantiated customer to calculate charge at correct rate.
                     
                        cust.CustomerType = 'r';
                    }
    
                    if (radCommercial.Checked)
                    {//set the cutomer type to commercial to allow 
                     //instantiated customer to calculate charge at correct rate.
                        cust.CustomerType = 'c';
                    }
                    
                    if (radIndustrial.Checked)
                    {//set the cutomer type to industrial to allow 
                     //instantiated customer to calculate charge at correct rate.
                        cust.CustomerType = 'i';
                    }
                  
                    txtChargeTotal.Text = cust.CalculateCharge(cust.CustomerType, cust.ChargeAmount).ToString("c");

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



        //private void CalcOffPeak(out decimal flatRate, out decimal hourlyRate, out decimal total)
        //{//Calculation of industrial rate of charge at off peak rates
        //    flatRate = IndustrialOffPeakHoursFlatRate;
        //    hourlyRate = IndustrialOffPeakHoursHourlyRate;

        //    if (Convert.ToDecimal(txtKilowatthours.Text) <= 1000)
        //        total = flatRate;//base rate of calculation
        //    else
        //        total = flatRate + (Convert.ToDecimal(txtKilowatthours.Text) - 1000) * hourlyRate; //calculation of energy over the base charge of power.

        //    txtChargeTotal.Text = total.ToString("c");
        //}



        private void btnClear_Click(object sender, EventArgs e)
        {

            txtPeak.Text = "0";
            txtOffPeak.Text = "0";
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

        private void ckBxPeakHours_CheckedChanged(object sender, EventArgs e)
        {
            bool check = txtPeak.Visible;

            if (check != true)
                txtPeak.Visible = true;
            else
                txtPeak.Visible = false;
        }

        private void ckBxOffPeak_CheckedChanged(object sender, EventArgs e)
        {
            bool check = txtOffPeak.Visible;

                if (check != true)
                txtOffPeak.Visible = true;
                else
                txtOffPeak.Visible = false;
             //   txtOffPeak.Clear();
            
                
            
        }

        private void txtIndustrialSubTotal_TextChanged(object sender, EventArgs e)
        {

            if (radIndustrial.Checked)
            {

                int subTotal;

                subTotal = Convert.ToInt32(txtPeak.Text);
                subTotal += Convert.ToInt32(txtOffPeak.Text);

                txtIndustrialSubTotal.Text = Convert.ToString(subTotal);
                txtKilowatthours.Text = txtIndustrialSubTotal.Text;
            }
        }

        private void txtPeak_TextChanged(object sender, EventArgs e)
        {
            int subTotal;
            try
            {
                if (IsPresent(txtKilowatthours, "kWh") && // check to see that a value was entered into the form
                    IsDecimal(txtKilowatthours, "kWh") &&  // check to see that a number is entered into the field
                    IsNotNeg(txtKilowatthours, "kWh"))     // check to see if the number is zero or positive 
                {
                    subTotal = Convert.ToInt32(txtPeak.Text);
                    subTotal += Convert.ToInt32(txtOffPeak.Text);

                    txtIndustrialSubTotal.Text = Convert.ToString(subTotal);
                }
            }

            catch (Exception ex)
            {//Exception catch for any unforseen errors.
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        private void txtOffPeak_TextChanged(object sender, EventArgs e)
        {
            int subTotal;


            try
            {
                if (IsPresent(txtKilowatthours, "kWh") && // check to see that a value was entered into the form
                    IsDecimal(txtKilowatthours, "kWh") &&  // check to see that a number is entered into the field
                    IsNotNeg(txtKilowatthours, "kWh"))     // check to see if the number is zero or positive 
                {
                    subTotal = Convert.ToInt32(txtPeak.Text);
                    subTotal += Convert.ToInt32(txtOffPeak.Text);

                    txtIndustrialSubTotal.Text = Convert.ToString(subTotal);
                }
            }
            catch (Exception ex)
            {//Exception catch for any unforseen errors.
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }


    }
}
