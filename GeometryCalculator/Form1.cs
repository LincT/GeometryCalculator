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
        //global variables for non-sequential passing of data that can't 
        //be efficiently stored in objects
        string shape = ""; //container for shape choice. 
        string choice = ""; //container for choice of area|perimeter|both
        string result = ""; //empty string for a concatenated return

        public Form1()
        {InitializeComponent();}

        private void setUpInputs(string parms)
        {
            int i = 1;//iterator, starts at 1 as named controls start w/ 1

            //make a list of what inputs are needed and what to label them
            List<string> inputs = parms.Split(',').ToList();

            SortedList<string, Control> formControls = new SortedList<string, Control> { };
            foreach (Control c in this.Controls)
            {
                //because calling a control directly by name apparently isn't a thing in C#?, 
                //populate a sorted list with controls to be referenced by name.
                formControls.Add(c.Name, c);
            }
            foreach (string myStr in inputs)
            { 
                formControls["lblInput" + Convert.ToString(i)].Visible = true;
                formControls["lblInput" + Convert.ToString(i)].Text = inputs.ElementAt(i - 1);
                formControls["txtInput" + Convert.ToString(i)].Visible = true;
                btnCalculate.Text = "Answer";
            i++;
            }
        }

        private void inputInitialize()
        {
            // sets everything to an initial default state.
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                    ((TextBox)c).Visible = false;
                }
                if (c is Label && c.Name!="lblCredits")
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
        {this.Close();}

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
             // within each case is a check whether the calculate button is in 
             // calculate or answer mode to control whether we're getting or processing data
            switch (shape)
            {
                case "Square":
                    if (choice == "Area")
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

                    else if (choice == "Perimeter")
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
                                lblArea.Visible = true;
                                lblArea.Text = result;
                            }
                            else
                            {
                                MessageBox.Show("Please verify valid value entered");
                            }
                        }
                    }
                    else if (choice == "Area and Perimeter")
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
                    break;
                case "Rectangle":
                    if (choice == "Area")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Length ?,Width ?");
                        }
                        else
                        {
                            decimal input, input2;
                            result = "";
                            if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                                (Decimal.TryParse(txtInput2.Text, out input2)))
                            {
                                result += "Area: ";
                                result += Convert.ToString(rectangleArea(input, input2));
                                lblArea.Visible = true;
                                lblArea.Text = result;
                            }
                            else
                            {
                                MessageBox.Show("Please verify valid value entered");
                            }
                        }
                    }
                    else if (choice == "Perimeter")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Length ?,Width ?");
                        }
                        else
                        {
                            decimal input, input2;
                            result = "";
                            if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                                (Decimal.TryParse(txtInput2.Text, out input2)))
                            {
                                result += "Perimeter: ";
                                result += Convert.ToString(rectanglePerimeter(input, input2));
                                lblArea.Visible = true;
                                lblArea.Text = result;
                            }
                            else
                            {
                                MessageBox.Show("Please verify valid value entered");
                            }
                        }
                    }
                    else if (choice == "Area and Perimeter")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Length?,Width?");
                        }
                        else
                        {
                            decimal input, input2;
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
                            }
                            else
                            {
                                MessageBox.Show("Please verify valid value entered");
                            }
                        }
                    }
                    break;
                case "Circle":

                    if (choice == "Area")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Radius?");
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
                    else if (choice == "Perimeter")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Radius?");
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
                            }
                            else
                            {
                                MessageBox.Show("Please verify valid value entered");
                            }
                        }
                    }
                    else if (choice == "Area and Perimeter")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Radius?");
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
                            }
                            else
                            {
                                MessageBox.Show("Please verify valid value entered");
                            }
                        }
                    }
                    break;
                case "Triangle":
                    if (choice == "Area")
                    {
                        pbShape.Visible = true;
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Base?,Height?");
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
                    else if (choice == "Perimeter")
                    {
                        pbShape.Visible = true;
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Side A?,Side B?,Side C?");
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
                            }
                            else
                            {
                                MessageBox.Show("Please verify valid value entered");
                            }
                        }
                    }
                    else if (choice == "Area and Perimeter")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Side A?,Side B?,Side C?,Height?");
                        }
                        else
                        {
                            decimal input, input2, input3, input4;
                            result = "";
                            if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                                (Decimal.TryParse(txtInput2.Text, out input2)) &&
                                (Decimal.TryParse(txtInput2.Text, out input3)) &&
                                (Decimal.TryParse(txtInput2.Text, out input4)))
                            {
                                result += "Area: ";
                                result += Convert.ToString(triangleArea(input2, input4));
                                result += "\n";
                                result += "Perimeter: ";
                                result += Convert.ToString(trianglePerimeter(input, input2, input3));
                                lblArea.Visible = true;
                                lblArea.Text = result;

                                lblArea.Visible = true;
                                lblArea.Text = result;
                            }
                            else
                            {
                                MessageBox.Show("Please verify valid value entered");
                            }
                        }
                    }
                    break;
                case "Parallelogram":
                    if (choice == "Area")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Height ?,Base ?");
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
                    else if (choice == "Perimeter")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Side A ?,Side B ?");
                        }
                        else
                        {
                            decimal input, input2;
                            result = "";
                            if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                                (Decimal.TryParse(txtInput2.Text, out input2)))
                            {
                                result += "Perimeter: ";
                                result += Convert.ToString(parallelogramPerimeter(input, input2));
                                lblArea.Visible = true;
                                lblArea.Text = result;
                            }
                            else
                            {
                                MessageBox.Show("Please verify valid value entered");
                            }
                        }
                    }
                    else if (choice == "Area and Perimeter")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Base ?,Side B ?,Height ?");
                        }
                        else
                        {
                            decimal input, input2, input3;
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
                            }
                            else
                            {
                                MessageBox.Show("Please verify valid value entered");
                            }
                        }
                    }
                    break;
                case "Rhombus":
                    if (choice == "Area")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Height ?,Base ?");
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
                    else if (choice == "Perimeter")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Side A ?");
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
                            }
                            else
                            {
                                MessageBox.Show("Please verify valid value entered");
                            }
                        }
                    }
                    else if (choice == "Area and Perimeter")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Base ?,Height ?");
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
                                result += "\n";
                                result += "Perimeter: ";
                                result += Convert.ToString(parallelogramPerimeter(input, input));
                                lblArea.Visible = true;
                                lblArea.Text = result;
                            }
                            else
                            {
                                MessageBox.Show("Please verify valid value entered");
                            }
                        }
                    }
                    break;
                case "Trapezoid":
                    if (choice == "Area")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Side A?,Segment B?,Segment C?,Height?");
                        }
                        else
                        {
                            decimal input, input2, input3, input4;
                            result = "";
                            if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                                (Decimal.TryParse(txtInput2.Text, out input2)) &&
                                (Decimal.TryParse(txtInput3.Text, out input3)) &&
                                (Decimal.TryParse(txtInput4.Text, out input4)))
                            {
                                result += "Area: ";
                                result += Convert.ToString(trapezoidArea(input, input2, input3, input4));
                                lblArea.Visible = true;
                                lblArea.Text = result;
                            }
                            else
                            {
                                MessageBox.Show("Please verify valid value entered");
                            }
                        }
                    }
                    else if (choice == "Perimeter")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Side A?,Segment B?,Segment C?,Height?");
                        }
                        else
                        {
                            decimal input, input2, input3, input4;
                            result = "";
                            if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                                (Decimal.TryParse(txtInput2.Text, out input2)) &&
                                (Decimal.TryParse(txtInput3.Text, out input3)) &&
                                (Decimal.TryParse(txtInput4.Text, out input4)))
                            {
                                result += "Perimeter: ";
                                result += Convert.ToString(trapezoidPerimeter(input, input2, input3, input4));
                                lblArea.Visible = true;
                                lblArea.Text = result;
                            }
                            else
                            {
                                MessageBox.Show("Please verify valid value entered");
                            }
                        }
                    }
                    else if (choice == "Area and Perimeter")
                    {
                        if (btnCalculate.Text == "Calculate")
                        {
                            setUpInputs("Side A?,Segment B?,Segment C?,Height?");
                        }
                        else
                        {
                            decimal input, input2, input3, input4;
                            result = "";
                            if ((Decimal.TryParse(txtInput1.Text, out input)) &&
                                (Decimal.TryParse(txtInput2.Text, out input2)) &&
                                (Decimal.TryParse(txtInput3.Text, out input3)) &&
                                (Decimal.TryParse(txtInput4.Text, out input4)))
                            {
                                result += "Area: ";
                                result += Convert.ToString(trapezoidArea(input, input2, input3, input4));
                                result += "\n";
                                result += "Perimeter: ";
                                result += Convert.ToString(trapezoidPerimeter(input, input2, input3, input4));
                                lblArea.Visible = true;
                                lblArea.Text = result;
                            }
                            else
                            {
                                MessageBox.Show("Please verify valid value entered");
                            }
                        }
                    }
                    break;
            }  
        //<non-shapes> use special handling since shape selection irrelevant.
            if (choice == "modulus" && btnCalculate.Text != "Calculate")
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
        }

        //modulus, exponents, and percentage buttons
        private void btnModulus_Click(object sender, EventArgs e)
        {
            inputInitialize();
            setUpInputs("Numerator?,Denominator?");
            choice = "modulus";
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            inputInitialize();
            choice = "percentage";
            setUpInputs("Whole?,Percent?");
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {
            inputInitialize();
            choice = "exponent";
            setUpInputs("Base?,Power?");
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
        public decimal trapezoidArea(decimal top, decimal bottom1, decimal bottom2, decimal height)
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
            decimal total = Convert.ToDecimal(Math.Pow(Convert.ToDouble(number), 
                Convert.ToDouble(exponent)));
            return total;
        }

        //end of the calculation functions
        private void btnClear_Click(object sender, EventArgs e)
        {inputInitialize();}

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
            {MessageBox.Show("No File");}
        }
        //</private void for shape images>

        //<private void for formula images>
        private void showFormulae()
        {
            try
            {
                switch (shape)
                {
                    case "Triangle":
                        if (choice == "Area")
                        { pbFormula.Image = Properties.Resources.triangleArea; }
                        else if (choice == "Perimeter")
                        { pbFormula.Image = Properties.Resources.trianglePerimeter; }
                        else
                        { pbFormula.Image = null; }
                        break;

                    case "Rhombus":
                        if (choice == "Area")
                        { pbFormula.Image = Properties.Resources.rhombusArea; }
                        else if (choice == "Perimeter")
                        { pbFormula.Image = Properties.Resources.rhombusPerimeter;}
                        else
                        { pbFormula.Image = null;}
                        break;

                    case "Rectangle":
                        if (choice == "Area")
                        {pbFormula.Image = Properties.Resources.rectArea;}
                        else if (choice == "Perimeter")
                        {pbFormula.Image = Properties.Resources.rectPerimeter;}
                        else
                        {pbFormula.Image = null;}
                        break;

                    case "Circle":
                        if (choice == "Area")
                        {pbFormula.Image = Properties.Resources.circleArea;}
                        else if (choice == "Perimeter")
                        {pbFormula.Image = Properties.Resources.circlePerimeter;}
                        else
                        {pbFormula.Image = null;}
                        break;

                    case "Square":
                        if (choice == "Area")
                        {pbFormula.Image = Properties.Resources.squareArea;}
                        else if (choice == "Perimeter")
                        {pbFormula.Image = Properties.Resources.squarePerimeter;}
                        else
                        {pbFormula.Image = null;}
                        break;

                    case "Parallelogram":
                        if (choice == "Area")
                        {pbFormula.Image = Properties.Resources.parallelogramArea;}
                        else if (choice == "Perimeter")
                        {pbFormula.Image = Properties.Resources.parallelogramPerimeter;}
                        else {pbFormula.Image = null;}
                        break;

                    case "Trapezoid":
                        if (choice == "Area")
                        {pbFormula.Image = Properties.Resources.trapezoidArea;}
                        else if (choice == "Perimeter")
                        {pbFormula.Image = Properties.Resources.trapezoidPerimeter;}
                        else
                        {pbFormula.Image = null;}
                        break;
                }
            }
            catch
            { MessageBox.Show("No File"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {inputInitialize();}
    }
}
