using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Addition_button_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 + num2;

                label4.Text = "Additon Result is: " + result.ToString();
                label4.Visible = true;

                // MessageBox.Show("Additon Result is: "+ result.ToString());
            }
            else
            {
                MessageBox.Show("Please Fill both fields!!");
            }
        }

        private void Subtraction_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 - num2;

                label4.Text = "Substraction Result is: " + result.ToString();
                label4.Visible = true;

                // MessageBox.Show("Substraction Result is: "+ result.ToString());
            }
            else
            {
                MessageBox.Show("Please Fill both fields!!");
            }
        }

        private void Multiply_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 * num2;

                label4.Text = "Multiplication Result is: " + result.ToString();
                label4.Visible = true;

                // MessageBox.Show("Multiplication Result is: "+ result.ToString());
            }
            else
            {
                MessageBox.Show("Please Fill both fields!!");
            }
        }

        private void Division_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 / num2;

                label4.Text = "Division Result is: " + result.ToString();
                label4.Visible = true;

                // MessageBox.Show("Division Result is: "+ result.ToString());
            }
            else
            {
                MessageBox.Show("Please Fill both fields!!");
            }
        }
    }
}
