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

    public partial class Form1 : Form
    {
        private double input1;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAC_Click(object sender, EventArgs e)
        {
            resultsrn.Text = "";
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double result = 0;
            double input2 = Convert.ToDouble(resultsrn.Text);
            double add = input1 + input2;
            result = add;
            resultsrn.Text = Convert.ToString(result);
            label1.Text = Convert.ToString(input1) + "+" + Convert.ToString(input2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(resultsrn.Text))
            {
                return;
            }
            else
            {
                resultsrn.Text = resultsrn.Text + "0";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(resultsrn.Text))
            {
                resultsrn.Text = resultsrn.Text + "0.";
            }
            else if (!resultsrn.Text.Contains("."))
            {
                resultsrn.Text = resultsrn.Text + ".";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            resultsrn.Text = resultsrn.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            resultsrn.Text = resultsrn.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            resultsrn.Text = resultsrn.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            resultsrn.Text = resultsrn.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            resultsrn.Text = resultsrn.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            resultsrn.Text = resultsrn.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            resultsrn.Text = resultsrn.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            resultsrn.Text = resultsrn.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            resultsrn.Text = resultsrn.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToDouble(resultsrn.Text);
            label1.Text = input1 + "+";
            resultsrn.Text = "";
        }

        private void resultsrn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
