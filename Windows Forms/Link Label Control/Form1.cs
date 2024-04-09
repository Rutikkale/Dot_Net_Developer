using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // using system.Diagnostics for process class jump to another link are present in linklable

namespace Link_Label_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //1) for open the link 
            // Process.Start("http://www.google.com");

            //2) For open the Form
            Form2 F2 = new Form2();
            F2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
        }
    }
}
