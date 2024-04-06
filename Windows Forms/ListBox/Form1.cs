using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
         FruitlistBox.Items.Add(textBox1.Text);
         textBox1.Clear();
         textBox1.Focus();

        }

        private void Count_button2_Click(object sender, EventArgs e)
        {
           int count = FruitlistBox.Items.Count;
            MessageBox.Show("Fruit list count Item : "+count.ToString());
        }

        private void Sort_button3_Click(object sender, EventArgs e)
        {
            FruitlistBox.Sorted = true;
        }

        private void Remove_button4_Click(object sender, EventArgs e)
        {
           //FruitlistBox.Items.Remove(FruitlistBox.SelectedItems);
           // FruitlistBox.Items.RemoveAt(FruitlistBox.SelectedIndex);

        }

        private void Clear_ListBox_button5_Click(object sender, EventArgs e)
        {
            FruitlistBox.Items.Clear();
        }
    }
}
