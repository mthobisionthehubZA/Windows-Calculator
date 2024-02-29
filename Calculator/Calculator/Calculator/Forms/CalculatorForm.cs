using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        // button click method for numbers 0-9 or point
        private void button_click(object sender, EventArgs e)
        {
            // try catch exception handler to help the application from crashing
            try
            {
                if ((txtResults.Text) == "0" || (isOperationPerformed))
                {
                    txtResults.Clear(); // clears the 0 text holder when a is number entered
                }

                isOperationPerformed = false;

                Button button = (Button)sender; // obj of button
                if (button.Text == ".")
                {
                    if (!txtResults.Text.Contains("."))
                    {
                        txtResults.Text = txtResults.Text + button.Text; // changing text to button text to appear on the results
                    }
                }
                else
                {
                    txtResults.Text = txtResults.Text + button.Text; // changing text to button text to appear on the results
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        // this method is responsible for the calculations operators for  (*,/,-,+) buttons
        // Note these operators all share the same method (operator_click) to reduce number of click methods per button
        private void operator_click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender; // obj of button

                if (resultValue != 0)
                {
                    buttonEquals.PerformClick();
                    operationPerformed = button.Text;
                    labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                    isOperationPerformed = true;
                }
                else
                {
                    operationPerformed = button.Text;
                    resultValue = Double.Parse(txtResults.Text); // converting to decimal
                    labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                    isOperationPerformed = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }

        }

        // responsible for clearing entery
        private void buttonCE_Click(object sender, EventArgs e)
        {
            txtResults.Text = "0";
            resultValue = 0;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {

            try
            {
                switch (operationPerformed)
                {
                    case "+":

                        txtResults.Text = (resultValue + Double.Parse(txtResults.Text)).ToString();
                        break;

                    case "-":

                        txtResults.Text = (resultValue - Double.Parse(txtResults.Text)).ToString();
                        break;

                    case "*":

                        txtResults.Text = (resultValue * Double.Parse(txtResults.Text)).ToString();
                        break;

                    case "/":

                        txtResults.Text = (resultValue / Double.Parse(txtResults.Text)).ToString();
                        break;

                    default:
                        break;
                }
                resultValue = Double.Parse(txtResults.Text);
                labelCurrentOperation.Text = "";
            }
            catch (Exception)
            {

                throw;
            }

        }

        //keypress method to only allow digits in textbox
        private void txtResults_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar !='.')) 
            {
                e.Handled = true;   
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) 
            {
                e.Handled= true;
            }
        }
    }
}
