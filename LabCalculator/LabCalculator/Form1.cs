using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var res = Calculator.Evaluate(textBox1.Text);
                label1.Text = (res == 1.0) ? "True" : "False";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "The mistake in the expression");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
