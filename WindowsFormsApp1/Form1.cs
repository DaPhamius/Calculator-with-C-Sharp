using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double value = 0;
        String operation = "";
        bool operation_pressed = false;
        bool decimalUsed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e) // CE button
        {
            result.Text = "0";
        }

        private void button_Click(object sender, EventArgs e) // Numeric buttons + decimal
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();

            operation_pressed = false;

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void operator_click(object sender, EventArgs e) // operator buttons
        {

            Button b = (Button)sender;
            operation = b.Text;
            operation_pressed = true;
            value = double.Parse(result.Text, CultureInfo.InvariantCulture);
            decimalUsed = false;
            equation.Text = value + " " + operation;
        }

        private void EqualButton(object sender, EventArgs e) // Equal button
        {
            equation.Text = "";
            switch(operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "x":
                    result.Text = (value * Double.Parse(result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text, CultureInfo.InvariantCulture)).ToString();
                    break;
                default:
                    break;
            }
            if (result.Text.Contains("."))
            {
                decimalUsed = true;
            }
            else
                decimalUsed = false;
        }
    
        private void button18_Click(object sender, EventArgs e) //Clear button
        {
            result.Text = "0";
            equation.Text = "";
            value = 0;
        }

        private void button17_Click(object sender, EventArgs e) // Backspace button
        {
            //This code was too complicated and unnecessary:
            //int length = result.TextLength - 1;
            //string temptext = result.Text;
            //////result.Clear();
            //////for (int i = 0; i < length; i++)
            //////    result.Text = result.Text + text[i];

            result.Text = result.Text.Remove(result.TextLength - 1);
        }

        private void deciMal(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (!decimalUsed)
            { 
                result.Text = result.Text + b.Text;
                decimalUsed = true;
            }
        }
    }

}
