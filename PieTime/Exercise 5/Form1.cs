using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_5
{
    public partial class PieTime : Form
    {
        public PieTime()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //Declaring Variables
            decimal terms;
            decimal results = 1;
            

            //This tests the entry to confirm it is a number
            if (decimal.TryParse(NumberOfTermsTextBox.Text, out terms))

                // Here we start a loop that iterates over the count of the number entered
            for(decimal count = 0; count <= terms; count++)
                {
                    //This creates a multiplies the iteration by 2 then adds 3 creating 
                    // a series of incrementing odd numbers
                    decimal denominator = count * 2 + 3;
                    
                    //This tests if the iteration is even or odd
                    if (count % 2 == 0)
                    {
                        //then outputs a minus
                        results -= (1 / denominator);
                    }
                    else
                    {
                        //or a positive
                        results += (1 / denominator);
                    }
                }

            else
            {
                //this is a window that pops up if the entry is not a number
                MessageBox.Show("Please enter a valid number");
            }
            
            //this multiplies whatever the result is by 4 to get a precise pi reading
            results *= 4;

            //Now we conver the results to a string and display the message
            CalculateResult.Text = (" = " + results.ToString());

            //With a label that concatenates
            ApproximateValueResult.Text = ("Approximate value of pi after " + NumberOfTermsTextBox.Text + " Terms");

        }

        private void NumberOfTermsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApproximateValueResult_Click(object sender, EventArgs e)
        {
        }
    }
}
