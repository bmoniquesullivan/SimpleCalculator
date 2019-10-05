/***************************************************************
* Student: Barbara Sullivan                                    *
* Instructor: Dr. Jerry Mamo                                   *
* Class: CIST 2341 – C# Programming – 60485 – Summer 2019      * 
* Lab #9 - Error Handling(Exceptions) - Simple Calculator      *
****************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)

        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        //Assign first number of the calculation
        double total1 = 0;

        //Assign first number of the calculation
        double total2 = 0;

        //Boolean for operation Buttons
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;


        //Show result of calculation when button "=" is clicked
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked == true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }
            else if (minusButtonClicked == true)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (multiplyButtonClicked == true)
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }
            else if (divideButtonClicked == true)
            {

                total2 = total1 / double.Parse(txtDisplay.Text);

            }

            txtDisplay.Text = total2.ToString();
            label1.Text = total2.ToString();
            total1 = 0;

            //Throwing Exception to Handle Denominator Zero, which results on an infinity Values or Non-numeric Value(NaN)
            try
            {
                if ((double.IsInfinity(total2)) || (double.IsNaN(total2)))
                {

                    throw new ArithmeticException();
                }
            }
            catch
            {
                MessageBox.Show("Denominator can't be Zero. Try again");
                total1 = 0;
                total2 = 0;
                txtDisplay.Clear();
            }
        }


        //Make button "." work to use with decimals
        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

        //Perform addition operation
        private void btnPlus_Click(object sender, EventArgs e)
        {
            //Throwing Exception to handle input in String Format
            try
            {
                total1 = total1 + double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Only entry numeric values");
                txtDisplay.Clear();
            }

            plusButtonClicked = true;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        //Perform subtraction operation
        private void btnMinus_Click(object sender, EventArgs e)
        {
            //Throwing Exception to handle input in String Format
            try
            {
                total1 = total1 + double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Only entry numeric values");
                txtDisplay.Clear();
            }

            plusButtonClicked = false;
            minusButtonClicked = true;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        //Perform multiplication operation
        private void btnTimes_Click(object sender, EventArgs e)
        {
            //Throwing Exception to handle input in String Format
            try
            {
                total1 = total1 + double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Only entry numeric values");
                txtDisplay.Clear();
            }
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = true;
        }

        //Perform division operation
        private void btnDivide_Click(object sender, EventArgs e)
        {
            //Throwing Exception to handle input in String Format
            try
            {
                total1 = total1 + double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Only entry numeric values");
                txtDisplay.Clear();
            }
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = true;
            multiplyButtonClicked = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        //Make menu options Clear and Exit available
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String exitMsg = "Do you want to close your calculator?";
            String exitTitle = "Simple Calculator - Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(exitMsg, exitTitle, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Change background color from Menu Colors
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Lavender;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        //Show info on About Section from Menu
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String title = "Simple Calculator 1.0";
            String message = Environment.NewLine + "Simple Calculator Software" + Environment.NewLine + "Version 1.0" + Environment.NewLine + "Created by Barbara Sullivan" + Environment.NewLine + "on Jun 12, 2019";
            DialogResult resultabout = MessageBox.Show(message, title);

        }

        //Create Variable to Memory
        double memory;

        //Content of Result TextBox will be stored at variable memory
        private void btnMemory_Click(object sender, EventArgs e)
        {

            if (txtDisplay.Text.Length == 0)
            {
                memory = 0;
            }
            else
            {
                memory = double.Parse(txtDisplay.Text);

            }


        }
        //Show result stored on memory variable on Label when mouse hover
        private void lblMemoryContent_Click(object sender, EventArgs e)
        {

        }

        private void lblMemoryContent_MouseLeave(object sender, EventArgs e)
        {
            lblMemoryContent.Text = "      ";
        }

        private void lblMemoryContent_MouseHover(object sender, EventArgs e)
        {
            lblMemoryContent.Text = memory.ToString();
            lblMemoryContent.Show();

        }
        //Add memory content to the number on Result TextBox
        double result;
        private void btnMemoryPlus_Click(object sender, EventArgs e)
        {
            result = memory + double.Parse(txtDisplay.Text);
            memory = result;
        }
    }
}

