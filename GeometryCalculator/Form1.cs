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
        //test comment, testing new branch
        string shape = ""; //container for shape choice. 
        string choice = ""; //container for choice of area|perimeter|both
        string result = ""; //empty string for a concatenated return

        public Form1()
        {
            InitializeComponent();
            inputInitialize();

        }

        private void setUpInputs(string parms)
        {
            int i = 0;
            List<string> inputs = parms.Split(',').ToList();
            foreach (Control c in this.Controls)
            {
                if (c.Name == ("lblInput" + Convert.ToString(i + 1)))
                {
                    ((Label)c).Visible = true;
                    ((Label)c).Text = inputs.ElementAt(i);
                    btnCalculate.Text = "Answer";
                    
                }
                else if (c.Name == ("txtInput" + Convert.ToString(i+1)))
                {
                    ((TextBox)c).Visible = true;
                    i++;
                }
                if (i >= inputs.Count) { break; }
            }

        }

        private void inputInitialize()
        {
            // sets everything back to an initial state.
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                    ((TextBox)c).Visible = false;
                }
                if (c is Label)
                {
                    ((Label)c).Visible = false;
                }
            }
            lblArea.Visible = false;
            btnCalculate.Text = "Calculate";
            pbFormula.Image = null;
            pbShape.Image = null;

        }
        // our good old friend the exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //first method to get shape selection from shape group of radio buttons
            inputInitialize();
            
            if (((RadioButton)sender).Checked)
                shape =(((RadioButton)sender).Text);
            showShape();
            showFormulae();
        }
        private void radioButton_CheckedChanged2(object sender, EventArgs e)
        {
            //second method, assigned to radio buttons in the choice group
            inputInitialize();

            if (((RadioButton)sender).Checked)
                choice = (((RadioButton)sender).Text);
            showShape();
            showFormulae();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /* 
             * There's probably a better way to do this, but a case for each
             * combination of shape and choice. within each case is a check whether the
             * calculate button is in calculate or answer mode.
             * sections marked as <section></section>     
             */

            //<Squares>
            if (shape == "Square" && choice == "Area")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    setUpInputs("Width?");
                }
                else
                {
                    decimal input;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)))
                    {
                        result += "Area: ";
                        result += Convert.ToString(rectangleArea(input, input));
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
                    setUpInputs("Width?");
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
                    setUpInputs("Width?");
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
            else if (shape == "Rectangle" && choice == "Area")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    
                    setUpInputs("Length ?,Width ?");

                }
                else
                {
                    decimal input,input2;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)) && 
                        (Decimal.TryParse(txtInput2.Text, out input2)))
                    {
                        result += "Area: ";
                        result += Convert.ToString(rectangleArea(input,input2));
                        lblArea.Visible = true;
                        lblArea.Text = result;
                    }
                    else
                    {
                        MessageBox.Show("Please verify valid value entered");
                    }
                }
            }
            else if (shape == "Rectangle" && choice == "Perimeter")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    setUpInputs("Length ?,Width ?");
                }
                else
                {
                    decimal input,input2;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                        (Decimal.TryParse(txtInput2.Text, out input2)))
                    {
                        result += "Perimeter: ";
                        result += Convert.ToString(rectanglePerimeter(input,input2));
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
            else if (shape == "Rectangle" && choice == "Area and Perimeter")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    setUpInputs("Length ?,Width ?");
                }
                else
                {
                    decimal input,input2;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                        (Decimal.TryParse(txtInput2.Text, out input2)))
                    {
                        result += "Area: ";
                        result += Convert.ToString(rectangleArea(input, input2));
                        result += "\n";
                        result += "Perimeter: ";
                        result += Convert.ToString(rectanglePerimeter(input, input2));
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
            //</Rectangles>

            //<Circles>

            else if (shape == "Circle" && choice == "Area")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    setUpCircleInputs();
                    
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
                    setUpCircleInputs();
                }
                else
                {
                    decimal input;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)))
                    {
                        result += "Circumference: ";
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
                    setUpCircleInputs();
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
                        result += "Circumference: ";
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

            //<triangles>
            else if (shape == "Triangle" && choice == "Area")
            {
                pbShape.Visible = true;
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Base?";
                    lblInput2.Visible = true;
                    lblInput2.Text = "Height";
                    txtInput2.Visible = true;
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input, input2;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                        (Decimal.TryParse(txtInput2.Text, out input2)))
                    {
                        result += "Area: ";
                        result += Convert.ToString(triangleArea(input, input2));
                        lblArea.Visible = true;
                        lblArea.Text = result;
                    }
                    else
                    {
                        MessageBox.Show("Please verify valid value entered");
                    }
                }
            }
            else if (shape == "Triangle" && choice == "Perimeter")
            {
                pbShape.Visible = true;
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "SideA?";
                    lblInput2.Visible = true;
                    lblInput2.Text = "SideB?";
                    txtInput2.Visible = true;
                    lblInput3.Visible = true;
                    lblInput3.Text = "SideC?";
                    txtInput3.Visible = true;
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input, input2, input3;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                        (Decimal.TryParse(txtInput2.Text, out input2)) &&
                        (Decimal.TryParse(txtInput3.Text, out input3)))
                    {
                        result += "Perimeter: ";
                        result += Convert.ToString(trianglePerimeter(input, input2, input3));
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
            else if (shape == "Triangle" && choice == "Area and Perimeter")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "SideA?";
                    lblInput2.Visible = true;
                    lblInput2.Text = "Base?";
                    txtInput2.Visible = true;
                    lblInput3.Visible = true;
                    lblInput3.Text = "SideC?";
                    txtInput3.Visible = true;
                    lblInput4.Visible = true;
                    lblInput4.Text = "Height?";
                    txtInput4.Visible = true;
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input, input2,input3,input4;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                        (Decimal.TryParse(txtInput2.Text, out input2)) &&
                        (Decimal.TryParse(txtInput2.Text, out input3)) &&
                        (Decimal.TryParse(txtInput2.Text, out input4)))
                    {
                        result += "Area: ";
                        result += Convert.ToString(triangleArea(input2,input4));
                        result += "\n";
                        result += "Perimeter: ";
                        result += Convert.ToString(trianglePerimeter(input,input2,input3));
                        lblArea.Visible = true;
                        lblArea.Text = result;

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
            //</triangles>

            //<parallelograms>
            else if (shape == "Parallelogram" && choice == "Area")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Height?";
                    lblInput2.Visible = true;
                    lblInput2.Text = "Base?";
                    txtInput2.Visible = true;
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input, input2;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                        (Decimal.TryParse(txtInput2.Text, out input2)))
                    {
                        result += "Area: ";
                        result += Convert.ToString(parallelogramArea(input, input2));
                        lblArea.Visible = true;
                        lblArea.Text = result;
                    }
                    else
                    {
                        MessageBox.Show("Please verify valid value entered");
                    }
                }
            }
            else if (shape == "Parallelogram" && choice == "Perimeter")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Side A";
                    
                    lblInput2.Visible = true;
                    lblInput2.Text = "Side B";
                    txtInput2.Visible = true;
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input,input2;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                        (Decimal.TryParse(txtInput2.Text, out input2)))
                    {
                        result += "Perimeter: ";
                        result += Convert.ToString(parallelogramPerimeter(input, input2));
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
            else if (shape == "Parallelogram" && choice == "Area and Perimeter")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Base?";
                    lblInput2.Visible = true;
                    lblInput2.Text = "Side B";
                    txtInput2.Visible = true;
                    lblInput3.Visible = true;
                    lblInput3.Text = "Height?";
                    txtInput3.Visible = true;
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input, input2,input3;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                        (Decimal.TryParse(txtInput2.Text, out input2)) &&
                        (Decimal.TryParse(txtInput3.Text, out input3)))
                    {
                        result += "Area: ";
                        result += Convert.ToString(parallelogramArea(input, input3));
                        result += "\n";
                        result += "Perimeter: ";
                        result += Convert.ToString(parallelogramPerimeter(input, input2));
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
            //<parallelograms>

            //<rhombi>
            else if (shape == "Rhombus" && choice == "Area")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Height?";
                    lblInput2.Visible = true;
                    lblInput2.Text = "Base?";
                    txtInput2.Visible = true;
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input, input2;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                        (Decimal.TryParse(txtInput2.Text, out input2)))
                    {
                        result += "Area: ";
                        result += Convert.ToString(parallelogramArea(input, input2));
                        lblArea.Visible = true;
                        lblArea.Text = result;
                    }
                    else
                    {
                        MessageBox.Show("Please verify valid value entered");
                    }
                }
            }
            else if (shape == "Rhombus" && choice == "Perimeter")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Side A";
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)))
                    {
                        result += "Perimeter: ";
                        result += Convert.ToString(parallelogramPerimeter(input, input));
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
            else if (shape == "Rhombus" && choice == "Area and Perimeter")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Base?";
                    lblInput2.Visible = true;
                    lblInput2.Text = "Height?";
                    txtInput2.Visible = true;
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input,input2;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                        (Decimal.TryParse(txtInput2.Text, out input2)))
                    {
                        result += "Area: ";
                        result += Convert.ToString(parallelogramArea(input, input2));
                        result += "\n";
                        result += "Perimeter: ";
                        result += Convert.ToString(parallelogramPerimeter(input, input));
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
            //</rhombi>

            //<trapezoids>
            else if (shape == "Trapezoid" && choice == "Area")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Side A?";
                    lblInput2.Visible = true;
                    lblInput2.Text = "Segment B?";
                    txtInput2.Visible = true;
                    lblInput3.Visible = true;
                    lblInput3.Text = "Segment C";
                    txtInput3.Visible = true;
                    lblInput4.Visible = true;
                    lblInput4.Text = "Height?";
                    txtInput4.Visible = true;
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input, input2,input3,input4;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                        (Decimal.TryParse(txtInput2.Text, out input2))&&
                        (Decimal.TryParse(txtInput3.Text, out input3))&&
                        (Decimal.TryParse(txtInput4.Text, out input4)))
                    {
                        result += "Area: ";
                        result += Convert.ToString(trapezoidArea(input, input2,input3,input4));
                        lblArea.Visible = true;
                        lblArea.Text = result;
                    }
                    else
                    {
                        MessageBox.Show("Please verify valid value entered");
                    }
                }
            }
            else if (shape == "Trapezoid" && choice == "Perimeter")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Side A?";
                    lblInput2.Visible = true;
                    lblInput2.Text = "Segment B?";
                    txtInput2.Visible = true;
                    lblInput3.Visible = true;
                    lblInput3.Text = "Segment C";
                    txtInput3.Visible = true;
                    lblInput4.Visible = true;
                    lblInput4.Text = "Height?";
                    txtInput4.Visible = true;
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input,input2,input3,input4;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                        (Decimal.TryParse(txtInput2.Text, out input2)) &&
                        (Decimal.TryParse(txtInput3.Text, out input3)) &&
                        (Decimal.TryParse(txtInput4.Text, out input4)))
                    {
                        result += "Perimeter: ";
                        result += Convert.ToString(trapezoidPerimeter(input,input2,input3,input4));
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
            else if (shape == "Trapezoid" && choice == "Area and Perimeter")
            {
                if (btnCalculate.Text == "Calculate")
                {
                    lblInput1.Visible = true;
                    txtInput1.Visible = true;
                    lblInput1.Text = "Side A?";
                    lblInput2.Visible = true;
                    lblInput2.Text = "Segment B?";
                    txtInput2.Visible = true;
                    lblInput3.Visible = true;
                    lblInput3.Text = "Segment C";
                    txtInput3.Visible = true;
                    lblInput4.Visible = true;
                    lblInput4.Text = "Height?";
                    txtInput4.Visible = true;
                    btnCalculate.Text = "Answer";
                }
                else
                {
                    decimal input, input2,input3,input4;
                    result = "";
                    if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                        (Decimal.TryParse(txtInput2.Text, out input2)) &&
                        (Decimal.TryParse(txtInput3.Text, out input3)) &&
                        (Decimal.TryParse(txtInput4.Text, out input4)))
                    {
                        result += "Area: ";
                        result += Convert.ToString(trapezoidArea(input, input2,input3,input4));
                        result += "\n";
                        result += "Perimeter: ";
                        result += Convert.ToString(trapezoidPerimeter(input, input2,input3,input4));
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
            //</trapezoids>
            //<none shapes>
            else if (choice == "modulus" && btnCalculate.Text != "Calculate")
            { 
                decimal input, input2;
                result = "";
                if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                    (Decimal.TryParse(txtInput2.Text, out input2)))
                {
                    result += "Modulus result:\n";
                    result += Convert.ToString(modulusCalc(input, input2));
                    lblArea.Visible = true;
                    lblArea.Text = result;
                }
                else
                {
                    MessageBox.Show("Please verify valid value entered");
                }
            }
            else if (choice == "percentage" && btnCalculate.Text != "Calculate")
            {
                decimal input, input2;
                result = "";
                if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                    (Decimal.TryParse(txtInput2.Text, out input2)))
                {
                    result += "percentage result:\n";
                    result += Convert.ToString(percentageCalc(input, input2));
                    lblArea.Visible = true;
                    lblArea.Text = result;
                }
                else
                {
                    MessageBox.Show("Please verify valid value entered");
                }
            }
            else if (choice == "exponent" && btnCalculate.Text != "Calculate")
            {
                decimal input, input2;
                result = "";
                if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                    (Decimal.TryParse(txtInput2.Text, out input2)))
                {
                    result += "exponential result:\n";
                    result += Convert.ToString(exponentCalc(input, input2));
                    lblArea.Visible = true;
                    lblArea.Text = result;
                }
                else
                {
                    MessageBox.Show("Please verify valid value entered");
                }
            }

            //<none shapes>


        }//closing brace for buttonCalculate click

        //modulus, exponents, and percentage buttons
        private void btnModulus_Click(object sender, EventArgs e)
        {
            inputInitialize();
            choice = "modulus";
            btnCalculate.Text = "Answer";
            txtInput1.Visible = true;
            lblInput1.Visible = true;
            lblInput1.Text = "Numerator?";
            txtInput2.Visible = true;
            lblInput2.Visible = true;
            lblInput2.Text = "Denominator?";
            

        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            inputInitialize();
            choice = "percentage";
            btnCalculate.Text = "Answer";
            txtInput1.Visible = true;
            lblInput1.Visible = true;
            lblInput1.Text = "Whole?";
            txtInput2.Visible = true;
            lblInput2.Visible = true;
            lblInput2.Text = "Percent?";
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {
            inputInitialize();
            choice = "exponent";
            btnCalculate.Text = "Answer";
            txtInput1.Visible = true;
            lblInput1.Visible = true;
            lblInput1.Text = "Base?";
            txtInput2.Visible = true;
            lblInput2.Visible = true;
            lblInput2.Text = "Power?";
        }

        //Calculation methods, some reused for more than one shape
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

        public decimal trianglePerimeter(decimal sideA, decimal sideB,decimal sideC)
        {
            decimal calculation;
            calculation = sideA + sideB + sideC;
            return calculation;
        }
        public decimal triangleArea(decimal bottom, decimal height)
        {
            //can't use base as variable due to reserved words and all.
            //used "bottom" instead as well as in other formulae where appropriate
            decimal calculation;
            calculation = (bottom * height) / 2;
            return calculation;
        }
        public decimal parallelogramPerimeter(decimal sideA,decimal sideB)
        {
            decimal calculation;
            calculation = (sideA + sideB) * 2;
            return calculation;
        }
        public decimal parallelogramArea(decimal length, decimal width)
        {
            decimal calculation;
            calculation = length * width;
            return calculation;
        }
        public decimal trapezoidArea(decimal top, decimal bottom1, decimal bottom2, decimal height)//remember to check for which text boxes to pull from
        {
            decimal calculation;
            calculation = ((top + (bottom1 + bottom2)) / 2) * height;
            return calculation;
        }

        public decimal trapezoidPerimeter(decimal top, decimal bottom1, decimal bottom2, decimal height)
        {
            decimal calculation;
            decimal sideB = bottom1 + bottom2;
            decimal sideC = Convert.ToDecimal((Math.Sqrt(Convert.ToDouble((height * height) + (bottom1 - top)))));
            decimal sideD = (Convert.ToDecimal(Math.Sqrt(Convert.ToDouble((height * height) + (bottom2 * bottom2)))));
            calculation = top + sideB + sideC + sideD;
            return calculation;
        }

        private decimal percentageCalc(decimal whole, decimal percent)
        {
            decimal total = (whole * percent) / 100;
            return total;
        }

        private decimal modulusCalc(decimal numerator, decimal denominator)
        {
            decimal total = numerator % denominator;
            return total;
        }

        private decimal exponentCalc(decimal number, decimal exponent)
        {
            decimal total = Convert.ToDecimal(Math.Pow(Convert.ToDouble(number), Convert.ToDouble(exponent)));
            return total;
        }

        //end of the calculation functions
        private void btnClear_Click(object sender, EventArgs e)
        {
            inputInitialize();
        }

        private void setUpSquareInputs()
        {
            lblInput1.Visible = true;
            txtInput1.Visible = true;
            lblInput1.Text = "Width?";
            btnCalculate.Text = "Answer";
        }
        private void setUpRectangleInputs()
        {
            lblInput1.Visible = true;
            txtInput1.Visible = true;
            lblInput1.Text = "Length?";
            lblInput2.Visible = true;
            lblInput2.Text = "Width?";
            txtInput2.Visible = true;
            btnCalculate.Text = "Answer";
        }
        private void setUpCircleInputs()
        {
            lblInput1.Visible = true;
            txtInput1.Visible = true;
            lblInput1.Text = "Radius?";
            btnCalculate.Text = "Answer";
        }

       

        //<private void for shape images>
        private void showShape()
        {
            try
            {
                switch (shape)
                {
                    case "Triangle":
                        pbShape.Image = GeometryCalculator.Properties.Resources.imgTriangle;
                        break;
                    case "Rhombus":
                        pbShape.Image = GeometryCalculator.Properties.Resources.imgRhombus;
                        break;
                    case "Rectangle":
                        pbShape.Image = GeometryCalculator.Properties.Resources.imgRectangle;
                        break;
                    case "Circle":
                        pbShape.Image = GeometryCalculator.Properties.Resources.imgCircle;
                        break;
                    case "Square":
                        pbShape.Image = GeometryCalculator.Properties.Resources.imgSquare;
                        break;
                    case "Parallelogram":
                        pbShape.Image = GeometryCalculator.Properties.Resources.imgParallelogram;
                        break;
                    case "Trapezoid":
                        pbShape.Image = GeometryCalculator.Properties.Resources.imgTrapezoid;
                        break;

                }
            }
            catch
            {
                MessageBox.Show("No File");
            }
        }
        //</private void for shape images>

        //<private void for formula images>
        private void showFormulae()
        //picture box is one option, the other is switch to a label of the same size,
        //convert formulae to text, then for the both option concatenate the 
        //formulae to display with labels for which is which. 
        {
            try
            {
                switch (shape)
                {
                    case "Triangle":
                        if (choice == "Area")
                        {
                            pbFormula.Image = GeometryCalculator.Properties.Resources.triangleArea;
                        }
                        else if (choice == "Perimeter")
                        {
                            pbFormula.Image = GeometryCalculator.Properties.Resources.trianglePerimeter;
                        }
                        else
                        {
                            pbFormula.Image = null;
                            
                        }

                        break;
                    case "Rhombus":
                        if (choice == "Area")
                        {
                            pbFormula.Image = GeometryCalculator.Properties.Resources.rhombusArea;
                        }
                        else if (choice == "Perimeter")
                        {
                            pbFormula.Image = GeometryCalculator.Properties.Resources.rhombusPerimeter;
                        }
                        else
                        {
                            pbFormula.Image = null;
                            
                        }
                        break;
                    case "Rectangle":
                        if (choice == "Area")
                        {
                            pbFormula.Image = GeometryCalculator.Properties.Resources.rectArea;
                        }
                        else if (choice == "Perimeter")
                        {
                            pbFormula.Image = GeometryCalculator.Properties.Resources.rectPerimeter;
                        }
                        else
                        {
                            pbFormula.Image = null;
                            
                        }
                        break;
                    case "Circle":
                        if (choice == "Area")
                        {
                            pbFormula.Image = GeometryCalculator.Properties.Resources.circleArea;
                        }
                        else if (choice == "Perimeter")
                        {
                            pbFormula.Image = GeometryCalculator.Properties.Resources.circlePerimeter;
                        }
                        else
                        {
                            pbFormula.Image = null;
                            
                        }
                        break;
                    case "Square":
                        if (choice == "Area")
                        {
                            pbFormula.Image = GeometryCalculator.Properties.Resources.squareArea;
                        }
                        else if (choice == "Perimeter")
                        {
                            pbFormula.Image = GeometryCalculator.Properties.Resources.squarePerimeter;
                        }
                        else
                        {
                            pbFormula.Image = null;
                            
                        }
                        break;
                    case "Parallelogram":
                        if (choice == "Area")
                        {
                            pbFormula.Image = GeometryCalculator.Properties.Resources.parallelogramArea;
                        }
                        else if (choice == "Perimeter")
                        {
                            pbFormula.Image = GeometryCalculator.Properties.Resources.parallelogramPerimeter;
                        }
                        else
                        {
                            pbFormula.Image = null;
                            
                        }
                        break;
                    case "Trapezoid":
                        if (choice == "Area")
                        {
                            pbFormula.Image = GeometryCalculator.Properties.Resources.trapezoidArea;
                        }
                        else if (choice == "Perimeter")
                        {
                            pbFormula.Image = GeometryCalculator.Properties.Resources.trapezoidPerimeter;
                        }
                        else
                        {
                            pbFormula.Image = null;
                            
                        }
                        break;

                }
            }
            catch
            {
                MessageBox.Show("No File");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //</private void for formula images>

    }

}
