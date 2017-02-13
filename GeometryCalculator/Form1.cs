using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometryCalculator
{
    public partial class Form1 : Form
    {
        string shape = "";
        string choice = "";
        string result = "";

        public Form1()
        {
            InitializeComponent();
            inputInitialize();

        }

        private void getShape(RadioButton rbtnShape)
        {
            MessageBox.Show(rbtnShape.Text);
        }

        private void getChoice(RadioButton rbtnChoice)
        {
            MessageBox.Show(rbtnChoice.Text);
        }

        private void inputInitialize()
        {
            txtInput1.Visible = false;
            txtInput1.Text = "";
            txtInput2.Visible = false;
            txtInput2.Text = "";
            txtInput3.Visible = false;
            txtInput3.Text = "";
            txtInput4.Visible = false;
            txtInput4.Text = "";
            lblInput1.Visible = false;
            lblInput2.Visible = false;
            lblInput3.Visible = false;
            lblInput4.Visible = false;
            lblArea.Visible = false;
            btnCalculate.Text = "Calculate";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnTriangle_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("blah");
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("blah2");
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //first method to get shape selection from shape group of radio buttons
            inputInitialize();
            
            if (((RadioButton)sender).Checked)
                shape =(((RadioButton)sender).Text);
        }
        private void radioButton_CheckedChanged2(object sender, EventArgs e)
        {
            //second method, assigned to radio buttons in the choice group
            inputInitialize();

            if (((RadioButton)sender).Checked)
                choice = (((RadioButton)sender).Text);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /* 
             * There's probably a better way to do this, but a case for each
             * combination of shape and choice. within each case is a check whether the
             * calculate button is in calculate or answer mode.             
             */

            //<Squares>
            if (shape == "Square" && choice == "Area")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Width?";
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)))
                    {
                        result += "Area: ";
                        result += Convert.ToString(rectangleArea(input, input));
                        //MessageBox.Show(Convert.ToString(rectangleArea(input, input)));
                        lblArea.Visible = true;
                        lblArea.Text = result;
                    }
                    else
                    {
                        MessageBox.Show("Please verify valid value entered");
                    }
                }
            }
            else if (shape == "Square" && choice == "Perimeter")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Width?";
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)))
                    {
                        result += "Perimeter: ";
                        result += Convert.ToString(rectanglePerimeter(input, input));
                        //MessageBox.Show(Convert.ToString(rectangleArea(input, input)));
                        lblArea.Visible = true;
                        lblArea.Text = result;
                    }
                    else
                    {
                        MessageBox.Show("Please verify valid value entered");
                    }
                }

            }
            else if (shape == "Square" && choice == "Area and Perimeter")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Width?";
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)))
                    {
                        result += "Area: ";
                        result += Convert.ToString(rectangleArea(input, input));
                        result += "\n";
                        result += "Perimeter: ";
                        result += Convert.ToString(rectanglePerimeter(input, input));
                        lblArea.Visible = true;
                        lblArea.Text = result;
                    }
                    else
                    {
                        MessageBox.Show("Please verify valid value entered");
                    }
                }

            }
            //</Squares>

            //<Rectangles>
            //</Rectangles>

            //<Circles>

            else if (shape == "Circle" && choice == "Area")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Radius?";
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)))
                    {
                        result += "Area: ";
                        result += Convert.ToString(circleArea(input));
                        lblArea.Visible = true;
                        lblArea.Text = result;
                    }
                    else
                    {
                        MessageBox.Show("Please verify valid value entered");
                    }
                }
            }
            else if (shape == "Circle" && choice == "Perimeter")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Radius?";
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)))
                    {
                        result += "Perimeter: ";
                        result += Convert.ToString(circlePerimeter(input));
                        lblArea.Visible = true;
                        lblArea.Text = result;
                        //MessageBox.Show(result);
                    }
                    else
                    {
                        MessageBox.Show("Please verify valid value entered");
                    }
                }
            }
            else if (shape == "Circle" && choice == "Area and Perimeter")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Radius?";
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)))
                    {
                        result += "Area: ";
                        result += Convert.ToString(circleArea(input));
                        result += "\n";
                        result += "Perimeter: ";
                        result += Convert.ToString(circlePerimeter(input));
                        lblArea.Visible = true;
                        lblArea.Text = result;
                        //MessageBox.Show(result);
                    }
                    else
                    {
                        MessageBox.Show("Please verify valid value entered");
                    }
                }
            }

                //</Circles>


            }//closing brace for buttonCalculate click

        public decimal rectangleArea(decimal length, decimal width)
        {
            decimal calculation;
             calculation = length * width;
            return calculation;
        }
        public decimal rectanglePerimeter(decimal length, decimal width)
        {
            decimal calculation;
            calculation = (2 * length) + (2 * width);
            return calculation;
        }

        public decimal circleArea(decimal radius)
        {
            decimal calculation;
            calculation = Convert
                .ToDecimal(Math.PI * Math.Pow(Convert.ToDouble(radius), 2));
            return calculation;
        }

        public decimal circlePerimeter(decimal radius)
        {
            decimal calculation;
            calculation = Convert
                .ToDecimal(Math.PI * Convert.ToDouble(radius) * 2);
            return calculation;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inputInitialize();
        }
    }
}
