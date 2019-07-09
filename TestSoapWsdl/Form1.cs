using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSoapWsdl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference.CalculatorSoapClient client = new ServiceReference.CalculatorSoapClient();
            textBox3.Text = client.Add(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();

        }
    }
}
