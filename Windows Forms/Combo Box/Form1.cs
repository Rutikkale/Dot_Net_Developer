using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text !="")
            {
                if (HobbiesComboBox.Items.Contains(textBox1.Text))
                {
                    MessageBox.Show("Item Already Exists");
                }
                else
                {
                    HobbiesComboBox.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Fill the Item in textBox");
            }
        }

        private void Count_button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Items Are:" + HobbiesComboBox.Items.Count);
        }

        private void RemoveSpecificItemsbutton2_Click(object sender, EventArgs e)
        {
            HobbiesComboBox.Items.Remove(HobbiesComboBox.SelectedItem);
           //HobbiesComboBox.Items.RemoveAt(HobbiesComboBox.SelectedIndex);
        }

        private void ClearItemsbutton3_Click(object sender, EventArgs e)
        {
            HobbiesComboBox.Items.Clear();
        }

        private void Sortbutton4_Click(object sender, EventArgs e)
        {
            HobbiesComboBox.Sorted = true;
        }

        private void HobbiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            string ShowHobbies = HobbiesComboBox.SelectedItem.ToString();

            label3.Text = "Your Selected Hobbies is: " + ShowHobbies;
            label3.Visible = true;
        }
    }
}
