﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                MessageBox.Show("You Have Selected:"+radioButton1.Text);
            }
            else if(radioButton2.Checked == true)
            {
                MessageBox.Show("You Have Selected:" + radioButton2.Text);
            }
            else if (radioButton3.Checked == true)
            {
                MessageBox.Show("You Have Selected:" + radioButton3.Text);
               
            }
            else
            {
                MessageBox.Show("Please Select Country!!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                groupBox1.BackColor = Color.Red;
            }
            else if (radioButton5.Checked == true)
            {
                groupBox1.BackColor = Color.Green;
            }
            else if (radioButton6.Checked == true)
            {
                groupBox1.BackColor = Color.Blue;
            }
            else
            {
                MessageBox.Show("Plese select Colour!!");
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (radioButton7.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Purple;
            }
            else if (radioButton8.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Orange;
            }
            else if (radioButton9.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Brown;
            }
            else
            {
                MessageBox.Show("Plese select Colour!!");
            }
        }
    }
}
