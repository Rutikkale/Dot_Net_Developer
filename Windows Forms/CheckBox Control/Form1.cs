using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_Control
{
    public partial class Form1 : Form
    {
        string Text1 = "";
        string Text2 = "";
        string Text3 = "";
        string Text4 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void SamsungCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(SamsungCheck.Checked== true)
            {
                Text1= SamsungCheck.Text;
            }
            else
            {
                Text1 = "";
            }
        }

        private void NokiaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(NokiaCheck.Checked== true)
            {
                Text2 = NokiaCheck.Text;
            }
            else
            {
                Text2 = "";
            }
        }

        private void OnePlusCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (OnePlusCheck.Checked==true)
            {
                Text3 = OnePlusCheck.Text;
            }
            else
            {
                Text3 = "";
            }
        }

        private void IPhoneCkeck_CheckedChanged(object sender, EventArgs e)
        {
            if(IPhoneCkeck.Checked== true)
            {
                Text4 = IPhoneCkeck.Text;
            }
            else
            {
                Text4 = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Selected Companies Are: " + Text1 + " " + Text2 +" "+ Text3 +" "+Text4);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = checkBox1.Checked;
        }
    }
}
