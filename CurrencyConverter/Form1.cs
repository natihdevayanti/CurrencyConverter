using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if(usdRadioButton.Checked == true)
            {
                radioButtonLabel.Text = "Choose One!";
                radioButtonLabel.ForeColor = Color.Black;

                if (string.IsNullOrEmpty(inputBox.Text))
                {
                    inputBoxLabel.Text = "Insert number in IDR!";
                    inputBoxLabel.ForeColor = Color.Red;
                } else
                {
                    inputBoxLabel.Text = "IDR";
                    inputBoxLabel.ForeColor = Color.Black;

                    double output = double.Parse(inputBox.Text) * 0.000069;

                    outputBox.Text = output.ToString();
                    outputBoxLabel.Text = usdRadioButton.Text;
                }
            }
           
            else if (jpyRadioButton.Checked == true)
            {
                radioButtonLabel.Text = "Choose One!";
                radioButtonLabel.ForeColor = Color.Black;

                if (string.IsNullOrEmpty(inputBox.Text))
                {
                    inputBoxLabel.Text = "Insert number in IDR!";
                    inputBoxLabel.ForeColor = Color.Red;
                }
                else
                {
                    inputBoxLabel.Text = "IDR";
                    inputBoxLabel.ForeColor = Color.Black;

                    double output = double.Parse(inputBox.Text) * 0.000075;

                    outputBox.Text = output.ToString();
                    outputBoxLabel.Text = jpyRadioButton.Text;
                }
            }
            else if (eurRadioButton.Checked == true)
            {
                radioButtonLabel.Text = "Choose One!";
                radioButtonLabel.ForeColor = Color.Black;

                if (string.IsNullOrEmpty(inputBox.Text))
                {
                    inputBoxLabel.Text = "Insert number in IDR!";
                    inputBoxLabel.ForeColor = Color.Red;
                }
                else
                {
                    inputBoxLabel.Text = "IDR";
                    inputBoxLabel.ForeColor = Color.Black;

                    double output = double.Parse(inputBox.Text) * 0.000058;

                    outputBox.Text = output.ToString();
                    outputBoxLabel.Text = eurRadioButton.Text;
                }
            }

            else
            {
                radioButtonLabel.Text = "Select one, please!";
                radioButtonLabel.ForeColor = Color.Red;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
