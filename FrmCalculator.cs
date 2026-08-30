using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        private CalculatorClass cal; 
        private Formula<double>? activeHandler; 
        private double num1, num2; 

        public FrmCalculator()
        {
            InitializeComponent();

            List<string> operators = new List<string> { "+", "-", "*", "/" };
            cbOperator.Items.AddRange(operators.ToArray()); //convert List to Array

            cbOperator.SelectedIndex = 0; 
            cal = new CalculatorClass(); 
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {  //input validations
            if (string.IsNullOrWhiteSpace(txtBoxInput1.Text) || string.IsNullOrWhiteSpace(txtBoxInput2.Text))
            {
                MessageBox.Show("Please fill in both fields.", "Missing Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbOperator.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an operator.", "Missing Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtBoxInput1.Text, out num1))
            {
                MessageBox.Show("Please enter a numeric value.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtBoxInput2.Text, out num2))
            {
                MessageBox.Show("Please enter a numeric value.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (activeHandler != null)
                cal.CalculateEvent -= activeHandler; 

            switch (cbOperator.Text)
            {
                case "+":
                    activeHandler = cal.GetSum;
                    break;
                case "-":
                    activeHandler = cal.GetDifference;
                    break;
                case "*":
                    activeHandler = cal.GetProduct;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.", "Math Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    activeHandler = cal.GetQuotient; 
                    break;
                default:
                    MessageBox.Show("Please select a valid operator.", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            cal.CalculateEvent += activeHandler; 

            double total = cal.Calculate(num1, num2); //total computation

            bool hasDecimal = txtBoxInput1.Text.Contains(".") || txtBoxInput2.Text.Contains("."); //checking if input have decimal

            string result = hasDecimal ? total.ToString("F3") : total.ToString("0"); //Ternary Operator,  if input has decimal then answer has decimal limit to 3 decimal else 0 decimal
            lblDisplayTotal.Text = result; //display total
        }
    }
}