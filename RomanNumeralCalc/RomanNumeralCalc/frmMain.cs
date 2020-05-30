/*Author: Kenneth Lamb
 * Date: 03/22/2020
 * Program: RomanNumeralCalc
 * Purpose: To calculate roman numerals as well as to convert them to decimal and back
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RomanClassTest;

namespace RomanNumeralCalc
{
    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Set the focus on the txtRom1 text box
            txtRom1.Focus();
        }//End frmMain Load

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the application
            Application.Exit();
        }//End btnExit Click

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all of the text boxes
            txtRom1.Clear();
            txtRom2.Clear();
            txtResult.Clear();

            //Uncheck both of the radial buttons
            radSum.Checked = false;
            radDiff.Checked = false;

            //Set the calculate button to enables and disable the ToDec and ToRom buttons
            btnCalc.Enabled = true;
            btnToDec.Enabled = false;
            btnToRom.Enabled = false;

            //Set the focus back to the txtRom1 text box
            txtRom1.Focus();

        }//End btnClear Click

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Create two string vairables for both of the inputs
            string strRom1 = "";
            string strRom2 = "";

            //Set them to the appropriate text boxes
            strRom1 = txtRom1.Text;
            strRom2 = txtRom2.Text;

            //Here we will check to see if both input boxes have a value into them. If not throw an error
            if(strRom1 == "" && strRom2 == "")
            {
                MessageBox.Show("Error missing input, Please enter a roman character.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Set three instances of the RomanClass two of them set to the inputs from the user
                RomanClass roman1 = new RomanClass(strRom1);
                RomanClass roman2 = new RomanClass(strRom2);
                RomanClass roman3 = new RomanClass();

                //Check to make sure both of the inputs from the user are valid Roman Numerals
                if (roman1.IsValidRomanNum(strRom1) == true && roman2.IsValidRomanNum(strRom2) == true)
                {
                    //If the radial button sum is checked do the following addition calculations.
                    if(radSum.Checked == true)
                    {
                        //Set roman 3 to equal roman1 + roman2
                        roman3 = roman1 + roman2;
                        //Set the result to equal roman3
                        txtResult.Text = roman3.ToString();

                        //Enable ToDec and disable the calculation button
                        btnCalc.Enabled = false;
                        btnToDec.Enabled = true;
                    }
                    //Else if the radial button difference is checkeck do the subtraction below
                    else if(radDiff.Checked == true)
                    {
                        //Set roman 3 to equal roman1 - an
                        roman3 = roman1 - roman2;
                        //Set the result to equal roman3
                        txtResult.Text = roman3.ToString();

                        //Enable ToDec and disable the calculation button
                        btnCalc.Enabled = false;
                        btnToDec.Enabled = true;
                    }
                }
                else
                {
                    //If not throw and error and clear the text boxes setting the focus back to txtRom1
                    MessageBox.Show("IC is not valid.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRom1.Clear();
                    txtRom2.Clear();
                    txtRom1.Focus();
                }
                
            }
        }//End btnCalc Click

        private void btnToDec_Click(object sender, EventArgs e)
        {
            //Set the strings to equal nothing
            string strRom1 = "";
            string strRom2 = "";
            string strRom3 = "";

            //Set the strings to equal the text boxes on the form
            strRom1 = txtRom1.Text;
            strRom2 = txtRom2.Text;
            strRom3 = txtResult.Text;

            //Set instances of the Roman CLass set to the strings provided
            RomanClass roman1 = new RomanClass(strRom1);
            RomanClass roman2 = new RomanClass(strRom2);
            RomanClass roman3 = new RomanClass(strRom3);

            //Convert the strings provided to the classes to Decimal and set them to the text boxes
            txtRom1.Text = roman1.ConvertToDecimal().ToString();
            txtRom2.Text = roman2.ConvertToDecimal().ToString();
            txtResult.Text = roman3.ConvertToDecimal().ToString();

            //Enable ToRom and disable ToDec
            btnToDec.Enabled = false;
            btnToRom.Enabled = true;
        }//Ent btnToDec Click

        private void btnToRom_Click(object sender, EventArgs e)
        {
           
            //Set the integers that will hold the conversion
            int intRom1 = 0;
            int intRom2 = 0;
            int intRom3 = 0;

            //Set the instances of the class
            RomanClass roman1 = new RomanClass();
            RomanClass roman2 = new RomanClass();
            RomanClass roman3 = new RomanClass();

            //set the integers to equal the input from the text boxes on the form
            //No need to error check as they will always be integers
            intRom1 = Convert.ToInt32(txtRom1.Text);
            intRom2 = Convert.ToInt32(txtRom2.Text);
            intRom3 = Convert.ToInt32(txtResult.Text);

            //Set the text boxes to equal the roman conversion of each of the instances of the classes
            txtRom1.Text = roman1.SetString(intRom1);
            txtRom2.Text = roman2.SetString(intRom2);
            txtResult.Text = roman3.SetString(intRom3);

            //Enable ToDec and disable ToRom
            btnToDec.Enabled = true;
            btnToRom.Enabled = false;
        }//End btnToRom Click
    }
}
