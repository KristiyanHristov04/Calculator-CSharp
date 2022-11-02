using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KristiyanHristovCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer calcSound = new SoundPlayer("CalculatorSoundEffect.wav");
        
        double firstNumberValue = 0;
        double secondNumberValue = 0;
        double result = 0;
        string firstNumberStringValue = string.Empty;
        string secondNumberStringValue = string.Empty;

        bool isInOperationMode = false;

        bool isInAdditionMode = false;
        bool isInSubtractionMode = false;
        bool isInMultiplicationMode = false;
        bool isInDivisionMode = false;
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNumberValue(button1);
            calcSound.Play();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNumberValue(button2);
            calcSound.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNumberValue(button3);
            calcSound.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNumberValue(button4);
            calcSound.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddNumberValue(button5);
            calcSound.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddNumberValue(button6);
            calcSound.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddNumberValue(button7);
            calcSound.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddNumberValue(button8);
            calcSound.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddNumberValue(button9);
            calcSound.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddNumberValue(button10);
            calcSound.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddNumberValue(button11);
            calcSound.Play();
        }

        private void addButton_Click(object sender, EventArgs e)
        { 
            isInOperationMode = true;
            isInAdditionMode = true;
            textBox1.Text = "+";
            calcSound.Play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calcSound.Play();
            firstNumberValue = Convert.ToDouble(firstNumberStringValue);
            secondNumberValue = Convert.ToDouble(secondNumberStringValue);

            if (isInAdditionMode)
            {
                result = firstNumberValue + secondNumberValue;
                textBox1.Text = result.ToString();
                secondNumberStringValue = string.Empty;
                firstNumberStringValue = result.ToString();
                isInAdditionMode = false;
                isInOperationMode = false;
            }
            else if (isInSubtractionMode)
            {
                result = firstNumberValue - secondNumberValue;
                textBox1.Text = result.ToString();
                secondNumberStringValue = string.Empty;
                firstNumberStringValue = result.ToString();
                isInSubtractionMode = false;
                isInOperationMode = false;
            }
            else if (isInMultiplicationMode)
            {
                result = firstNumberValue * secondNumberValue;
                textBox1.Text = result.ToString();
                secondNumberStringValue = string.Empty;
                firstNumberStringValue = result.ToString();
                isInMultiplicationMode = false;
                isInOperationMode = false;
            }
            else if (isInDivisionMode)
            {
                result = firstNumberValue / secondNumberValue;
                textBox1.Text = result.ToString();
                secondNumberStringValue = string.Empty;
                firstNumberStringValue = result.ToString();
                isInDivisionMode = false;
                isInOperationMode = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstNumberStringValue = string.Empty;
            secondNumberStringValue = string.Empty;
            firstNumberValue = 0;
            secondNumberValue = 0;
            textBox1.Text = "0";
            calcSound.Play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            isInOperationMode = true;
            isInSubtractionMode = true;
            textBox1.Text = "-";
            calcSound.Play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            isInOperationMode = true;
            isInMultiplicationMode = true;
            textBox1.Text = "X";
            calcSound.Play();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            isInOperationMode = true;
            isInDivisionMode = true;
            textBox1.Text = "/";
            calcSound.Play();
        }
        private void AddNumberValue(Button button)
        {
            if (!isInOperationMode)
            {
                firstNumberStringValue += button.Text;
                textBox1.Text = firstNumberStringValue;
            }
            else
            {
                secondNumberStringValue += button.Text;
                textBox1.Text = secondNumberStringValue;
            }
        }

        private void button14_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
