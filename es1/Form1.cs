using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnaddcus_Click(object sender, EventArgs e)
        {
            customerform customer = new customerform();
            customer.Show();
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}